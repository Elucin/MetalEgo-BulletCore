using UnityEngine;
using System.Collections;

public class MissileScript : ProjectileBase {
	Transform target;
	// Use this for initialization
	void Awake () {
		speed = 50f;
		damage = 100f;
		lifetime = 8f;
	}

	void Start()
	{
		rigidBody.velocity = transform.TransformDirection(new Vector3(0f, 0f, speed));
	}
	// Update is called once per frame
	void Update () {
		transform.LookAt (target);
	}
}
