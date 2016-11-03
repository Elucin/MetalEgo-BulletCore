using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {
	
	public string objectType; // type of opponent "kamakaza" "tank" "mech" "flying" 
	public int health; // Amount of health
	public int attackPower; // Player damage dealt
	public int defensePower; // Factor dividing projectiles attack power !!DONT TYPE AS ZERO!!
	public float acceleration; // Meter per second^2
	public float maxSpeed; // Meters per second
	public float currentSpeed; // Meters per second

	public GameObject player = GameObject.FindWithTag ("Player");

	public Animator animator = GetComponent<Animator>();
	public Rigidbody body = GetComponent<Rigidbody>();

	// Use this for initialization
	void Start () {
		objectType = "character";
		health = 100;
		attackPower = 10;
		defensePower = 2;
		acceleration = 5;
		maxSpeed = 25;
		currentSpeed = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
	}

	private void Move()
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
