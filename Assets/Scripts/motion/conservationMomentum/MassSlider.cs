using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MassSlider : MonoBehaviour
{
    public GameObject sphere;
    public TextMeshProUGUI txt;
    public GameObject plus;
    public GameObject minus;

    public float val = 1;
    
    void Update()
    {

        sphere.GetComponent<addSpeed>().mass = val;
        txt.text =val.ToString();
    }
    public void add()
    {
        val++;
    }

    public void deduct()
    {
        if(val > 0 ) val--;
    }
}
