using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player2Walking : MonoBehaviour {
	private Animator animator;
	public float speed = 10.0F;
	public float rotationSpeed = 100.0F;
	// Use this for initialization
	void Awake(){
		animator = GetComponent<Animator> ();

	}
	void Update(){
		float translation = Input.GetAxis("Vertical") * speed;
		float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate(0, 0, translation);
		transform.Rotate(0, rotation, 0);
		if (Input.GetKey (KeyCode.W)) {
	
			animator.SetBool ("keyPressed", true);
		} else if (Input.GetKeyUp (KeyCode.W)) {
			animator.SetBool ("keyPressed", false);
		}
		if (Input.GetKey (KeyCode.Space)) {
			Debug.Log ("truueeee");
			animator.SetBool ("jumpPressed", true);
		} else if(Input.GetKeyUp(KeyCode.Space))
		{
			animator.SetBool ("jumpPressed", false);
			Debug.Log ("falseee");
		}
	}
}
