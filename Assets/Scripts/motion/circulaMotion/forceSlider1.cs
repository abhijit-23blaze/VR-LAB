using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.UI;

public class forceSlider1 : MonoBehaviour
{
    public GameObject obj;
    public TextMeshProUGUI txt;
    public TextMeshProUGUI masstxt;

    public float forceVal =5; //5-50
    public float massVal = 1; //1-10

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        obj.GetComponent<addForceOnSphere>().forceAmout = forceVal;
        txt.text = forceVal.ToString();

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
        if(massVal>0) massVal--;
    }
}
