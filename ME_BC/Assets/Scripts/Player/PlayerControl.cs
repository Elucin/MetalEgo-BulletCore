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
	public SpriteRenderer leftReticule;
	public SpriteRenderer rightReticule;
	public Sprite[] reticuleList;
	public MissileEmit leftMissile;
	public MissileEmit rightMissile;
	public enum Reticules : int
	{
		Gattling = 0,
		Missile = 1
	};

	public static int missileAmmo = 24;
	private const int MAX_MISSILE_AMMO = 24;

	bool crouching;
	bool canJump;
	float jumpPower;
	float maxJumpForce; //Modified by crouching height
	bool isGrounded;

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
		
		isGrounded = IsGrounded ();
		Targeting ();

		if (Input.GetButtonUp ("FireLeftMissile")) {
			Debug.Log ("Fire Left");
			leftMissile.MissileFire ("left");
		}
		if (Input.GetButtonUp ("FireRightMissile")) {
			Debug.Log ("Fire Right");
			rightMissile.MissileFire ("right");
		}
		missileAmmo = Mathf.Clamp (missileAmmo, 0, MAX_MISSILE_AMMO);
		
		if (Input.GetButton ("FireLeftMissile")) {
			MissileLock(leftReticule.transform);
			leftReticule.sprite = reticuleList [(int)Reticules.Missile];
		}
		else
			leftReticule.sprite = reticuleList[(int)Reticules.Gattling];

		if (Input.GetButton ("FireRightMissile")) {
			MissileLock(rightReticule.transform);
			rightReticule.sprite = reticuleList [(int)Reticules.Missile];
		}
		else
			rightReticule.sprite = reticuleList[(int)Reticules.Gattling];
		
	}

	void FixedUpdate()
	{
		CrouchAndJump();
		Movement ();

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
		//GetComponent<Rigidbody>().AddRelativeForce(transform.TransformDirection(new Vector3 (0, 0, MAX_SPEED) * GetSpeedCoefficient ()), ForceMode.VelocityChange);
		//float yVel = GetComponent<Rigidbody> ().velocity.y + Physics.gravity.y * Time.deltaTime;
		if(isGrounded)
			GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3 (0, 0, MAX_SPEED) * GetSpeedCoefficient ());
		//GetComponent<Rigidbody> ().velocity = new Vector3 (rigidBody.velocity.x, yVel, rigidBody.velocity.z);
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
		
		if (crouching && jumpPower < 100.0f && canJump && isGrounded) {
			jumpPower += 75f * Time.deltaTime;
			jumpPower = Mathf.Clamp (jumpPower, 0, 100f);
			Debug.Log (jumpPower);
		} else if (!crouching && jumpPower > 0) {
			GetComponent<Rigidbody> ().AddForce (transform.TransformDirection(new Vector3 (0, 150f, 75f) * jumpPower), ForceMode.Impulse);
			jumpPower = 0f;
		} else if (crouching && jumpPower >= 100.0f) {
			Debug.Log ("Fizzle");
			jumpPower = 0f;
			canJump = false;
		} else if (!crouching && jumpPower == 0f) {
			canJump = true;
		}
	}

	void MissileLock(Transform ret)
	{
		int targetsLocked = 0;
		GameObject[] allEnemies = GameObject.FindGameObjectsWithTag ("Enemy");
			foreach (GameObject o in allEnemies) {
			if (Vector3.Distance (transform.position, o.transform.position) < 1000f) {
				if (Vector3.Angle (ret.position - Camera.main.transform.position, o.transform.position - Camera.main.transform.position) < 5.5f  && targetsLocked < 7) {
						targetsLocked++;
						if (ret.name.Contains ("Left"))
							o.GetComponent<MissileLockTest> ().leftMissileLock += Time.deltaTime;
						else
							o.GetComponent<MissileLockTest> ().rightMissileLock += Time.deltaTime;
					} else {
						if (ret.name.Contains ("Left"))
							o.GetComponent<MissileLockTest> ().leftMissileLock -= Time.deltaTime * 2;
						else
							o.GetComponent<MissileLockTest> ().rightMissileLock -= Time.deltaTime * 2;
					}
				} 
			}
	}


	bool IsGrounded()
	{
		RaycastHit hit;
		bool ray = Physics.Raycast (transform.position, -Vector3.up, out hit, 1.075f);
		//bool ray =  Physics.SphereCast(transform.position, 0.5f, -transform.up, out hit , 0.07f);
		return ray;
	}
}
