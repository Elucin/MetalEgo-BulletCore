using UnityEngine;
using System.Collections;

public class LandingZone : MonoBehaviour {

    private Extraction extractionScript;
    public Color ringColor;

    private float maxThreat = 100.0f;
    public float currentThreat = 0;
	public float threatBalance = 10f;

	// Use this for initialization
	void Start () {
        extractionScript = Camera.main.GetComponent<Extraction>();
	}
	
	// Update is called once per frame
	void Update () {
	    if(extractionScript.extracted == false && extractionScript.extracting == true && currentThreat >= maxThreat){
            extractionScript.NewZone();
        }
		if(currentThreat > 0)
			Debug.Log (currentThreat);
	}

    void OnTriggerEnter(Collider c)
    {
        if(c.CompareTag("Player")){
            extractionScript.extracting = true;
            extractionScript.startTimer = Time.time;
			Debug.Log ("Player in");
        }
        else if (c.CompareTag("Enemy")){
			
			currentThreat = currentThreat + ((float)c.gameObject.GetComponent<CharacterBase> ().getScore()/threatBalance);
        }

    }

    void OnTriggerExit(Collider c)
    {
        if(c.CompareTag("Player")){
            extractionScript.extracting = false;
			Debug.Log ("Player out");
        }
        else if(c.CompareTag("Enemy")){
			currentThreat = currentThreat - ((float)c.gameObject.GetComponent<CharacterBase> ().getScore()/threatBalance);
        }
    }

}
