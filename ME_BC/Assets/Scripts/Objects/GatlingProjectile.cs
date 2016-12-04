using UnityEngine;
using System.Collections;

public class GatlingProjectile : ProjectileBase {
	
	// Use this for initialization
	float scaleLimit;
	float z;

	void Awake()
	{
		speed = 200f;
		damage = 40f;
		scaleLimit = 0.2f;
		z = 10.0f;
		lifetime = 2f;
		type = "Gatling";
	}

	protected override void Start() {
		base.Start();
		float randomRadius = Random.Range(0, scaleLimit);
		float randomAngle = Random.Range(0, 2 * Mathf.PI);
		Vector3 direction = Random.insideUnitCircle * scaleLimit;
		direction.z = z;
		direction = emitter.TransformDirection(direction.normalized);
		GetComponent<Rigidbody>().velocity = direction * speed;
	}

	protected override void Update()
	{
		base.Update ();
	}
}
