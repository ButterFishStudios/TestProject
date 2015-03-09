﻿using UnityEngine;
using System.Collections;

public class groundMovement : MonoBehaviour {

	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (player.transform.position.x, transform.position.y, transform.position.z);
	}
}
