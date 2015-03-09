using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

	bool onGround = true;
	public float maxSpeed;
	private float height;

	// Use this for initialization
	void Start () {
		height = GetComponent<BoxCollider2D>().bounds.size.y;
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
		if(GetComponent<Rigidbody2D>().velocity.x > maxSpeed){//to the right
			GetComponent<Rigidbody2D>().AddForce(new Vector2(maxSpeed-GetComponent<Rigidbody2D>().velocity.x, 0), ForceMode2D.Impulse);
		}
		if (GetComponent<Rigidbody2D> ().velocity.x < -maxSpeed) {//to the left
			GetComponent<Rigidbody2D>().AddForce(new Vector2(-maxSpeed-GetComponent<Rigidbody2D>().velocity.x, 0), ForceMode2D.Impulse);
		}
	}
	
	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.name == "Wall") {
			//GameOver
			Debug.Log ("Game Over");
			Application.LoadLevel(0);//loads level from begining
		}
		//make sure its an object that we can jump on and that we are over the top of it.
		//it wont jump just if its over the top of it since they need to be touching.
		if ((coll.gameObject.tag == "ground"||coll.gameObject.tag == "obstacle")&&(coll.collider.bounds.center.y+(coll.collider.bounds.size.y/2))<=(transform.position.y-(GetComponent<BoxCollider2D>().bounds.size.y/2))) {
			onGround = true;
		}
	}
	
	void OnCollisionExit2D(Collision2D coll){
		if (coll.gameObject.tag == "ground"||coll.gameObject.tag == "obstacle") {
			onGround = false;
		}
	}
}
