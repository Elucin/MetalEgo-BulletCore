using UnityEngine;
using System.Collections;

public class AmmoPickup : MonoBehaviour {
	int missileAmmo;
	int flakAmmo;
	int mortarAmmo;

	// Use this for initialization
	void Start () {
		missileAmmo = Random.Range ((int)(PlayerControl.MAX_MISSILE_AMMO / 5), (int)(PlayerControl.MAX_MISSILE_AMMO / 2));
		flakAmmo = Random.Range ((int)(PlayerControl.MAX_FLAK_AMMO / 5), (int)(PlayerControl.MAX_FLAK_AMMO / 2));
		mortarAmmo = Random.Range ((int)(PlayerControl.MAX_MORTAR_AMMO / 5), (int)(PlayerControl.MAX_MORTAR_AMMO / 2));
	}
	
	void OnTriggerEnter(Collider c)
	{
		
		if (c.CompareTag ("Player")) {
			PlayerControl.missileAmmo += missileAmmo;
			PlayerControl.flakAmmo += flakAmmo;
			PlayerControl.mortarAmmo += mortarAmmo;
			Destroy (gameObject);
		}
	}
}
