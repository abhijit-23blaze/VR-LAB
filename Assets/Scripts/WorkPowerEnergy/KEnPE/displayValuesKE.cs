using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Drawing;

public class displayValuesKE : MonoBehaviour
{
    public TextMeshProUGUI height;
    public TextMeshProUGUI velocity;
    public TextMeshProUGUI pe;
    public TextMeshProUGUI ke;
    public Transform groundTrnasform;

    private MeshRenderer renderer;

    float heightF;
    float velocityF;
    float peF;
    float keF;
    float TeF;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        renderer = GetComponent<MeshRenderer>();
    }
    void Update()
    {
        

        heightF = transform.position.y - groundTrnasform.position.y - .714f;
        velocityF = rb.velocity.y;
        peF = 1 * 10 * heightF;
        keF = (1 * velocityF * velocityF) / 2;
        TeF = peF + keF;

        height.text = heightF.ToString();
        velocity.text = velocityF.ToString();
        pe.text = peF.ToString();
        ke.text = keF.ToString();
    }
}
