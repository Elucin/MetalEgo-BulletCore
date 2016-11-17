using UnityEngine;
using System.Collections;

public class FlyingKamikaze : CharacterBase {
	public float yOffset;
	private float startPos;
	Vector3 tempPostion;
	// Use this for initialization
	public override void Start () {
		base.defensePower = 1;
		base.attackPower = 10;
		base.acceleration = 8;
		base.maxSpeed = 45;
		//startPos = DistanceToPlayer();
		base.Start ();

	}
	
	// Update is called once per frame
	public override void Update () {
		base.Update ();
	
	}

	protected override void Move()
	{
		base.Move ();
		tempPostion = transform.position;
		tempPostion.y = yOffset * (agent.remainingDistance/20f);
		transform.position = tempPostion;

	}
}
