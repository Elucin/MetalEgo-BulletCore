using UnityEngine;
using System.Collections;

public class HUD_Script : MonoBehaviour {
	public UnityEngine.UI.Text missileAmmo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		missileAmmo.text = "Missile Ammo: " + PlayerControl.missileAmmo.ToString ();
	}
}
