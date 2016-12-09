using UnityEngine;
using System.Collections;

public class StoryManager : MonoBehaviour{

	public static bool isAwake = false; //When true, activate spotlights, enable Gatling Guns
	public static bool ccIsDestroyed = false; //Elevator Up
	public static bool elevUp = false; //Enable Walking, Alternate Weapons
	public static bool ceilingBroke = false; //Enable Jumping
	public static bool isOutside = false; //Start wave spawning logic
	public static bool isExtracted = false; //Start exit sequence

	public Animator tutAnim;
	public GameObject platform;
	private int currentBaseState;

	private int elevDoneState;

	public GameObject commandCenter;

	void Start()
	{
		elevDoneState = Animator.StringToHash ("ElevatorStayUp");
	}

	void Update()
	{
		currentBaseState = tutAnim.GetCurrentAnimatorStateInfo (0).fullPathHash;
		if(!isAwake && (Mathf.Abs(Input.GetAxis("j1_X")) > 0.1f || Mathf.Abs(Input.GetAxis("j1_Y")) > 0.1f || Mathf.Abs(Input.GetAxis("j2_X")) > 0.1f || Mathf.Abs(Input.GetAxis("j2_Y")) > 0.1f))
		{
			GameObject[] lights = GameObject.FindGameObjectsWithTag ("Spotlight");
			isAwake = true;
			foreach (GameObject l in lights) {
				l.GetComponent<Light> ().enabled = true;
			}
		}

		if (commandCenter == null && !ccIsDestroyed) {
			ccIsDestroyed = true;
			tutAnim.enabled = true;
			Debug.Log ("CC Destroyed");
		}

		if (!elevUp && currentBaseState == elevDoneState) {
			Debug.Log ("Elevator Up!");
			elevUp = true;
			//platform.GetComponent<Rigidbody> ().isKinematic = true;
		}



	}
}
