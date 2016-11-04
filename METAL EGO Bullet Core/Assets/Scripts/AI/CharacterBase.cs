using UnityEngine;
using System.Collections;

public class CharacterBase : MonoBehaviour {
	
	public string objectType = "character"; // type of opponent "kamakaza" "tank" "mech" "flying" 
	public float health = 100f; // Amount of health
	public int attackPower = 10; // Player damage dealt
	public int defensePower = 2; // Factor dividing projectiles attack power !!DONT TYPE AS ZERO!!
	public float acceleration = 5f; // Meter per second^2
	public float maxSpeed = 25f; // Meters per second
	public float currentSpeed = 0f; // Meters per second
	public int threat = 1;
	public int attackDistance = 10;

	protected GameObject player;

	public Animator animator;
	public Rigidbody body;

	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag ("Player");
		animator = GetComponent<Animator>();
		body = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
		Move ();
		Attack ();
	}

	private float DistanceToPlayer()
	{
		float dist;
		if (player) {
			dist = Vector3.Distance (player.transform.position, transform.position);
			return dist;

		} else {
			Debug.Log ("Player is null!");
			return null;
		}
	}

	protected void Move()
	{
		currentSpeed = currentSpeed + 1 * acceleration;
		if (currentSpeed >= maxSpeed)
			currentSpeed = maxSpeed;
		float step = currentSpeed * Time.deltaTime;
		Transform target = player.transform;

		transform.position = Vector3.MoveTowards (transform.position, target.position, step);
	}

	protected void Attack()
	{
		if(DistanceToPlayer() <= attackDistance){
			Debug.Log (objectType +" attacking Player");

		}

	}

	protected void Destruction()
	{
		Destroy (gameObject);
	}

	public void DamageReceived(float damage)
	{
		health = health - (damage / defensePower);
		if (health <= 0) {
			Destruction ();
		}
	}


}
