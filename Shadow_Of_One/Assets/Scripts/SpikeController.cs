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
	void moveSpikesUp(){
		if (!isPlayerNear) {
			transform.Translate (new Vector3 (0, 7, 0));
		}
		isPlayerNear = true;
	}
	void OnCollisionEnter(Collision collision){
		Destroy (player);

	}
	// Update is called once per frame
	void Update () {
        if (player.transform.position.z >= 800)
            Activate();

	}

    void Activate()
    {
        if (transform.position.y <= -10.4)
            moveUp = true;
        else if (transform.position.y >= 6)
            moveUp = false;
        if (moveUp)
        {
            transform.Translate(new Vector3(0, 1, 0));
        }
        else if (!moveUp)
        {
            transform.Translate(new Vector3(0, -1, 0));
        }
    }
}
