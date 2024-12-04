using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applyForce : MonoBehaviour
{
    public GameObject cube;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "cube5")
        {
            
            cube.GetComponent<Rigidbody>().AddForce(0, 0, -5);
        }
        else if (collision.gameObject.name == "cube10")
        {
            cube.GetComponent<Rigidbody>().AddForce(0, 0, -50);
        }
        else if (collision.gameObject.name == "cube50")
        {
            cube.GetComponent<Rigidbody>().AddForce(0, 0, -500);
        }
    }
}
