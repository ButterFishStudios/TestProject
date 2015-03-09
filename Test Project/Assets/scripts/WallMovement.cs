using UnityEngine;
using System.Collections;



public class WallMovement : MonoBehaviour {
	public bool shouldMove = true;

	void Start () {
	}

	void Update () {
		if(shouldMove)
			transform.Translate (Vector2.right * Time.deltaTime * 2);
	}
}
