using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.UI;

public class forceSlider5 : MonoBehaviour
{
    public GameObject obj;
    public GameObject springObj;
    public Slider Massslider;

    public TextMeshProUGUI txt;
    public TextMeshProUGUI masstxt;
    public TextMeshProUGUI KETxt;
   /* public Transform startPos;*/
/*
    int previosDisplacement = 0;
    float WD =0;*/

    Rigidbody rb;
    float initialDis;
    float deviation;
    float WD;

    void Start()
    {
        rb = obj.GetComponent<Rigidbody>(); 
        initialDis = (rb.position.y );
    }

    // Update is called once per frame
    void Update()
    {
        // spring const
        txt.text = this.GetComponent<Slider>().value.ToString();
        springObj.GetComponent<SpringJoint>().spring = this.GetComponent<Slider>().value;

        //mass
        rb.mass = Massslider.value;
        masstxt.text = rb.mass.ToString();

        deviation = Mathf.Abs(initialDis -  rb.position.y);

        WD = -((this.GetComponent<Slider>().value) * deviation * deviation)/2;
        WD = (int)WD;
        KETxt.text = WD.ToString(); 
    }

}
