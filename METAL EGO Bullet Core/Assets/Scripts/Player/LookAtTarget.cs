using UnityEngine;
using System.Collections;

public class LookAtTarget : MonoBehaviour {
	public Transform target;
	Camera cam;



	// Use this for initialization
	void Start () {
		cam = Camera.main;

	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		//Ray ray = cam.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height/2, 0));

		if (Physics.Raycast(target.position, target.TransformDirection(Vector3.forward), out hit, 10000f))
			transform.LookAt(hit.point);
		else
			transform.LookAt(target.TransformDirection(Vector3.forward) * 10000.0f - transform.position);
	}
}
