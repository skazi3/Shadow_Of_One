using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeController : MonoBehaviour {
	public GameObject player;
	private bool playerIsNear;
	private bool moveUp;
	// Use this for initialization
	void Start () {
		playerIsNear = false;
		moveUp = false;
	}
	void moveSpikesUp(){
	}		
	// Update is called once per frame
	void Update () {
		if (transform.position.y <= -14)
			moveUp = true;
		else if(transform.position.y >= 12)
			moveUp = false;
			
		if (moveUp) {
			transform.Translate (new Vector3 (0, 1, 0));
		} else if (!moveUp) {
			transform.Translate (new Vector3 (0, -1, 0));
		}

	}
}
