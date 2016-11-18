using UnityEngine;
using System.Collections;

public class EnemyMech : CharacterBase {

	// Use this for initialization
	public override void Start () {
		base.Start ();

	}
	
	// Update is called once per frame
	public override void Update () {
		agent.SetDestination (player.transform.position);
		base.Update ();
	
	}

	protected override void Attack(){
		//base.Attack ();

		if (Time.time - base.startTimer >= base.attackDelay) {
			base.Melee ();
			base.startTimer = Time.time;

		}

	}
}
