using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gaussLaw : MonoBehaviour
{
    int positives = 0;
    int negetives = 0;

    public float flux = 0;
    public TextMeshProUGUI fluxTxt;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PositiveCharge"))
        {
            positives++;
        }
        if (other.gameObject.CompareTag("NegetiveCharge"))
        {
            negetives++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("PositiveCharge"))
        {
            positives--;
        }
        if (other.gameObject.CompareTag("NegetiveCharge"))
        {
            negetives--;
        }
    }
    void Update()
    {
        float charge = 10;
        float constant = 8.8f;
        flux = (positives - negetives) * charge / constant;
        flux = Mathf.Floor(flux * 100) / 100;
        fluxTxt.text = flux.ToString();
    }

}
