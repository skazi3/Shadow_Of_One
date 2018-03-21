using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeController : MonoBehaviour {
	public GameObject player;
	private bool playerIsNear;
	// Use this for initialization
	void Start () {
		playerIsNear = false;
	}
	void moveSpikesUp(){
		if (!playerIsNear) {
			transform.Translate(new Vector3(0, 10, 0));
		}
		playerIsNear = true;
	}
	// Update is called once per frame
	void Update () {
		if (player.transform.position.z >= 800) {
			moveSpikesUp ();
		}
	}
}
