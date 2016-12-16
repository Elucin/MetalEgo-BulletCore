using UnityEngine;
using System.Collections;

public class Flying : CharacterBase {

	private Vector3 tempPostion;
	public float verticalSpeed;
	public float amplitude;
	public float yOffset;
	// Use this for initialization
	public override void Start () {
		base.attackDistance = 0;
		base.Start ();
		base.attackDistance = 20;


	}

	protected override void Move()
	{
		if(agent.pathStatus == UnityEngine.AI.NavMeshPathStatus.PathComplete)
		{
			Vector3 tempPos = player.transform.position;
			float xoffset = Random.Range (-30, 30);
			tempPos.x = tempPos.x + (xoffset > 0 && xoffset < 10 ? xoffset + 10 : (xoffset < 0 && xoffset > -10 ? xoffset - 10 : xoffset));
			float zoffset = Random.Range (-30, 30);
			tempPos.z = tempPos.z + (zoffset > 0 && zoffset < 10 ? zoffset + 10 : (zoffset < 0 && zoffset > -10 ? zoffset - 10 : zoffset));
			agent.SetDestination (tempPos);

		}

		base.Move ();
		tempPostion = transform.position;
		tempPostion.y = Mathf.Sin(Time.realtimeSinceStartup * verticalSpeed)*amplitude + yOffset + tempPostion.y;
		transform.position = tempPostion;

	}

	protected override void Attack(){
		

		if (Time.time - base.startTimer >= base.attackDelay) {
			float angle = Vector3.Angle (player.transform.position - transform.position, transform.forward);
			///Debug.Log (angle);
			if ( Mathf.Abs(angle) < 45) {
				//Debug.Log ("Facing player");
			
				base.Shoot ();
				base.startTimer = Time.time;
			}

		}

	}
}
