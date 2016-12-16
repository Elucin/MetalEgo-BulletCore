using UnityEngine;
using System.Collections;

[System.Serializable]
public struct radioClip{

	public AudioClip clip;
	public bool played;//= false;
	public bool isMusic;
	public int listNum;


	public radioClip(bool play)
	{
		clip = null;
		isMusic = false;
		played = false;
		listNum = Random.Range(0,1000);
	}

} 
	

public class radioManager : MonoBehaviour {


	public AudioSource audioSrc;
	public System.Collections.Generic.List<radioClip> radioMan;
	public System.Collections.Generic.List<radioClip> playlist;
	public bool isOff = true;
	int indexNum = -1;

	IEnumerator coroutine;
	//public radioClip[] radioMan;

	// Use this for initialization
	void Start () {

		assignRanNum ();
		radioMan.Sort (delegate(radioClip x, radioClip y) {
			if (x.listNum == null && y.listNum == null) return 0;
			else if (x.listNum == null) return -1;
			else if (y.listNum == null) return 1;
			else return x.listNum.CompareTo(y.listNum);
		});

		for (int i = 0; i < radioMan.Count; i++) {

//			radioClip temp = radioMan[i];
//			temp.listNum = Random.Range (0, 1000);//radioMan.Count);
//			radioMan [i] = temp;

			if (i % 2 == 0) {
				
				for (int j = 0; j < radioMan.Count; j++){
					if (radioMan [j].isMusic == true) {
						if (playlist.Count > 0) {

							if (radioMan [j].played == false) {
								radioClip temp2 = radioMan [j];
								temp2.played = true;
								//temp2.listNum = Random.Range (0, 1000);
								radioMan [j] = temp2;
								playlist.Add (radioMan [j]);
								//Debug.Log ("Music ADD");
								break;
							}

						} else {
							radioClip temp2 = radioMan [j];
							temp2.played = true;
							//temp2.listNum = Random.Range (0, 1000);
							radioMan [j] = temp2;
							playlist.Add (radioMan [j]);
							//Debug.Log ("Music ADD");
							break;
						}
					}
				}

			} else {
				
				for (int j = 0; j < radioMan.Count; j++){
					if (radioMan [j].isMusic == false) {
						if (playlist.Count > 0) {
							if (radioMan [j].played == false) {
								radioClip temp2 = radioMan [j];
								temp2.played = true;
								//temp2.listNum = Random.Range (0, 1000);
								radioMan [j] = temp2;
								playlist.Add (radioMan [j]);
								//Debug.Log ("Radio ADD");
								break;
							}
//							
						} else {
							radioClip temp2 = radioMan [j];
							temp2.played = true;
							//temp2.listNum = Random.Range (0, 1000);
							radioMan [j] = temp2;
							playlist.Add (radioMan [j]);
							//Debug.Log ("Radio ADD");
							break;
						}
					}
				}
			}
		
		}
		//if(!isOff)
			//StartCoroutine(playSound());
		coroutine = playSound();
	
	}
	
	// Update is called once per frame //
	void Update () {

		if (isOff)
			audioSrc.mute = true;
		else
			audioSrc.mute = false;

		//turn radio off
		if (Input.GetKeyDown ("k")) {
			if (!isOff) {
				audioSrc.mute = true;
				isOff = true;
			} 
			else {
				audioSrc.mute = false;
				isOff = false;
			}

			if (isOff && !audioSrc.isPlaying) {
				StartCoroutine (coroutine);
				//playSnd ();
				isOff = false;
			}
		}
		//skip ahead
		if (Input.GetKeyDown ("l")) {
			//indexNum += 1;
			StopCoroutine(coroutine);
			StartCoroutine (coroutine);
//			audioSrc.clip = playlist [indexNum].clip;
//			audioSrc.Play ();
		}
//		//skip back
//		if (Input.GetKeyDown ("j")) {
//		
//			indexNum -= 1;
//			StopCoroutine(coroutine);
//			StartCoroutine (coroutine);
//		}
			//playSound ();
			//StartCoroutine (playSound());
			//audioSrc.Play() ;

		//Debug.Log ();

		Debug.Log (coroutine);
		Debug.Log (indexNum);
	}

	void assignRanNum()
	{
		for (int i = 0; i < radioMan.Count; i++) {
			
			radioClip temp = radioMan [i];
			temp.listNum = Random.Range (0, 1000);
			radioMan [i] = temp;
		}
	}

	IEnumerator playSound()
	{
		for (int i = 0; i < playlist.Count; i++) {
			
			indexNum += 1;
		
			audioSrc.clip = playlist [indexNum].clip;
			if (!audioSrc.isPlaying )
				audioSrc.Play ();
			//Debug.Log ("HI");
			//Debug.Log (i);
			
			yield return new WaitForSeconds (audioSrc.clip.length);

//				audioSrc.clip = playlist [i + 1].clip;
//				//audioSrc.Pause ();
//				if (!audioSrc.isPlaying && !isOff)
//					audioSrc.Play ();
			

//			if(Input.GetKeyDown ("j"))
//				audioSrc.clip = playlist[i-1].clip;
//			if(Input.GetKeyDown ("l"))
//				audioSrc.clip = playlist[i+1].clip;
//			if(Input.GetKeyDown("k"))
//				audioSrc.Pause ();
		}
//		audioSrc.clip = engineLoopClip;
//		audioSrc.Play();
	}

	void playSnd()
	{
		for (int i = 0; i < playlist.Count; i++) {

			indexNum = i;
			float timeSince = 0;
			timeSince = Time.time;
			audioSrc.clip = playlist [i].clip;
			if (!audioSrc.isPlaying )
				audioSrc.Play ();
			Debug.Log (i);
			//if (!audioSrc.isPlaying)
			//	break;

			//			if(Input.GetKeyDown ("j"))
			//				audioSrc.clip = playlist[i-1].clip;
			//			if(Input.GetKeyDown ("l"))
			//				audioSrc.clip = playlist[i+1].clip;
			//			if(Input.GetKeyDown("k"))
			//				audioSrc.Pause ();
		}
		//		audioSrc.clip = engineLoopClip;
		//		audioSrc.Play();
	}
}
