using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {
	public GameObject player;
	public float xPos1, xPos2;
	public float zPos1, zPos2;
    public GameObject spotLight;
	public GameObject spotLight2;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
		if (player.transform.position.x > xPos1 && player.transform.position.x < xPos2) {
			if(player.transform.position.z > zPos1 && player.transform.position.z < zPos2){
				
				spotLight2.SetActive (true);

				spotLight.SetActive (true);
			}
		} 
	}
}
