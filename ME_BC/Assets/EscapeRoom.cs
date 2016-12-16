using UnityEngine;
using System.Collections;

public class EscapeRoom : MonoBehaviour {



	// Use this for initialization
	void OnTriggerExit(Collider c){

		Camera.main.GetComponent<StoryManager>().EscapeRoomVolumeTrigger();
	}
}
