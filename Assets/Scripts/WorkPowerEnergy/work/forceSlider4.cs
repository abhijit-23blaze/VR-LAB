using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.UI;

public class forceSlider4 : MonoBehaviour
{
    public GameObject obj;
    public TextMeshProUGUI txt;
    public TextMeshProUGUI masstxt;
    public TextMeshProUGUI KETxt;
    public ParticleSystem particleSys;
    public Transform startPos;

    int previosDisplacement = 0;
    float WD =0;

    Rigidbody rb;
    
    void Start()
    {
        rb = obj.GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {

        rb.AddForce(0,0,-this.GetComponent<Slider>().value);
        txt.text = this.GetComponent<Slider>().value.ToString();

        //particle effect
        var em = particleSys.emission;
        em.rateOverTime = this.GetComponent<Slider>().value * 10;
        var shp = particleSys.shape;
        shp.radius = (float)(this.GetComponent<Slider>().value * 0.03);

        int displacement = (int)(startPos.position.z - rb.transform.position.z + 5f); 
        if(previosDisplacement < displacement)
        {
            WD += GetComponent<Slider>().value * (displacement - previosDisplacement);
            previosDisplacement = displacement;
        }
        
        masstxt.text = Mathf.Abs((int)(startPos.position.z - rb.transform.position.z + 5f)).ToString(); 

        float spd = rb.velocity.magnitude;
        //float WD = (spd * spd * rb.mass)/2 ;
        WD = (int)WD;
        KETxt.text = WD.ToString(); 
    }

}
