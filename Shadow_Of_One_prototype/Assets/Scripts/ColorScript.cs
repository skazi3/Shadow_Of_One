using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorScript : MonoBehaviour {
	public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	void OnCollisionEnter(Collision collision){
		if (collision.collider.tag == "Player2") {
			Debug.Log ("Entered");
			transform.GetComponent<Renderer> ().material.color = Color.red;
		}
		else
			transform.GetComponent<Renderer>().material.color = Color.white;
	}
	// Update is called once per frame
	void Update () {
		
	}
}
