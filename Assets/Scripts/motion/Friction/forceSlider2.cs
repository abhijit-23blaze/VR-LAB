using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.UI;

public class forceSlider2 : MonoBehaviour
{
    public GameObject obj;
    public TextMeshProUGUI txt;
    public TextMeshProUGUI masstxt;
    public ParticleSystem particleSys;

    public float forceVal = 0; //5-50
    public float massVal = 1; //1-10

    void Update()
    {

        obj.GetComponent<Rigidbody>().AddForce(0,0,-forceVal);
        txt.text = forceVal.ToString();

        var em = particleSys.emission;
        em.rateOverTime = forceVal * 10;

        var shp = particleSys.shape;
        shp.radius = (float)(forceVal * 0.03);


        obj.GetComponent<Rigidbody>().mass  = massVal;
        masstxt.text = massVal.ToString(); 
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
