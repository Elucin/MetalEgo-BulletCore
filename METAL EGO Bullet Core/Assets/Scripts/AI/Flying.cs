using UnityEngine;
using System.Collections;

public class Flying : CharacterBase {

	private Vector3 tempPostion;
	public float verticalSpeed;
	public float amplitude;
	public float yOffset;
	// Use this for initialization
	public override void Start () {
		base.defensePower = 2;
		base.attackPower = 4;
		base.maxSpeed = 20;
		//tempPostion = transform.position;
		base.Start ();
		base.attackDistance = 20;


	}

	protected override void Move()
	{
		base.Move ();
		tempPostion = transform.position;
		tempPostion.y = Mathf.Sin(Time.realtimeSinceStartup * verticalSpeed)*amplitude + yOffset;
		transform.position = tempPostion;

	}

	protected override void Attack(){
		

		if (Time.time - base.startTimer >= base.attackDelay) {
			base.Shoot ();
			base.startTimer = Time.time;

		}

	}
}
