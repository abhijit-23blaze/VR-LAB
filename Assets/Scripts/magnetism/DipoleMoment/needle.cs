using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class needle : MonoBehaviour
{
    public Slider magnetSlider;
    //public Vector3 direction = new Vector3(90f,90f,0);
    void Update()
    {
        int currVal = (int)magnetSlider.value;
        if (currVal == 0 && (transform.eulerAngles.y < (269f) || transform.eulerAngles.y > (271f)))
        {
            Debug.Log(transform.eulerAngles.y);
            Vector3 direction = new Vector3(90f, 90f, 0);

            Quaternion targetRotation = Quaternion.Euler(direction);
            this.transform.rotation = Quaternion.Lerp(this.transform.rotation, targetRotation, Time.deltaTime * 1);
        }
        if (currVal == 1 && (transform.eulerAngles.y < (89f) || transform.eulerAngles.y > (91f)))
        {
            Vector3 direction = new Vector3(90f,-90f,0);

            Quaternion targetRotation = Quaternion.Euler(direction);
            this.transform.rotation = Quaternion.Lerp(this.transform.rotation, targetRotation, Time.deltaTime * 1);
        }
        if (currVal == 2 && (transform.eulerAngles.y < (269f) || transform.eulerAngles.y > (271f)))
        {
            Debug.Log(transform.eulerAngles.y);
            Vector3 direction = new Vector3(90f, 90f, 0);

            Quaternion targetRotation = Quaternion.Euler(direction);
            this.transform.rotation = Quaternion.Lerp(this.transform.rotation, targetRotation, Time.deltaTime * 1);
        }
        if (currVal == 3 && (transform.eulerAngles.y < (89f) || transform.eulerAngles.y > (91f)))
        {
            Vector3 direction = new Vector3(90f, -90f, 0);

            Quaternion targetRotation = Quaternion.Euler(direction);
            this.transform.rotation = Quaternion.Lerp(this.transform.rotation, targetRotation, Time.deltaTime * 1);
        }

        if (currVal == 4 && (transform.eulerAngles.y < (359f) && transform.eulerAngles.y > (1f)))
        {
            Vector3 direction = new Vector3(90f, 180f, 0);

            Quaternion targetRotation = Quaternion.Euler(direction);
            this.transform.rotation = Quaternion.Lerp(this.transform.rotation, targetRotation, Time.deltaTime * 1);
        }

        if (currVal == 5 && (transform.eulerAngles.y < (179f) || transform.eulerAngles.y > (181f)))
        {
            Vector3 direction = new Vector3(90f, 0, 0);

            Quaternion targetRotation = Quaternion.Euler(direction);
            this.transform.rotation = Quaternion.Lerp(this.transform.rotation, targetRotation, Time.deltaTime * 1);
        }
        Debug.Log(transform.eulerAngles.y);
    }
}
