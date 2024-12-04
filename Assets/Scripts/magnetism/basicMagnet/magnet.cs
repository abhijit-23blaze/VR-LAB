using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magnet : MonoBehaviour
{
    public Transform pos1; 
    //public Transform pos2;
    void Start()
    {
        
    }
    /*private void OnTriggerStay(Collider other)
    {
        
    }*/
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("MetalBall"))
        {
            Vector3 d1 = pos1.position - other.transform.position;
            
            if (Mathf.Abs(d1.magnitude) < 0.4f)
            {
                other.GetComponent<Rigidbody>().AddForce(d1 * 30 / ((d1.magnitude + 1)* (d1.magnitude+1)));
                other.GetComponent<Rigidbody>().velocity = Vector3.zero;
                other.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            }
            else
            {
                other.GetComponent<Rigidbody>().AddForce(d1 * 50 / (d1.magnitude * d1.magnitude * d1.magnitude));
            }

        }
        if (other.gameObject.CompareTag("diaMagnetic"))
        {
            Vector3 d1 = pos1.position - other.transform.position;
            if (Mathf.Abs(d1.magnitude) < 0.4f)
            {

                other.GetComponent<Rigidbody>().AddForce( - d1 * 30 / ((d1.magnitude + 1)* (d1.magnitude+1)));
                Debug.Log("yes");
                other.GetComponent<Rigidbody>().velocity = Vector3.zero;
                other.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            }
            else
            {
                other.GetComponent<Rigidbody>().AddForce( - d1 * 50 / (d1.magnitude * d1.magnitude));
            }

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
