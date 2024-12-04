using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.UI;

public class forceSlider3 : MonoBehaviour
{
    public GameObject obj;
    public TextMeshProUGUI txt;
    public TextMeshProUGUI masstxt;
    public TextMeshProUGUI KETxt;
    public ParticleSystem particleSys;

    Rigidbody rb;

    public float forceVal = 0; //5-50
    public float massVal = 1; //1-10
    void Start()
    {
        rb = obj.GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(0, 0, -forceVal);
        txt.text = forceVal.ToString();

        var em = particleSys.emission;
        em.rateOverTime = forceVal * 10;

        var shp = particleSys.shape;
        shp.radius = (float)(forceVal * 0.03);


        rb.mass  = massVal;
        masstxt.text = massVal.ToString(); 

        float spd = rb.velocity.magnitude;
        float KE = (spd * spd * rb.mass)/2 ;
        KE = (int)KE;
        KETxt.text = KE.ToString(); 
    }

    public void forceAdd()
    {
        forceVal++;
    }
    public void forceDeduct()
    {
        forceVal--;
    }
    public void massAdd()
    {
        massVal++;
    }
    public void massDeduct()
    {
        if (massVal > 1) massVal--;
    }
}
