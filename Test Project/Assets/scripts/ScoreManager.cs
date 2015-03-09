using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {

	private GameObject camera;
	private GameObject player;
	private Camera mainCamera;
	private float startPlayerPosition;
	private TextMesh mesh;
	private int score = 0;

	void Start () {
		camera = GameObject.FindGameObjectWithTag ("MainCamera");
		mainCamera = camera.GetComponent<Camera> ();
		mesh = GetComponent<TextMesh> ();
		player = GameObject.FindGameObjectWithTag ("Player");
		startPlayerPosition = player.transform.position.x;
	}

	void Update () {
		//puts the score on the top right side of the screen. If it moves the x based on the camera x, then it will lag behind
		transform.position = new Vector3 (player.transform.position.x+(Mathf.Abs(mainCamera.transform.position.z)/3.0f), transform.position.y, transform.position.z);
		score = (int)(player.transform.position.x - startPlayerPosition)*25;
		mesh.text = "Score: "+score;
	}
}
