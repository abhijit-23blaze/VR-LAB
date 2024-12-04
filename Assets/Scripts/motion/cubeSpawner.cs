using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeSpawner : MonoBehaviour
{
    public GameObject objectPrefab;

    public float interval = 1.0f;

    private void Start()
    {
        InvokeRepeating("SpawnCube", 0f, interval);
    }

    private void SpawnCube()
    {
        GameObject cube =  Instantiate(objectPrefab, transform.position, Quaternion.identity);
        cube.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -10); 
    }
}
