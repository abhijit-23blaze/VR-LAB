using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwaner : MonoBehaviour
{
    public GameObject objectPrefab;
    GameObject cube;

    public float interval = 10.0f;
    private void Start()
    {
        Transform transform = GetComponent<Transform>();
        InvokeRepeating("SpawnCube", 0f, interval);
    }

    private void SpawnCube()
    {
        cube = Instantiate(objectPrefab, transform.position, transform.rotation);
    }

    public GameObject getInstantiatedObj()
    {
        return cube;
    }

}
