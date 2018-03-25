using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class skeletonControls : MonoBehaviour {

    Rigidbody rb;
    Transform t;
    public NetworkStartPosition[] spawnPoints;
    Vector3 pos;
    public Transform player;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        t = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Vector3.Distance(player.position, this.transform.position) < 20)
        {
            Vector3 direction = player.position - this.transform.position;
            direction.y = 0;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);
            if (direction.magnitude > 5)
            {
                this.transform.Translate(0, 0, 0.05f);
            }
        }
    }
}
