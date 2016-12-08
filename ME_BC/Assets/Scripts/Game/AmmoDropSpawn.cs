using UnityEngine;
using System.Collections;

public class AmmoDropSpawn : MonoBehaviour {

	public float range = 40f;
	public int points = 50;
	public int dropHeight = 50;
	private GameObject ammoPrefab;
	private bool spawnAmmo = false;
	void Start()
	{
		ammoPrefab = (GameObject) Resources.Load("AmmoCrate", typeof(GameObject));
	}

	bool RandomPoint(Vector3 center, float range, out Vector3 result) 
	{
		for (int i = 0; i < points; i++) {
			Vector3 randomPoint = center + Random.insideUnitSphere * range;
			NavMeshHit hit;
			if (NavMesh.SamplePosition(randomPoint, out hit, 1.0f, NavMesh.AllAreas)) {
				result = hit.position;
				return true;
			}
		}
		result = Vector3.zero;
		return false;
	}

	void Update() 
	{
		if (spawnAmmo)
			Spawn ();
	}

	private void Spawn()
	{
		Vector3 point;
		if (RandomPoint(transform.position, range, out point)) {

			point.y = point.y + dropHeight;
			Debug.DrawRay(point, Vector3.up, Color.blue, 1.0f); // use to debug points on map
			GameObject ammo = (GameObject)Instantiate (
				ammoPrefab,
				point,
				Quaternion.identity

			);
			ammo.tag = "SupplyDrop";
		}
		spawnAmmo = false;
	}

	public void TriggerSpawn()
	{
		spawnAmmo = true;
	}

	public void ClearDrops()
	{
		GameObject[] drops = GameObject.FindGameObjectsWithTag ("SupplyDrop");
		for (int i = 0; i < drops.Length-1; i++) {
			Destroy (drops[i]);
		}
	}

}
