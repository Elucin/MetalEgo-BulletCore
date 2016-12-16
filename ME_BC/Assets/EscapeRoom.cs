using UnityEngine;
using System.Collections;

public class EscapeRoom : MonoBehaviour {



	// Use this for initialization
	void OnTriggerExit(Collider c){
		if(c.CompareTag("Player"))
			Camera.main.GetComponent<StoryManager>().EscapeRoomVolumeTrigger();
	}
}
