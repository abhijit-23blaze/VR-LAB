using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Change position
/// </summary>
public class ChangeXRPosition : MonoBehaviour
{
  public GameObject myXRRig;
  public Vector3 position;
  public Vector3 rotationEulerAngles;
  public void GoToLocation()
  {
    myXRRig.transform.position = position;
    myXRRig.transform.rotation = Quaternion.Euler(rotationEulerAngles);
  }
}
