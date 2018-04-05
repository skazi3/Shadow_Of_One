using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkingController : MonoBehaviour {
	private Animator animator;
	// Use this for initialization
	void Awake(){
		animator = GetComponent<Animator> ();

	}
	void Update(){
		if (Input.GetKey (KeyCode.W)) {
			animator.SetBool ("keyPressed", true);
		} 
		else 
			animator.SetBool ("keyPressed", false);
	}
}
