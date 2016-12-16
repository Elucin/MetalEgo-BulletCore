using UnityEngine;
using System.Collections;

public class ControlDebug : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string[] joysticks = Input.GetJoystickNames ();
		foreach (string j in joysticks) {
			Debug.Log (j);
		}
	}
	
	// Update is called once per frame
	void LateUpdate () {
		//DebugJoy1 ();
		//DebugJoy2 ();
		DebugJoy3 ();	
	}

	void DebugJoy1()
	{
		if (Input.GetButtonDown ("FireRightGatling"))
			Debug.Log ("Right - Button 0");
		if (Input.GetButtonDown ("FireRightMissile"))
			Debug.Log ("Right - Button 1");
		if (Input.GetButtonDown ("j1_b2"))
			Debug.Log ("Right - Button 2");
		if (Input.GetButtonDown ("j1_b3"))
			Debug.Log ("Right - Button 3");
		if (Input.GetButtonDown ("j1_b4"))
			Debug.Log ("Right - Button 4");
		if (Input.GetButtonDown ("j1_b5"))
			Debug.Log ("Right - Button 5");

		if (Mathf.Abs(Input.GetAxis ("j1_X")) > 0.05f)
			Debug.Log ("Right - X Axis");
		if (Mathf.Abs(Input.GetAxis ("j1_Y")) > 0.05f)
			Debug.Log ("Right - Y Axis");
		if (Mathf.Abs(Input.GetAxis ("j1_Z")) > 0.05f)
			Debug.Log ("Right - Z Axis");	
	}

	void DebugJoy2()
	{
		if (Input.GetButtonDown ("FireLeftGatling"))
			Debug.Log ("Left - Button 0");
		if (Input.GetButtonDown ("FireLeftMissile"))
			Debug.Log ("Left - Button 1");
		if (Input.GetButtonDown ("j2_b2"))
			Debug.Log ("Left - Button 2");
		if (Input.GetButtonDown ("j2_b3"))
			Debug.Log ("Left - Button 3");
		if (Input.GetButtonDown ("j2_b4"))
			Debug.Log ("Left - Button 4");
		if (Input.GetButtonDown ("j2_b5"))
			Debug.Log ("Left - Button 5");

		if (Mathf.Abs(Input.GetAxis ("j2_X")) > 0.05f)
			Debug.Log ("Left - X Axis");
		if (Mathf.Abs(Input.GetAxis ("j2_Y")) > 0.05f)
			Debug.Log ("Left - Y Axis");
		if (Mathf.Abs(Input.GetAxis ("j2_Z")) > 0.05f)
			Debug.Log ("Left - Z Axis: " + Input.GetAxis("j2_Z"));
		
	}

	void DebugJoy3()
	{
		if (Input.GetAxis ("j3_X") > 0.05f)
			Debug.Log ("Pedals - Left Foot");
		if (Input.GetAxis ("j3_Y") > 0.05f)
			Debug.Log ("Pedals - Right Foot");
		if (Input.GetAxis ("j3_Z") > 0.05f)
			Debug.Log ("Pedals - Right Forward");
		else if (Input.GetAxis ("j3_Z") < -0.05f)
			Debug.Log ("Pedals - Left Forward");
	}
}
