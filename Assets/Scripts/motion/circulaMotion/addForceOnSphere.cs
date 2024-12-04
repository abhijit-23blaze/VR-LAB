using System;
using System.Diagnostics.Contracts;
using UnityEditor;
using UnityEngine;
public class addForceOnSphere : MonoBehaviour
{
    public Transform center;
    Rigidbody rb;
    public float forceAmout = 5f;

    Vector3 surfaceParallel;
    Vector3 surfaceNormal;
    Vector3 contactPoint;
    Vector3 motionDircetion;

    public Transform pos;

    //public LineRenderer lineRenderer;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        //lineRenderer = GetComponent<LineRenderer>();
        //lineRenderer.positionCount = 2;
    }

   

    void OnCollisionStay(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            contactPoint = contact.point;
            surfaceParallel = contactPoint - center.position;
            surfaceNormal = contact.normal;
            //lineRenderer.SetPosition(0, pos.position);
            //lineRenderer.SetPosition(1,contactPoint + Vector3.down*10);
            //lineRenderer.SetPosition(1, contactPoint + surfaceParallel * 10);
            
            //Debug.DrawRay(contact.point, surfaceParallel * 10, Color.red);
            motionDircetion = Vector3.Cross(surfaceNormal, surfaceParallel).normalized;
            //lineRenderer.SetPosition(1, pos.position + motionDircetion *2);
            //Debug.DrawRay(contact.point, motionDircetion * 10, Color.green);
            rb.AddForce(motionDircetion * forceAmout);

        }
    }
}
