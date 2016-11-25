using UnityEngine;
using System.Collections;

public class FlyingKamikaze : CharacterBase {
	public float yOffset;
	private float startPos;
	Vector3 tempPostion;
	// Use this for initialization
	public override void Start () {
		base.Start ();

	}
	
	// Update is called once per frame
	public override void Update () {
		agent.SetDestination (player.transform.position);
		base.Update ();
	
	}

	protected override void Move()
	{
		base.Move ();
		tempPostion = transform.position;
		tempPostion.y = yOffset * (agent.remainingDistance/20f);
		transform.position = tempPostion;

	}


	//Kamikazes are special and only deal damage once when they collide with the player
	void OnCollisionEnter(Collision c){
		if (c.gameObject.tag == "Player") {
			//Instantiate (Explosion);
			//c.gameObject.GetComponent<Player>().Damage(base.attackPower);
			base.Destruction ();
		}
	}


}
