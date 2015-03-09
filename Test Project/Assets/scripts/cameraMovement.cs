using UnityEngine;
using System.Collections;

public class cameraMovement : MonoBehaviour {

	public bool shouldMove = true;

	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (shouldMove) {
			transform.position = new Vector3 (player.transform.position.x, transform.position.y, transform.position.z);
		}
	}
}
