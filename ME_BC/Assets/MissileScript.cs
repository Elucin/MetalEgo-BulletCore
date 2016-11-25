using UnityEngine;
using System.Collections;

public class MissileScript : ProjectileBase {
	public Transform target;
	float t = 0;
	float distance;
	// Use this for initialization
	void Awake () {
		speed = 10f;
		damage = 100f;
		lifetime = 8f;
	}

	void Start()
	{
		base.Start ();
		distance = Vector3.Distance (emitter.position, target.position);
	}
	// Update is called once per frame
	void Update () {
		base.Update ();
		transform.position = Vector3.Slerp(emitter.position, target.position, t / (distance / speed));
		t += Time.deltaTime;
	}
}
