using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SpeedSlider : MonoBehaviour
{
    public GameObject sphere;
    public TextMeshProUGUI txt;
    public GameObject plus;
    public GameObject minus;

    public float val = 5;
    void Update()
    {
        sphere.GetComponent<addSpeed>().speed = val;
        txt.text = val.ToString();
    }
    public void add()
    {
        val++;
    }

    public void deduct()
    {
        val--;
    }

}
