﻿using UnityEngine;
using System.Collections;

public class EnemySpawning : MonoBehaviour {

	public GameObject player;
	public GameObject[] enemy;
	public float spawnTime = 3f;
	//public Transform[] spawnPoints;
	//private bool triggerSpawn = true;


	// Use this for initialization
	//void Start () {
	//	InvokeRepeating ("Spawn", spawnTime, spawnTime);
	//}
	


	bool RandomPoint(Vector3 center, float range, out Vector3 result) 
	{
		for (int i = 0; i < 30; i++) {
			Vector3 randomPoint = center + Random.onUnitSphere * range;
			UnityEngine.AI.NavMeshHit hit;
			if (UnityEngine.AI.NavMesh.SamplePosition(randomPoint, out hit, 1.0f, UnityEngine.AI.NavMesh.AllAreas)) {
				result = hit.position;
				return true;
			}
		}
		result = Vector3.zero;
		return false;
	}

	/*void Update() 
	{
		if (triggerSpawn)
			Spawn ();
	}*/

	public void Spawn()
	{
		Vector3 point = new Vector3(0,0,0);
		if (RandomPoint(player.transform.position, 2000, out point)) {

			int spawnEnemyIndex = Random.Range (0, enemy.Length);
			//Debug.DrawRay(point, Vector3.up, Color.blue, 1.0f);
			/*GameObject ammo = (GameObject)*/
			Instantiate (
				enemy[spawnEnemyIndex],
				point,
				Quaternion.identity

			);
		}
		//triggerSpawn = false;
	}
}
