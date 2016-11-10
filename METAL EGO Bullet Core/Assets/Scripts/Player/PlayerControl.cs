using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	const int AXIS_GRAVITY = 30;
	const float SPEED_DENOM = 0.075f;
	const float MAX_SPEED = 10f;
	const float MAX_TURN_SPEED = 1f;

	System.Collections.Generic.List<float> speeds;
	float oldAxisPos;

	Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody> ();
		oldAxisPos = 0f;
		speeds = new System.Collections.Generic.List<float> ();
	}
	
	// Update is called once per frame
	void Update () {
		Movement ();
		//speedCoefficient = GetSpeedCoefficient ();
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
		Debug.Log ((1 + Input.GetAxis("j3_X")) - (1 + Input.GetAxis("j3_Y")));
		return (1 + Input.GetAxis("j3_X")) - (1 + Input.GetAxis("j3_Y"));
		/*
		if (Input.GetAxis ("j3_X") > Input.GetAxis ("j3_Y"))
			return Input.GetAxis ("j3_X");
		else if (Input.GetAxis("j3_X") < Input.GetAxis("j3_Y"))
			return Input.GetAxis ("j3_X"); */

	}

	void Movement()
	{
		rigidBody.velocity = transform.TransformDirection(new Vector3 (0, 0, MAX_SPEED) * GetSpeedCoefficient ());
		rigidBody.angularVelocity = new Vector3 (0, -GetTurnCoefficient () / 2, 0);
	}
}
