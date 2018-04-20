using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollection : MonoBehaviour {

	/**/
	void OnCollisionEnter(Collision collision)
	{
		Destroy (this);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
