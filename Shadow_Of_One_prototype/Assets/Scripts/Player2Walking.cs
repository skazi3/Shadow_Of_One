using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Walking : MonoBehaviour {
	private Animator animator;
	// Use this for initialization
	void Awake(){
		animator = GetComponent<Animator> ();

	}
	void Update(){
		transform.Translate(5 * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 5 * Input.GetAxis("Vertical") * Time.deltaTime);
		if (Input.GetKey (KeyCode.W)) {
			animator.SetBool ("keyPressed", true);
		} else
			animator.SetBool ("keyPressed", false);
		if (Input.GetKeyDown (KeyCode.Space)) {
			animator.SetBool ("jumpPressed", true);

		} 
		else if(Input.GetKeyUp(KeyCode.Space))
			animator.SetBool ("jumpPressed", false);
	}
}
