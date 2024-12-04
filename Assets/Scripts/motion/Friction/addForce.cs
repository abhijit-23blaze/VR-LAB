using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addForce : MonoBehaviour
{
    public float forceAmount = 0f;
    Rigidbody rb;
    void Start()
    {
           rb = GetComponent<Rigidbody>();  
    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, -forceAmount);
    }
}
