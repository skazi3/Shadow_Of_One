using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player2Walking : MonoBehaviour {
	private Animator animator;
	private bool canJump;
	public float speed = 10.0F;
	public float rotationSpeed = 100.0F;
	// Use this for initialization
	void Awake(){
		animator = GetComponent<Animator> ();
		canJump = false;
	}
	void Update(){
		float translation = Input.GetAxis("Vertical") * speed;
		float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate(0, 0, translation);
		transform.Rotate(0, rotation, 0);
		//check if player reached first checkpoint
		if (transform.position.z > 57 && transform.position.z < 63) {
			if (transform.position.x > 38 && transform.position.x > 43) {
				canJump = true;
			}
		}

		if (Input.GetKey (KeyCode.W)) {
	
			animator.SetBool ("keyPressed", true);
		} else if (Input.GetKeyUp (KeyCode.W)) {
			animator.SetBool ("keyPressed", false);
		}
		if (Input.GetKey (KeyCode.Space)) {
			if (canJump) {
				Debug.Log ("TRUEEE:");
				animator.SetBool ("jumpPressed", true);
			}
		} else if(Input.GetKeyUp(KeyCode.Space))
		{
			if(canJump)
				animator.SetBool ("jumpPressed", false);
		
		}
	}
}
