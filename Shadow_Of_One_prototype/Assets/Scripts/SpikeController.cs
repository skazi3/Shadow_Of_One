using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeController : MonoBehaviour {
	public GameObject player;
	private bool isPlayerNear;
	private bool moveUp;
	// Use this for initialization
	void Start () {
		isPlayerNear = false;
		moveUp = false;
	}
	// Update is called once per frame
	void Update () {
		if (player.transform.position.z >= 800)
		{
			isPlayerNear = true;
		}
		if (isPlayerNear == true)
		{
			startCycle ();
		}
	}
	void startCycle(){
		if (transform.position.y >= 5.5) {
			moveUp = false;
		} else if (transform.position.y <= -10.4)
			moveUp = true;
		if(moveUp)
			transform.Translate(0, 1, 0);
		else
			transform.Translate(0, -1, 0);
	}
	void MoveUp()
	{
		
		if (transform.position.y >= 5.5)
		{

			MoveDown();
		}
		else
			transform.Translate(0, 1, 0);
	}

	void MoveDown()
	{
		
		if (transform.position.y <= -10.4)
		{
			Debug.Log ("In move down if statement,");
			MoveUp();
		}
		else 
			transform.Translate(0, -1, 0);
	}

	void moveSpikesUp()
	{
		if (!isPlayerNear)
		{
			transform.Translate(new Vector3(0, 7, 0));
		}
		isPlayerNear = true;
	}
}