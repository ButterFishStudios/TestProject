using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

	bool onGround = true;
	public float maxSpeed = 200f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("w")&&onGround){//jump
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
		}
		if (Input.GetKey ("w") && !onGround) {//long jump
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 0.05f), ForceMode2D.Impulse);
		}
		if(Input.GetKey ("a")){
			GetComponent<Rigidbody2D>().AddForce(new Vector2(-0.2f, 0), ForceMode2D.Impulse);
		}
		if(Input.GetKey ("d")){
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0.2f, 0), ForceMode2D.Impulse);
		}

		//make sure the player isn't going too fast
		/*if(GetComponent<Rigidbody2D>().velocity.magnitude > maxSpeed)
		{
			GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().velocity.normalized * maxSpeed;
		}*/
	}
	
	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.name == "Wall") {
			//GameOver
			Debug.Log ("Game Over");
			Application.LoadLevel(0);
		}
		if (coll.gameObject.tag == "ground"||coll.gameObject.tag == "obstacle") {
			onGround = true;
			Debug.Log ("jump enabled");
		}
		
	}
	
	void OnCollisionExit2D(Collision2D coll){
		if (coll.gameObject.tag == "ground"||coll.gameObject.tag == "obstacle") {
			onGround = false;
		}
	}
}
