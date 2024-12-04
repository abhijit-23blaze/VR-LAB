using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addImpulse : MonoBehaviour
{
    public GameObject objectPrefab;

    public float interval = 3.0f;

    private void Start()
    {
        InvokeRepeating("SpawnCube", 0f, interval);
    }

    private void SpawnCube()
    {
        GameObject cube = Instantiate(objectPrefab, transform.position, Quaternion.identity);
        StartCoroutine(AddImpulse(cube));
        
        

    }
    IEnumerator AddImpulse(GameObject cube)
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("FAFsa");
        cube.GetComponent<Rigidbody>().AddForce(-transform.up * 100, ForceMode.Impulse);


    }
}
