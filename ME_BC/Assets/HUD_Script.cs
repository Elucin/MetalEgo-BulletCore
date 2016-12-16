using UnityEngine;
using System.Collections;

public class HUD_Script : MonoBehaviour {
	public UnityEngine.UI.Text missileAmmo;
	public UnityEngine.UI.Text mortarAmmo;
	public UnityEngine.UI.Text flakAmmo;
	public UnityEngine.UI.Text Score;
	public UnityEngine.UI.Text Timer;
	//public UnityEngine.UI.Image Threat;
	public Extraction ex;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (ex.extracting)
			Timer.text = string.Format ("{02:N}", ex.extractTime - (Time.time - ex.startTimer));
		else
			Timer.text = "0000:0000";
		missileAmmo.text = "Missile Ammo: " + PlayerControl.missileAmmo.ToString ();
		mortarAmmo.text = "Mortar Ammo: " + PlayerControl.mortarAmmo.ToString ();
		flakAmmo.text = "Flak Ammo: " + PlayerControl.flakAmmo.ToString ();
		Score.text = "Score: " + PlayerControl.playerScore.ToString ();
	}
}
