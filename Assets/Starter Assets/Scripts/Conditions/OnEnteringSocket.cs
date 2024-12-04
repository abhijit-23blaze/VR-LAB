using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

/// <summary>
/// Checks for the object that entered the socket
/// </summary>
public class OnEnteringSocket : MonoBehaviour
{

  public TextMeshProUGUI textMesh = null;
  public Transform needle = null;
  private XRSocketInteractor socket;

  private void Awake()
  {
    socket = GetComponent<XRSocketInteractor>();
  }

  public void SocketCheckForBulbs()
  {
    IXRSelectInteractable interactable = socket.GetOldestInteractableSelected();
    Transform childObject = interactable.transform.Find("Bulb");

    if (childObject != null)
    {
      ChangeMaterial script = childObject.GetComponent<ChangeMaterial>();
      if (script != null)
      {
        script.SetOtherMaterial();
      }
    }

    if (interactable.transform.name == "Nichrome Wire")
    {
      textMesh.text = "1.0A";
    }
    else if (interactable.transform.name == "Torch Bulb")
    {
      textMesh.text = "2.0A";
    }
    else if (interactable.transform.name == "10W Bulb")
    {
      textMesh.text = "0.5A";
    }
  }

  public void SocketCheckForDiffWires()
  {
    IXRSelectInteractable interactable = socket.GetOldestInteractableSelected();

    if (interactable.transform.name == "Wire 1")
    {
      textMesh.text = "1.0A";
    }
    else if (interactable.transform.name == "Wire 2")
    {
      textMesh.text = "0.5A";
    }
    else if (interactable.transform.name == "Wire 3")
    {
      textMesh.text = "2.0A";
    }
    else if (interactable.transform.name == "Wire 4")
    {
      textMesh.text = "3.0A";
    }
  }

  public void SocketCheckForDiffVolts()
  {
    IXRSelectInteractable interactable = socket.GetOldestInteractableSelected();
    TextMeshProUGUI childObject = interactable.transform.GetComponentInChildren<TextMeshProUGUI>();

    if (childObject != null)
    {
      if (interactable.transform.name == "Voltmeter.002")
      {
        childObject.text = "2.0V";
      }
      else
      {
        childObject.text = "6.0V";
      }
    }
  }

  public void SocketCheckForBatteries()
  {
    IXRSelectInteractable interactable = socket.GetOldestInteractableSelected();

    if (needle != null)
    {
      RotateObject script = needle.GetComponent<RotateObject>();
      if (script != null)
      {
        if (interactable.transform.name == "Battery (1)")
        {
          script.Begin();
        }
        else
        {
          script.BeginNegative();
        }
      }
    }
  }
}
