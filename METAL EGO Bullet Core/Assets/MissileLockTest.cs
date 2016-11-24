using UnityEngine;
using System.Collections;

public class MissileLockTest : MonoBehaviour {
	public float leftMissileLock = 0f;
	public float rightMissileLock = 0f;
	int red = 0;
	int blue = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		leftMissileLock = Mathf.Clamp (leftMissileLock, 0, 1);
		rightMissileLock = Mathf.Clamp (rightMissileLock, 0, 1);
		red = 255 * (int)rightMissileLock;
		blue = 255 * (int)leftMissileLock;
		GetComponent<MeshRenderer> ().material.color = new Color32 ((byte)red, 0, (byte)blue, 1);

	}
}
