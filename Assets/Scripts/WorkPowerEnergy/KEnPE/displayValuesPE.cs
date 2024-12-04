using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Drawing;
using UnityEngine.UI;
using System;

public class displayValuesPE : MonoBehaviour
{
    public TextMeshProUGUI height; 
    public TextMeshProUGUI pe; 
    public Transform groundTrnasform;
    public Slider massSlider;
    public TextMeshProUGUI massTxt;

    private MeshRenderer renderer;

    float heightF;
    float peF;  
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        renderer = GetComponent<MeshRenderer>();
    }
    void Update()
    {
        rb.mass = massSlider.value * 10;
        massTxt.text  =rb.mass.ToString();

        heightF = transform.position.y - groundTrnasform.position.y - 1f; 
        peF = rb.mass * 10 * heightF; 

        height.text = heightF.ToString();
        peF = (int)peF;
        Debug.Log(peF);
        pe.text = peF.ToString(); 
    }
}
