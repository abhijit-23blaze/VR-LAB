using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveWithChar : MonoBehaviour
{
    public Vector3 screenPosition = new Vector3(0.5f, 0.5f, 1f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width * screenPosition.x, Screen.height * screenPosition.y, 1));
        transform.position = worldPosition;
        //this.transform.position = transform.parent.position + Camera.main.transform.forward.normalized ;
        //Debug.Log(Camera.main.transform.forward.normalized);

        //Debug.DrawRay(Camera.main.transform.position , Camera.main.transform.forward);


    }
}
