using UnityEngine;
using System.Collections;

public class CharacterBase : MonoBehaviour {
	
	public string objectType; // type of opponent "kamakaza" "tank" "mech" "flying" 
	public float health; // Amount of health
	public int attackPower; // Player damage dealt
	public int defensePower; // Factor dividing projectiles attack power !!DONT TYPE AS ZERO!!
	public float acceleration; // Meter per second^2
	public float maxSpeed; // Meters per second
	public float currentSpeed; // Meters per second
	public int threat;

	public GameObject player;

	public Animator animator;
	public Rigidbody body;

	// Use this for initialization
	void Start () {
		objectType = "character";
		health = 100;
		attackPower = 10;
		defensePower = 2;
		acceleration = 5;
		maxSpeed = 25;
		currentSpeed = 0f;
		threat = 1;
		player = GameObject.FindWithTag ("Player");
		animator = GetComponent<Animator>();
		body = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
		Move ();
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
