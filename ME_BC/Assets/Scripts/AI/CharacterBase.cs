using UnityEngine;
using System.Collections;

public class CharacterBase : MonoBehaviour {
	
	public string objectType = "character"; // type of opponent "kamikaze" "tank" "mech" "flying" 
	public float health = 100f; // Amount of health
	public int attackPower = 10; // Player damage dealt
	public int defensePower = 2; // Factor dividing projectiles attack power !!DONT TYPE AS ZERO!!
	public float acceleration = 5f; // Meter per second^2
	public float maxSpeed = 25f; // Meters per second
	public float currentSpeed = 1f; // Meters per second
	public int threat = 1;
	public int attackDistance = 20;
	public float attackDelay = 2.0f;
	//public Vector3 dest;
	protected GameObject player;
	private GameObject bulletPrefab;
	//private float bulletSpeed;
	protected float startTimer;
	public Transform[] emitter;

	enum Score
	{
		FLY = 100,
		KAM = 50,
		TAN = 200,
		MEC = 500,
		GAT = 5,
		MIS = 20,
		FLA = 5,
		MOR = 10
	};

	//public Animator animator;
	//public Rigidbody body;
	protected NavMeshAgent agent;
	// Use this for initialization
	public virtual void Start () {
		player = GameObject.FindWithTag ("Player");
		bulletPrefab = (GameObject) Resources.Load("BulletPrefab", typeof(GameObject));
		//animator = GetComponent<Animator>();
		//body = GetComponent<Rigidbody>();


		agent = GetComponent<NavMeshAgent>();
		agent.stoppingDistance = attackDistance;
		agent.SetDestination (player.transform.position);

	}
	
	// Update is called once per frame
	public virtual void Update () {
		//agent.destination = player.transform.position; 
		//dest = agent.destination;
		Move ();
		//agent.Move (GetVelocity);
		Attack ();
	}

	private float DistanceToPlayer()
	{
		float dist;
		if (player) {
			dist = Vector3.Distance (player.transform.position, transform.position);
			//Debug.Log (dist);
			return dist;

		} else {
			Debug.Log ("Player is null!");
			return 0f;
		}
	}


	protected virtual void Move()
	{
		
		//agent.SetDestination (player.transform.position);
		agent.speed = maxSpeed;
		agent.acceleration = acceleration;

	}

	protected virtual void Attack()
	{
		if(DistanceToPlayer() <= attackDistance){
			//Debug.Log (objectType +" attacking Player");

		}

	}

	protected void Shoot()
	{
		//Transform projectile;

		int emitIndex = 0;
		if (emitter.Length > 1) {
			emitIndex = Random.Range (0, emitter.Length);
		}

		if (DistanceToPlayer () <= attackDistance) {
			
				GameObject bullet = (GameObject)Instantiate (
					                    bulletPrefab,
				emitter[emitIndex].position,
				Quaternion.LookRotation(emitter[emitIndex].position - transform.position)
				                    );
		
			bullet.GetComponent<ProjectileBase> ().damage = attackPower;
			bullet.GetComponent<ProjectileBase> ().emitter = emitter[emitIndex];
			//float bulletSpeed = bullet.GetComponent<ProjectileBase> ().speed = attackPower;
			bullet.GetComponent<Rigidbody> ().velocity = emitter[emitIndex].forward * 10f;
			bullet.GetComponent<ProjectileBase> ().lifetime = 6f;

			//Destroy (bullet, 0.5f);
		}

	}

	protected void Melee()
	{
		if (DistanceToPlayer () <= attackDistance) {

			//Attack animation Tigger
			//player.GetComponent<Player>().Damage(attackPower);
			Debug.Log("Player is being Meleed");

		}
	}

	protected virtual void Destruction()
	{
		Destroy (gameObject);
	}

	public void DamageReceived(float damage, string type)
	{
		health = health - (damage / defensePower);
		if (type == "Gatling")
			PlayerControl.playerScore += Score.GAT;
		else if (type == "Missile")
			PlayerControl.playerScore += Score.MIS;
		else if (type == "Mortar")
			PlayerControl.playerScore += Score.MOR;
		else if (type == "Flak")
			PlayerControl.playerScore += Score.FLA;
		
		if (health <= 0) {
			KillPoints ();
			Destruction ();
		}
	}


	void KillPoints()
	{
		if (name.Contains ("Flying"))
			PlayerControl.playerScore += Score.FLY;
		else if (name.Contains ("Kamikaze"))
			PlayerControl.playerScore += Score.KAM;
		else if (name.Contains ("Tank"))
			PlayerControl.playerScore += Score.TAN;
		else if (name.Contains ("Mech"))
			PlayerControl.playerScore += Score.MEC;
	}

	public int getScore()
	{
		if (name.Contains ("Flying"))
			return (int)Score.FLY;
		else if (name.Contains ("Kamikaze"))
			return (int)Score.KAM;
		else if (name.Contains ("Tank"))
			return (int)Score.TAN;
		else if (name.Contains ("Mech"))
			return (int)Score.MEC;
		else
			return 0;
	}

}
