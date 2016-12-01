using UnityEngine;
using System.Collections;

public class MissileEmit : MonoBehaviour {

	public GameObject missile;

	public void MissileFire(string side)
	{
		GameObject[] enemies = GameObject.FindGameObjectsWithTag ("Enemy");
		foreach (GameObject o in enemies) {
			if (PlayerControl.missileAmmo <= 0)
				return;
			if (side == "left") {
				if (o.GetComponent<MissileLockTest> ().leftMissileLock >= 0.9f) {
					GameObject newMissile = Instantiate (missile, transform.position + new Vector3 (Random.Range (-0.1f, 0.1f), Random.Range (-0.1f, 0.1f), Random.Range (-0.1f, 0.1f)), Quaternion.identity) as GameObject;
					PlayerControl.missileAmmo--;
					newMissile.GetComponent<MissileScript> ().emitter = transform;
					newMissile.GetComponent<MissileScript> ().target = o.transform;
				}
			}
			else{
				if (o.GetComponent<MissileLockTest> ().rightMissileLock >= 0.9f) {
					GameObject newMissile = Instantiate (missile, transform.position + new Vector3 (Random.Range (-0.1f, 0.1f), Random.Range (-0.1f, 0.1f), Random.Range (-0.1f, 0.1f)), Quaternion.identity) as GameObject;
					PlayerControl.missileAmmo--;
					newMissile.GetComponent<MissileScript> ().emitter = transform;
					newMissile.GetComponent<MissileScript> ().target = o.transform;
				}
			}
		}
	}
}
