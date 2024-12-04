using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mcqCheck : MonoBehaviour
{
    public GameObject answer;
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public GameObject correctText;
    public GameObject wrongText;
    // Start is called before the first frame update

    public void check()
    {
        bool aVal = a.GetComponent<Toggle>().isOn;
        bool bVal = b.GetComponent<Toggle>().isOn;
        bool cVal = c.GetComponent<Toggle>().isOn;
        bool dVal = d.GetComponent<Toggle>().isOn;
        string ans = answer.GetComponent<TextMesh>().text;

        if (a.name == ans && (!aVal || bVal || cVal || dVal) == false) {
            correctText.SetActive(true);
            wrongText.SetActive(false);
        }
        else if (b.name == ans && (aVal || !bVal || cVal || dVal) == false)
        {
            correctText.SetActive(true);
            wrongText.SetActive(false);
        }
        else if (c.name == ans && (aVal || bVal || !cVal || dVal) == false)
        {
            correctText.SetActive(true);
            wrongText.SetActive(false);
        }
        else if (d.name == ans && (aVal || !bVal || cVal || !dVal) == false)
        {
            correctText.SetActive(true);
            wrongText.SetActive(false);
        }
        else
        {
            wrongText.SetActive(true);
            correctText.SetActive(false);
        }
    }
}
