using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public GameObject enemyManager;
	public GameObject supplyDrops;
	public GameObject[] landingZones;

	//public Vector3 spawnValues;

	public int waveSize;
	private int currentWaveSize = 0;
	public int difficultLevel = 1
		;

	public float intialWaveDelay = 5f;
	public float spawnWait = 0.5f;
	public float wavePerecentageToRegenerate = 0.25f;


	public int supplyDropDelay = 60;
	private float supplyInterval;
	private bool spawnAllowed = true;


	public bool toggleEnemyRemove = true;
	public int enemyRemovalDelay = 2;
	private float enemyInterval;

	private float startTimer;

	private bool startWaves = false;
	private bool firstWave = true;

	// Use this for initialization
	public void Start () {
		
		//StartCoroutine (SpawnWaves ());

	}
	

	IEnumerator SpawnWaves(){
		
		//yield return new WaitForSeconds (intialWaveDelay);
		Debug.Log("In cooureadnt");
			if((float)currentWaveSize/(float)waveSize <= wavePerecentageToRegenerate)
			{
				for (int i = 0; i < waveSize; i++) {
					//Debug.Log ("Spawn " + waveSize + " enemies");
					enemyManager.GetComponent<EnemySpawning> ().Spawn ();
					//Debug.Log("About to Spawn another one");
					yield return new WaitForSeconds (spawnWait);
				}


			}
			//yield return new WaitForSeconds (waveWait);
		}

	private void setUpSupplyDrop()
	{
		supplyInterval = Time.time + supplyDropDelay;
		spawnAllowed = false;
	}

	// Update is called once per frame
	public void Update () {
		if(startWaves){
			Debug.Log ("Wave Started");
			if (firstWave) {
				enemyInterval = Time.time + enemyRemovalDelay;
				setUpSupplyDrop ();
				startTimer = Time.time;
				setLandingZone ();
				firstWave = false;
			}
		

			if(Time.time - startTimer > intialWaveDelay)
				StartCoroutine( SpawnWaves ());

			Debug.Log("In cooureadnt");
			currentWaveSize = GameObject.FindGameObjectsWithTag ("Enemy").Length;
			if(supplyInterval - Time.time < 0)
			{
				Debug.Log ("Triggering supply drop");
				supplyDrops.GetComponent<AmmoDropSpawn> ().TriggerSpawn();
				setUpSupplyDrop ();
			}
			if(toggleEnemyRemove)
			{
				if (enemyInterval - Time.time < 0) {
					
					ClearEnemies ();
					enemyInterval = Time.time + enemyRemovalDelay;
				}
			}
		}
	}

	private void ClearEnemies()
	{
		Debug.Log("About to clear enemies");
		GameObject[] enemies = GameObject.FindGameObjectsWithTag ("Enemy");
		for (int i = 0; i < enemies.Length; i++) {
			Destroy (enemies[i]);
		}
	}

	private void setLandingZone()
	{
		int indexLZ = Random.Range (0, landingZones.Length);
		for (int i = 0; i < landingZones.Length; i++) {
			if (landingZones [i].GetComponent<LandingZone> ().active == true) {
				indexLZ = i + 3 + Random.Range (0, 2);
				if (indexLZ > 7)
					indexLZ = indexLZ - 8;
				
				landingZones [i].GetComponent<LandingZone> ().active = false;
			}


		}

		landingZones[indexLZ].GetComponent<LandingZone>().active = true;
	}

	public void ChangeActiveLandingZone()
	{
		Debug.Log ("Active Landing Zone Changed");
		setLandingZone ();
	}

	public void SupplyDropPicked()
	{
		spawnAllowed = true;
	}

	public void StartWaves ()
	{
		startWaves = true;
	}

}
