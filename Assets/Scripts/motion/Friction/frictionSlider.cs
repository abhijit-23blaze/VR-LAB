using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class frictionSlider : MonoBehaviour
{
    public GameObject obj;
    PhysicMaterial mat;
    public TextMeshProUGUI txt;
    public TextMeshProUGUI dftxt;

    public float statF = 0.5f; //0-1
    public float dyncF = 0.5f; //0 -1
    void Start()
    {
        mat = obj.GetComponent<Collider>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
        mat.staticFriction = statF;
        txt.text = statF.ToString();

        mat.dynamicFriction = dyncF;
        dftxt.text = dyncF.ToString();

    }

    public void staticAdd()
    {
        if (statF < 0.99) statF += 0.1f;
        else statF = 1;
    }
    public void staticDeduct()
    {
        if (statF > 0.01) statF -=0.1f;
        else statF = 0;
    }
    public void dyncAdd()
    {
        if (dyncF < 0.99)  dyncF +=0.1f;
        else dyncF = 1;
    }
    public void dyncDeduct()
    {
        if (dyncF > 0.01) dyncF -= 0.1f;
        else dyncF = 0;
    }
}
