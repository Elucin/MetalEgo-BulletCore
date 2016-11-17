using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	const int AXIS_GRAVITY = 30;
	const float SPEED_DENOM = 0.075f;
	const float MAX_SPEED = 10f;
	const float MAX_TURN_SPEED = 1f;
	const int TARGET_SMOOTHING = 10;
	public GameObject RightPivot;
	public GameObject LeftPivot;

	bool crouching;
	bool canJump;
	float jumpPower;
	float maxJumpForce; //Modified by crouching height

	System.Collections.Generic.List<float> j1_xAxis;
	System.Collections.Generic.List<float> j1_yAxis;
	System.Collections.Generic.List<float> j2_xAxis;
	System.Collections.Generic.List<float> j2_yAxis;

	System.Collections.Generic.List<float> speeds;
	float oldAxisPos;

	Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody> ();
		oldAxisPos = 0f;
		speeds = new System.Collections.Generic.List<float> ();
		j1_xAxis = new System.Collections.Generic.List<float> ();
		j1_yAxis = new System.Collections.Generic.List<float> ();
		j2_xAxis = new System.Collections.Generic.List<float> ();
		j2_yAxis = new System.Collections.Generic.List<float> ();
		jumpPower = 0;

	}
	
	// Update is called once per frame
	void Update () {
		j1_xAxis.Add(Input.GetAxis ("j1_X"));
		j1_yAxis.Add(Input.GetAxis ("j1_Y"));
		j2_xAxis.Add(Input.GetAxis ("j2_X"));
		j2_yAxis.Add(Input.GetAxis ("j2_Y"));
		if (j1_xAxis.Count > TARGET_SMOOTHING)
			j1_xAxis.RemoveAt (0);
		if (j1_yAxis.Count > TARGET_SMOOTHING)
			j1_yAxis.RemoveAt (0);
		if (j2_xAxis.Count > TARGET_SMOOTHING)
			j2_xAxis.RemoveAt (0);
		if (j2_yAxis.Count > TARGET_SMOOTHING)
			j2_yAxis.RemoveAt (0);
		
		Movement ();
		Targeting ();
		//CrouchAndJump ();
	}

	void FixedUpdate()
	{
		
	}

	float GetSpeedCoefficient()
	{
		float speedCoef = 0f;
		float axisDelta;
		float newAxisPos;

		newAxisPos = Mathf.Abs (Input.GetAxis ("j3_Z"));
		axisDelta = Mathf.Abs (newAxisPos - oldAxisPos);
		oldAxisPos = newAxisPos;
		speeds.Add (axisDelta);
		if (speeds.Count > AXIS_GRAVITY)
			speeds.RemoveAt (0);

		foreach(float s in speeds)
			speedCoef += s;
		
		speedCoef = (speedCoef /speeds.Count) / SPEED_DENOM;
		speedCoef = Mathf.Clamp (speedCoef, 0f, 1f);
		return speedCoef;
	}

	float GetTurnCoefficient()
	{
		return (1 + Input.GetAxis("j3_X")) - (1 + Input.GetAxis("j3_Y"));
	}

	void Movement()
	{
		rigidBody.velocity = transform.TransformDirection(new Vector3 (0, 0, MAX_SPEED) * GetSpeedCoefficient ());
		//If 
		if (Input.GetAxis ("j3_X") > -0.5f && Input.GetAxis ("j3_Y") > -0.5f && Mathf.Abs (GetTurnCoefficient ()) < 0.6f) {
			Camera.main.transform.localPosition = Vector3.Lerp (Camera.main.transform.localPosition, new Vector3 (0, -0.2f * (Input.GetAxis ("j3_X") + Input.GetAxis ("j3_Y") / 2f), Camera.main.transform.localPosition.z), Time.time / 100f); 
			crouching = true;
			rigidBody.angularVelocity = Vector3.zero;
		} else {
			Camera.main.transform.localPosition = Vector3.Lerp (Camera.main.transform.localPosition, new Vector3 (0, (1 - Mathf.Abs (Input.GetAxis ("j3_Z")) * 0.2f), Camera.main.transform.localPosition.z), Time.time / 50f); //Head Bob
			rigidBody.angularVelocity = new Vector3 (0, -GetTurnCoefficient () / 2, 0);
			crouching = false;
		}
		transform.localEulerAngles = new Vector3 (0, transform.localEulerAngles.y, 0);
		CrouchAndJump();
	}

	void Targeting()
	{
		RightPivot.transform.localEulerAngles = new Vector3 (35 * GetFloatListAverage(j1_yAxis), 35 + 55 *  GetFloatListAverage(j1_xAxis), 0);
		LeftPivot.transform.localEulerAngles = new Vector3 (35 * GetFloatListAverage(j2_yAxis), 325 + 55 * GetFloatListAverage(j2_xAxis), 0);
	}

	float GetFloatListAverage(System.Collections.Generic.List<float> list)
	{
		float avg = 0f;

		foreach (float f in list) {
			avg += f;
		}

		avg = avg / list.Count;
		return avg;
	}

	void CrouchAndJump()
	{
		
		if (crouching && jumpPower < 100.0f && canJump) {
			jumpPower += 75.0f * Time.deltaTime;
			jumpPower = Mathf.Clamp (jumpPower, 0, 100f);
			Debug.Log (jumpPower);
		} else if (!crouching && jumpPower > 0) {
			GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 100000f, 50000f) * jumpPower, ForceMode.Impulse);
			jumpPower = 0f;
		} else if (crouching && jumpPower >= 100.0f) {
			Debug.Log ("Fizzle");
			jumpPower = 0f;
			canJump = false;
		} else if (!crouching && jumpPower == 0f) {
			canJump = true;
		}
		
	}
}
