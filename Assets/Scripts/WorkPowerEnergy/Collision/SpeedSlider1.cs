using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SpeedSlider1 : MonoBehaviour
{
    public GameObject sphere;
    public TextMeshProUGUI txt;
    //public GameObject springObj;
    public TextMeshProUGUI masstxt;
    public TextMeshProUGUI KETxt;

    public GameObject spawner;

    public float speedVal = 5; //5-50
    public float massVal = 1; //1-10

    int KE;

    Rigidbody rb;
    void Start()
    {
            rb = sphere.GetComponent<Rigidbody>(); 
    }
    void Update()
    {
        float spd = speedVal;
        sphere.GetComponent<addSpeed>().speed =spd;
        txt.text = speedVal.ToString();

        rb.mass = massVal;
        Debug.Log(massVal);
        masstxt.text = massVal.ToString();

        GameObject temp =  spawner.GetComponent<spwaner>().getInstantiatedObj();
        temp.GetComponent<Rigidbody>().mass = massVal;
        int vel = (int)temp.GetComponent<Rigidbody>().velocity.magnitude;
        KE = (int)rb.mass * (int)(vel* vel) /2;
        KETxt.text = KE.ToString();
    }

    public void forceAdd()
    {
        speedVal++;
    }
    public void forceDeduct()
    {
        speedVal--;
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
