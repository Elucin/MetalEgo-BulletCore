using UnityEngine;
using System.Collections;

public class LandingZone : MonoBehaviour {

    private Extraction extractionScript;
    public Color ringColor;

    private float maxThreat = 100.0f;
    public float currentThreat = 0;
	public float threatBalance = 10f;

	public bool active = true;

	// Use this for initialization
	void Start () {
		
        extractionScript = Camera.main.GetComponent<Extraction>();
		Debug.Log ( Camera.main);
		Debug.Log ( extractionScript.extractTime);
	}
	
	// Update is called once per frame
	void Update () {
		if (active) {
			this.GetComponent<ParticleSystem> ().Play();
		} else {
			this.GetComponent<ParticleSystem> ().Stop();
		}
		if(extractionScript.extracted == false && extractionScript.extracting == true && currentThreat >= maxThreat && active == true){
            extractionScript.NewZone();
        }

	}

    void OnTriggerEnter(Collider c)
    {
		if (active) {
			if (c.CompareTag ("Player")) {
				extractionScript.extracting = true;
				extractionScript.startTimer = Time.time;
				Debug.Log ("Player in");
			} else if (c.CompareTag ("Enemy")) {
				Debug.Log (c.gameObject.name + " in");
				currentThreat = currentThreat + ((float)c.gameObject.GetComponent<CharacterBase> ().getScore () / threatBalance);
			}
		}

    }

    void OnTriggerExit(Collider c)
    {
		if (active) {
			if (c.CompareTag ("Player")) {
				extractionScript.extracting = false;
				Debug.Log ("Player out");
			} else if (c.CompareTag ("Enemy")) {
				Debug.Log (c.gameObject.name + " out");
				currentThreat = currentThreat - ((float)c.gameObject.GetComponent<CharacterBase> ().getScore () / threatBalance);
			}
		}
    }

}
