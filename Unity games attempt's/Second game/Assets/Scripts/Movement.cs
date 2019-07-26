using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 200f;
    public float sideForce = 1f;


    // Update is called once per frame
    void FixedUpdate()
        {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y<-5f)
        {
            FindObjectOfType<gamemanager>().endgame();
        }
    }
}
