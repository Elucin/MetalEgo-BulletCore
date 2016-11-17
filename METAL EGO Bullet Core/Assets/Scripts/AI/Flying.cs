using UnityEngine;
using System.Collections;

public class Flying : CharacterBase {

	// Use this for initialization
	public override void Start () {
		base.defensePower = 2;
		base.attackPower = 4;
		base.maxSpeed = 20;
		base.Start ();

	}
	
	// Update is called once per frame
	public override void Update () {
		base.Update ();
	
	}
}
