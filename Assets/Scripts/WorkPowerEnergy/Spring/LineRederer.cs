using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRederer : MonoBehaviour
{
    LineRenderer lr;
    public Transform p1;
    public Transform p2;
    public Material mat;
    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        lr.positionCount = 2;
        Vector3[] positions = new Vector3[2] { p1.position,p2.position};
        lr.SetPositions(positions);
        lr.material = mat;
    }
}
