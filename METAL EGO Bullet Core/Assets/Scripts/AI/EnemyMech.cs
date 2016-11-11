using UnityEngine;
using System.Collections;

public class EnemyMech : CharacterBase {

	// Use this for initialization
	public override void Start () {
		base.defensePower = 5;
		base.attackPower = 8;
		base.acceleration = 3;
		base.maxSpeed = 10;
		base.Start ();

	}
	
	// Update is called once per frame
	public override void Update () {
		base.Update ();
	
	}
}
