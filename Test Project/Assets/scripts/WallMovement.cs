using UnityEngine;
using System.Collections;



public class WallMovement : MonoBehaviour {
	public bool shouldMove = true;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(shouldMove)
			transform.Translate (Vector2.right * Time.deltaTime * 2);
	}
}
