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
		base.attackDistance = 0;
		base.Start ();
		base.attackDistance = 20;


	}

	protected override void Move()
	{
		if(agent.pathStatus == NavMeshPathStatus.PathComplete)
		{
			Vector3 tempPos = player.transform.position;
			//Debug.Log (transform.localRotation);
			float xoffset = Random.Range (-30, 30);
			tempPos.x = tempPos.x + (xoffset > 0 && xoffset < 10 ? xoffset + 10 : (xoffset < 0 && xoffset > -10 ? xoffset - 10 : xoffset));
			float zoffset = Random.Range (-30, 30);
			tempPos.z = tempPos.z + (zoffset > 0 && zoffset < 10 ? zoffset + 10 : (zoffset < 0 && zoffset > -10 ? zoffset - 10 : zoffset));
			agent.SetDestination (tempPos);

			/*if (transform.position.x == player.transform.position.x && transform.position.z == player.transform.position.z) {
				Vector3 tempPos = player.transform.position;
				tempPos.x = tempPos.x + Random.Range (-25, 26);
				tempPos.z = tempPos.z + Random.Range (-25, -26);
				agent.SetDestination (tempPos);
			} else if (transform.position.x != player.transform.position.x && transform.position.z != player.transform.position.z) {
				agent.SetDestination (player.transform.position);
			}*/
		}

		base.Move ();
		//Debug.Log (agent.destination);
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
