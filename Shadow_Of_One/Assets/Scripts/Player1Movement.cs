using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour {

    public float moveSpeed;

    private void Start()
    {
        
    }

    private void FixedUpdate()
    {

        //print(Input.GetAxis("Horizontal"));
        transform.Translate(moveSpeed * Input.GetAxis("Horizontal1") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical1") * Time.deltaTime);

    }
}
