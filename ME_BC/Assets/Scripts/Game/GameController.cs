using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public GameObject enemyManager;
	public GameObject supplyDrops;

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

	public int enemyRemovalDelay = 2;
	private float enemyInterval;

	private float startTimer;

	// Use this for initialization
	public void Start () {
		enemyInterval = Time.time + enemyRemovalDelay;
		setUpSupplyDrop ();
		startTimer = Time.time;
		StartCoroutine (SpawnWaves ());


	}
	

	IEnumerator SpawnWaves(){
		
		//yield return new WaitForSeconds (intialWaveDelay);
	
			if((float)currentWaveSize/(float)waveSize <= wavePerecentageToRegenerate)
			{
				for (int i = 0; i < waveSize; i++) {
					Debug.Log ("Spawn " + waveSize + " enemies");
					enemyManager.GetComponent<EnemySpawning> ().Spawn ();
					Debug.Log("About to Spawn another one");
					yield return new WaitForSeconds (spawnWait);
				}


			}
			//yield return new WaitForSeconds (waveWait);
		}

	private void setUpSupplyDrop()
	{
		supplyInterval = Time.time + supplyDropDelay;
	}

	// Update is called once per frame
	public void Update () {
		if(Time.time - startTimer > intialWaveDelay)
			StartCoroutine( SpawnWaves ());
		currentWaveSize = GameObject.FindGameObjectsWithTag ("Enemy").Length;
		if(supplyInterval - Time.time < 0)
		{
			Debug.Log ("Triggering supply drop");
			supplyDrops.GetComponent<AmmoDropSpawn> ().TriggerSpawn();
			setUpSupplyDrop ();
		}
		//Debug.Log (currentWaveSize);
		if(enemyInterval- Time.time < 0)
		{
			
			ClearEnemies ();
			enemyInterval = Time.time + enemyRemovalDelay;
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
}
