using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addSpeed : MonoBehaviour
{
    public float speed = 5f;
    public float mass = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 relativeVelocity = Quaternion.Inverse(transform.rotation) * new Vector3(0,0,-speed);
        rb.velocity = relativeVelocity;
        rb.mass = mass;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject, 2f);
        }
           
    }
}
