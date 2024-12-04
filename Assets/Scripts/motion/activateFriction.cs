using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class activateFriction : MonoBehaviour
{
    public PhysicMaterial frictionMat;
    public Material enableMaterial;
    public Material disableMaterial;
    public void OnOffFriction()
    {
        if(frictionMat.dynamicFriction == 0)
        {
            frictionMat.dynamicFriction = 0.6f;
            this.GetComponent<Renderer>().material = enableMaterial;
        }
        else
        {
            frictionMat.dynamicFriction = 0;
            this.GetComponent<Renderer>().material = disableMaterial;
        }
    }
}
