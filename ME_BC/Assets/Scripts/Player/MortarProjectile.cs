using UnityEngine;
using System.Collections;

public class MortarProjectile : ProjectileBase {
	public Vector3 origin;
	public Vector3 target;
	Vector3 vi;
	float gravity;
	float startTime;
	float explodeTime = 0.1f;
	public SphereCollider explosionRadius;
	float maxExplosionRadius = 15f;
	bool detonate = false;
	// Use this for initialization
	void Start () {
		base.Start ();
		damage = 200f;
		speed = 50f;
		gravity = -30f;
		type = "Mortar";
		float t1;
		float viy = speed;
		float a = gravity;
		t1 = -viy / a;
		float d2 = origin.y + (viy / 2) * t1;
		float t2 = Mathf.Sqrt(Mathf.Abs(target.y - d2)) / a;
		float t = t1 + t2;
		Vector3 d = (target - origin) / 2;
		d.y = 0f;
		vi = (d / t);
		vi.y = viy;
		GetComponent<Rigidbody> ().velocity = vi;

	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody> ().AddForce (Vector3.up * gravity);
		if(detonate)
			explosionRadius.radius = maxExplosionRadius * ((Time.time - startTime) / explodeTime);
	}

	void OnCollisionEnter(Collision c)
	{
		if (!detonate && c.transform.tag != "Player") {
			detonate = true;
			StartCoroutine (DelayDestroy ());
			startTime = Time.time;
		}
			
	}


	IEnumerator DelayDestroy()
	{
		Instantiate (impactParticles, transform.position, Quaternion.identity);
		yield return new WaitForSeconds (explodeTime + 1f);
		Destroy (gameObject);
	}

	void OnTriggerEnter(Collider c)
	{
		if(c.CompareTag("Enemy") && Time.time - startTime < explodeTime)
		{
			c.GetComponent<CharacterBase>().DamageReceived( damage * ( 1.2f - explosionRadius.radius / maxExplosionRadius), type);
		}
	}


}
