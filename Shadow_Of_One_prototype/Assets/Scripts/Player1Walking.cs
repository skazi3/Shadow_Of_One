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
		transform.Translate(5 * Input.GetAxis("Horizontal1") * Time.deltaTime, 0f, 5 * Input.GetAxis("Vertical1") * Time.deltaTime);
		if (Input.GetKey (KeyCode.UpArrow)) {
			
			animator2.SetBool ("upArrowPressed", true);
		} else
			animator2.SetBool ("upArrowPressed", false);
	}
}
