using UnityEngine;
using System.Collections;

public class GatlingEmit : MonoBehaviour {
	public GameObject bullet;
	public string controlButton; 
	public float cooldown;
	private bool readyToFire;
	//public string bulletType;
	// Use this for initialization
	void Start () {
		readyToFire = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (((Input.GetButton ("FireRightMissile") || (Input.GetButton ("FireRightMortar")) || Input.GetButton ("FireRightFlak")) && transform.name.Contains ("Right")) || 
			((Input.GetButton ("FireLeftMissile") || (Input.GetButton ("FireLeftMortar")) || Input.GetButton ("FireLeftFlak")) && transform.name.Contains ("Left")))
			return;
		if(Input.GetButton(controlButton) && readyToFire)
		{
			StartCoroutine (Cooldown ());
			GameObject newBullet = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
			newBullet.GetComponent<ProjectileBase> ().emitter = transform;
		}
	}

	IEnumerator Cooldown()
	{
		readyToFire = false;
		yield return new WaitForSeconds (cooldown);
		readyToFire = true;
	}
}
