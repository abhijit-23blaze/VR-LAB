using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotationController : MonoBehaviour
{
    public GameObject magnet;
    public Slider sliderPosition;
    public GameObject pin;
    float prevValue = 0f;
    public Animator anim;

    void OnSliderValueChanged(float newValue)
    {
        // Calculate the change in slider value
        float deltaValue = newValue - prevValue;

        // Adjust the magnet's position along the z-axis
        Debug.Log(newValue);
        magnet.transform.Rotate(0f,0f,-deltaValue*10, Space.World);
        
        if(deltaValue>-0.1f && newValue<-0.9f){
            anim.SetBool("deflect",true);
            Invoke("SetDeflectFalse", 1f);
        }
        


        // Update the previous slider value
        prevValue = newValue;

        // Log the current slider value
        // Debug.Log("Slider Value: " + magnet.transform.position.z);
        
    }
    void SetDeflectFalse()
    {
        anim.SetBool("deflect", false);
    }

    void Start()
    {
        // Initialize prevValue
        prevValue = sliderPosition.value;

        // Add the listener without invoking the method
        sliderPosition.onValueChanged.AddListener(OnSliderValueChanged);
    }

    void Update()
    {
        // Your update logic here
    }

    public void OnPositionChange()
    {
        // Update the magnet's position based on the slider value
        magnet.transform.position = new Vector3(
            magnet.transform.position.x,
            magnet.transform.position.y,
            magnet.transform.position.z * sliderPosition.value);

        // Log the current slider value
        Debug.Log("Slider Value: " + magnet.transform.position.z);
    }
}
