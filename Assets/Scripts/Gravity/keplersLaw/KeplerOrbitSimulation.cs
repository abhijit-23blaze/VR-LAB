using System;
//using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class KeplerOrbitSimulation : MonoBehaviour
{
    public Transform body1;
    public Transform body2;

    public float orbitSpeed = 1.0f;
    public float semiMajorAxis = 5.0f;
    public float eccentricity = 0.5f;

    private float time = 0.0f;

    private void Update()
    {
        time += Time.deltaTime * orbitSpeed;
        float angle = time;
        float distance = semiMajorAxis * (1.0f - eccentricity *  Mathf.Cos( angle));
        Debug.Log(Mathf.Cos(angle));
        float x = distance * Mathf.Cos(angle);
        float z = distance * Mathf.Sin(angle);
        UnityEngine.Vector3 orbitalPosition = new UnityEngine.Vector3(x, 0.0f, z);

        body2.position = body1.position + orbitalPosition;
    }
}


