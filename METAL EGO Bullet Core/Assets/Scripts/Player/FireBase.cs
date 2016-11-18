using UnityEngine;
using System.Collections;

public class FireBase : MonoBehaviour {
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
