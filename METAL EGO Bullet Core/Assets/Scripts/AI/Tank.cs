using UnityEngine;
using System.Collections;
//using CharacterBase;

public class Tank : CharacterBase {


	// Use this for initialization
	public override void Start () {
		base.Start ();

	}
	
	// Update is called once per frame
	public override void Update () {
		agent.SetDestination (player.transform.position);
		base.Update ();
		//base.SetNavigationAttributes ();
	}

	protected override void Attack(){
		
		if (Time.time - base.startTimer >= base.attackDelay) {
			base.Shoot ();
			base.startTimer = Time.time;

		}

	}
}
