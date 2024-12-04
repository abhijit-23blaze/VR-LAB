using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyerScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("SlidingCube")){
            Destroy(collision.gameObject);
        }
        
    }
}
