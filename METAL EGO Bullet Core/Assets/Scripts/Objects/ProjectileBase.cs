using UnityEngine;
using System.Collections;

public class ProjectileBase : MonoBehaviour {

    public GameObject impactParticles;
    public float speed;
    public float damage;

    public Transform emitter;

    private float startTimer;
    private float lifetime;


	// Use this for initialization
	protected void Start () {
        startTimer = Time.time;
		lifetime = GetComponent<ParticleSystem>().startLifetime;
	}
	
	// Update is called once per frame
	protected void Update () {
        Expire();   
	}

    protected void Expire(){
        if(Time.time - startTimer >= lifetime)
        {
            DestroyBullet();
        }
    }

    protected void DestroyBullet(){
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
