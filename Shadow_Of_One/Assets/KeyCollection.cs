using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollection : MonoBehaviour {
	public GameObject door;

	/**/
	void OnCollisionEnter(Collision collision)
	{
		Destroy (this.gameObject);
		Destroy (door);

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
