using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2.0f;

    private float verticalVelocity;
    private float gravity = 14.0f;
    private float jumpForce = 7f;

    private bool onGround;



    public Rigidbody rb;


    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        onGround = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onGround == true)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            onGround = false;
        }

        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            onGround = true;
        }
        else
        {
            onGround = false;
        }
    }
}
