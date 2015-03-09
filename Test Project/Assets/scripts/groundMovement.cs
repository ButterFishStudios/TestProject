using UnityEngine;
using System.Collections;

public class groundMovement : MonoBehaviour {

	private GameObject player;

	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void Update () {
		transform.position = new Vector3 (player.transform.position.x, transform.position.y, transform.position.z);
	}
}
