using UnityEngine;
using System.Collections;

public class Kamikaze : CharacterBase {

	// Use this for initialization
	public override void Start () {
		base.defensePower = 1;
		base.attackPower = 10;
		base.acceleration = 8;
		base.maxSpeed = 45;
		base.Start ();

	}
	
	// Update is called once per frame
	public override void Update () {
		base.Update ();
	
	}
}
