using UnityEngine;
using System.Collections;

public class LookAtTarget : MonoBehaviour {
	public Transform target;
	Transform cam;



	// Use this for initialization
	void Start () {
		cam = GameObject.Find("camPosition").transform;

	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		//Ray ray = cam.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height/2, 0));
		//if (Physics.Raycast(target.position, target.TransformDirection(Vector3.forward), out hit, 10000f))
		if (Physics.Raycast(cam.position, (target.position - cam.transform.position).normalized, out hit, 10000f))
			transform.LookAt(hit.point);
		else
			transform.LookAt((target.position - cam.position).normalized * 10000.0f - transform.position);
	}
}
