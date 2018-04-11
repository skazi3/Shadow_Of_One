using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Walking : MonoBehaviour {
	private Animator animator2;
	// Use this for initialization
	void Awake(){
		animator2 = GetComponent<Animator> ();
	}
	void Update(){
		
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate(5 * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 5 * Input.GetAxis("Vertical") * Time.deltaTime);
			animator2.SetBool ("upArrowPressed", true);
		} else
			animator2.SetBool ("upArrowPressed", false);
	}
}
