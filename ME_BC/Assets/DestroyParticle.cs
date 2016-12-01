using UnityEngine;
using System.Collections;

public class DestroyParticle : MonoBehaviour {
	ParticleSystem pSys;
	// Update is called once per frame

	void Start(){
		pSys = GetComponent<ParticleSystem> ();
	}

	void Update () {
		if (!pSys.IsAlive ()) {
			Destroy (transform.parent.gameObject);
		}
	}
}
