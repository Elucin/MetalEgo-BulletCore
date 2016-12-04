using UnityEngine;
using System.Collections;

public class HUD_Script : MonoBehaviour {
	public UnityEngine.UI.Text missileAmmo;
	public UnityEngine.UI.Text mortarAmmo;
	public UnityEngine.UI.Text flakAmmo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		missileAmmo.text = "Missile Ammo: " + PlayerControl.missileAmmo.ToString ();
		mortarAmmo.text = "Mortar Ammo: " + PlayerControl.mortarAmmo.ToString ();
		flakAmmo.text = "Flak Ammo: " + PlayerControl.flakAmmo.ToString ();
	}
}
