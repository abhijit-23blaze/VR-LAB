using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class changeText : MonoBehaviour
{
    public PhysicMaterial physicMat;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(physicMat.dynamicFriction == 0 )
        {
            this.GetComponent<TMP_Text>().text = "Friction : Off";
        }
        else
        {
            this.GetComponent<TMP_Text>().text = "Friction : On";
        }
        
    }
}
