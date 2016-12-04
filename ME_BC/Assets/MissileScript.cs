using UnityEngine;
using System.Collections;

public class MissileScript : ProjectileBase {
	public Transform target;
	float t = 0;
	float distance;
	// Use this for initialization
	void Awake () {
		speed = 20f;
		damage = 200f;
		lifetime = 15f;
		type = "Missile";
	}

	void Start()
	{
		base.Start ();
		distance = Vector3.Distance (emitter.position, target.position);
	}
	// Update is called once per frame
	void Update () {
		base.Update ();
		if(target != null)
			transform.position = Vector3.Lerp(emitter.position, target.position, t / (distance / speed));
		t += Time.deltaTime;
	}

}
