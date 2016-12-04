using UnityEngine;
using System.Collections;

public class LookAtPlayer : MonoBehaviour {

	private GameObject player;

	void Start(){
		player = GameObject.FindWithTag ("Player");
	}

	// Update is called once per frame
	void Update () {
		transform.LookAt(player.transform.position);
	}
}
