using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addForceSlant : MonoBehaviour
{
    public float forceAmount = 2f;
    public Transform forceTransform;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddForceAtPosition(new Vector3(0, 0, -forceAmount) , forceTransform.position);
    }
}
