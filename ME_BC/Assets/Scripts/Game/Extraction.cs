using UnityEngine;
using System.Collections;

public class Extraction : MonoBehaviour {

    public GameObject gameController;
    public LandingZone currentLandingZone;

    public float startTimer = 0f;
    public float extractTime = 30.0f;

    public bool extracting = false;
    public bool extracted = false;

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

		//if((Time.time - startTimer)%10 <= 1)
			//Debug.Log(Time.time - startTimer + " til: " + extractTime);
		
		if (Time.time - startTimer >= extractTime) {
			extracted = true;
			Debug.Log ("Extracted");
		}
    }

    public void NewZone()
    {
        extracting = false;
		gameController.GetComponent<GameController> ().ChangeActiveLandingZone();
    }

}
