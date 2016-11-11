using UnityEngine;
using System.Collections;
//using CharacterBase;

public class Tank : CharacterBase {


	// Use this for initialization
	public override void Start () {
		base.defensePower = 4;
		base.attackPower = 6;
		base.maxSpeed = 5;
		base.acceleration = 1f;
		base.currentSpeed = 2f;
		base.attackDistance = 20;

		base.Start ();

	}
	
	// Update is called once per frame
	public override void Update () {
		base.Update ();
		//base.SetNavigationAttributes ();
	}

	protected override void Attack(){
		base.Attack ();

	}
}
