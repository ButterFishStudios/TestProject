using UnityEngine;
using System.Collections;

public class playerPhysics : MonoBehaviour {

	public bool onGround = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("w")&&onGround){//jump
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
		}
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.name == "Wall") {
			//GameOver
			Debug.Log ("Game Over");
			Application.LoadLevel(0);
		}
		if (coll.gameObject.name == "Tile") {
			onGround = true;
		}
	
	}

	void OnCollisionExit2D(Collision2D coll){
		if (coll.gameObject.name == "Tile") {
			onGround = false;
		}
	}
}
