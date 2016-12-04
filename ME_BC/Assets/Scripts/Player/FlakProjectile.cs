using UnityEngine;
using System.Collections;

public class FlakProjectile : ProjectileBase {


	// Use this for initialization
	float scaleLimit;
	float z;
	bool detonate;
	float explodeTime = 0.1f;
	float startTime;
	public SphereCollider explosionRadius;
	float maxExplosionRadius = 13f;
		
	void Awake()
	{
		speed = 150f;
		damage = 60f;
		scaleLimit = 0.2f;
		z = 10.0f;
		lifetime = Random.Range(0.5f, 1.5f);
		startTime = Time.time;
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
		if (!detonate && Time.time - startTimer > lifetime) {
			detonate = true;
			StartCoroutine (DelayDestroy ());
			startTime = Time.time;
		}
		
		if (detonate) {
			explosionRadius.radius = maxExplosionRadius * ((Time.time - startTime) / explodeTime);
		}
	}

	IEnumerator DelayDestroy()
	{
		Instantiate (impactParticles, transform.position, Quaternion.identity);
		rigidBody.constraints = RigidbodyConstraints.FreezeAll;
		yield return new WaitForSeconds (explodeTime);
		Destroy (gameObject);
	}

	void OnTriggerEnter(Collider c)
	{
		if (!detonate && c.CompareTag("Enemy")) {
			detonate = true;
			StartCoroutine (DelayDestroy ());
			startTime = Time.time;
		} else if (detonate && c.CompareTag("Enemy") && Time.time - startTime < explodeTime)
			c.gameObject.GetComponent<CharacterBase> ().DamageReceived (damage);

	}

}
