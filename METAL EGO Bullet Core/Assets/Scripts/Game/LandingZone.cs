using UnityEngine;
using System.Collections;

public class LandingZone : MonoBehaviour {

    private Extraction extractionScript;
    private Color ringColor;

    private float maxThreat = 100.0f;
    public float currentThreat;

	// Use this for initialization
	void Start () {
        extractionScript = Camera.main.GetComponent<Extraction>();
	}
	
	// Update is called once per frame
	void Update () {
	    if(extractionScript.extracted == false && extractionScript.extracting == true && currentThreat >= maxThreat){
            extractionScript.NewZone();
        }
	}

    void OnTriggerEnter(Collider c)
    {
        if(c.CompareTag("Player")){
            extractionScript.extracting = true;
            extractionScript.startTimer = Time.time;
        }
        else if (c.CompareTag("Enemy")){
            //Add Threat To Meter
        }

    }

    void OnTriggerExit(Collider c)
    {
        if(c.CompareTag("Player")){
            extractionScript.extracting = false;
        }
        else if(c.CompareTag("Enemy")){
            //Subtract Enemy Threat From Meter
        }
    }

}
