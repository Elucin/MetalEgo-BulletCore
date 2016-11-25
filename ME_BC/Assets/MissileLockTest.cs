﻿using UnityEngine;
using System.Collections;

public class MissileLockTest : MonoBehaviour {
	public float leftMissileLock;
	public float rightMissileLock;
	public UnityEngine.UI.Image lockCircle;
	int red;
	int blue;
	// Use this for initialization
	void Start () {
		leftMissileLock = 0f;
		rightMissileLock = 0f;

	}
	
	// Update is called once per frame
	void Update () {
		leftMissileLock = Mathf.Clamp (leftMissileLock, 0f, 1f);
		rightMissileLock = Mathf.Clamp (rightMissileLock, 0f, 1f);

		if (!Input.GetButton ("FireRightMissile"))
			rightMissileLock = 0;
		if (!Input.GetButton ("FireLeftMissile"))
			leftMissileLock = 0;

		lockCircle.color = new Color (rightMissileLock, 1f - (rightMissileLock + leftMissileLock), leftMissileLock);
		lockCircle.fillAmount = rightMissileLock >= leftMissileLock ? rightMissileLock : leftMissileLock; 
	}
}