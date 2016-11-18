using UnityEngine;
using System.Collections;

public class ProjectileBase : MonoBehaviour {

    public GameObject impactParticles;
	protected float speed;
	protected float damage;

    public Transform emitter;
	public Rigidbody rigidBody;

    private float startTimer;
    protected float lifetime;
	protected ParticleSystem particleSys;


	// Use this for initialization
	protected virtual void Start () {
		rigidBody = GetComponent<Rigidbody> ();
        startTimer = Time.time;
		lifetime = GetComponent<ParticleSystem>().startLifetime;
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
        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision c){


        //Interact with objects
        //Player
        //Enemy
        //Environment?
        DestroyBullet();
    }
}
