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
	void Update () {
		if(Input.GetButtonDown("j1_b0"))
			Debug.Log("Right - Button 0");
		if(Input.GetButtonDown("j1_b1"))
			Debug.Log("Right - Button 1");
		if(Input.GetButtonDown("j1_b2"))
			Debug.Log("Right - Button 2");
		if(Input.GetButtonDown("j1_b3"))
			Debug.Log("Right - Button 3");
		if(Input.GetButtonDown("j1_b4"))
			Debug.Log("Right - Button 4");
		if(Input.GetButtonDown("j1_b5"))
			Debug.Log("Right - Button 5");
		
		if(Input.GetButtonDown("j2_b0"))
			Debug.Log("Left - Button 0");
		if(Input.GetButtonDown("j2_b1"))
			Debug.Log("Left - Button 1");
		if(Input.GetButtonDown("j2_b2"))
			Debug.Log("Left - Button 2");
		if(Input.GetButtonDown("j2_b3"))
			Debug.Log("Left - Button 3");
		if(Input.GetButtonDown("j2_b4"))
			Debug.Log("Left - Button 4");
		if(Input.GetButtonDown("j2_b5"))
			Debug.Log("Left - Button 5");

		if (Mathf.Abs(Input.GetAxis ("j1_X")) > 0.05f)
			Debug.Log ("Right - X Axis");
		if (Mathf.Abs(Input.GetAxis ("j1_Y")) > 0.05f)
			Debug.Log ("Right - Y Axis");
		if (Mathf.Abs(Input.GetAxis ("j1_Z")) > 0.05f)
			Debug.Log ("Right - Z Axis");

		if (Mathf.Abs(Input.GetAxis ("j2_X")) > 0.05f)
			Debug.Log ("Left - X Axis");
		if (Mathf.Abs(Input.GetAxis ("j2_Y")) > 0.05f)
			Debug.Log ("Left - Y Axis");
		if (Mathf.Abs(Input.GetAxis ("j2_Z")) > 0.05f)
			Debug.Log ("Left - Z Axis: " + Input.GetAxis("j2_Z"));

		if (Input.GetAxis ("j3_X") > 0.05f)
			Debug.Log ("Pedals - Left Foot");
		if (Input.GetAxis ("j3_Y") >  0.05f)
			Debug.Log ("Pedals - Right Foot");
		if (Input.GetAxis ("j3_Z") > 0.05f)
			Debug.Log ("Pedals - Right Forward");
		else if (Input.GetAxis ("j3_Z") < -0.05f)
			Debug.Log ("Pedals - Left Forward");
	}
}
