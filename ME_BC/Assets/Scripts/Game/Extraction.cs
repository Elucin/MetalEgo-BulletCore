using UnityEngine;
using System.Collections;

public class Extraction : MonoBehaviour {

    public GameObject gameController;
    public LandingZone currentLandingZone;

    public float startTimer;
    public float extractTime = 60.0f;

    public bool extracting;
    public bool extracted;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if(extracting)
            Countdown();
	}

    void Countdown()
    {
        if (Time.time - startTimer >= extractTime)
            extracted = true;
    }

    public void NewZone()
    {
        extracting = false;
		gameController.GetComponent<GameController> ().ChangeActiveLandingZone();
    }

}
