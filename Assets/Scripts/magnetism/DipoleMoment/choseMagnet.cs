using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class choseMagnet : MonoBehaviour
{
    public int counter;
    public GameObject[] magnets;
    public Slider magnetSlider;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter = (int)magnetSlider.value;
        magnets[counter].SetActive(true);
        for(int i = 0; i < magnets.Length; i++)
        {
            if(i!= counter)
            {
                magnets[i].SetActive(false);
            }
                
        }
        
    }
}
