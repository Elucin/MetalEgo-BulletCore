using UnityEngine;
using System.Collections;

public class MissileEmit : MonoBehaviour {

	public GameObject missile;

	void MissileFire(string side)
	{
		
		GameObject[] enemies = GameObject.FindGameObjectsWithTag ("Enemy");
		foreach (GameObject o in enemies) {
			if (side == "left") {
				if (o.GetComponent<MissileLockTest> ().leftMissileLock >= 1f) {
					GameObject newMissile = Instantiate (missile, transform.position + new Vector3 (Random (-0.1f, 0.1f), Random (-0.1f, 0.1f), Random (-0.1f, 0.1f)), Quaternion.identity) as GameObject;

				}
			}
		}
	}
}
