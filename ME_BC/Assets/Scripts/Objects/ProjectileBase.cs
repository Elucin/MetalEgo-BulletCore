using UnityEngine;
using System.Collections;

public class ProjectileBase : MonoBehaviour {

    public GameObject impactParticles;
	public float speed;
	public float damage;

    public Transform emitter;
	public Rigidbody rigidBody;

    private float startTimer;
    public float lifetime;
	protected ParticleSystem particleSys;


	// Use this for initialization
	protected virtual void Start () {
		rigidBody = GetComponent<Rigidbody> ();
        startTimer = Time.time;
		//lifetime = GetComponent<ParticleSystem>().startLifetime;
		particleSys = GetComponent<ParticleSystem> ();
	}
	
	// Update is called once per frame
	protected virtual void Update () {
        Expire();   
	}

    void Expire(){
        if(Time.time - startTimer >= lifetime)
        {
            DestroyBullet();
        }
    }

    void DestroyBullet(){
		if(impactParticles != null)
			Instantiate (impactParticles, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision c){

		Debug.Log ("Collided " + c.transform.name);
		if (emitter != null) {
			if (emitter.transform.root == c.transform)
				return;
		}
		if (c.transform.tag == "Projectile")
			return;
		if (c.transform.tag == "Enemy")
			c.transform.GetComponent<CharacterBase> ().DamageReceived (damage);
		DestroyBullet ();

    }
}
