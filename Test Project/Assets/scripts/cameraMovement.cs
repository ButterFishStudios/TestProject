using UnityEngine;
using System.Collections;

public class cameraMovement : MonoBehaviour {

	public bool shouldMove = true;

	private GameObject player;

	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void Update () {
		if (shouldMove) {
			transform.position = new Vector3 (player.transform.position.x, transform.position.y, transform.position.z);
		}
	}
}
