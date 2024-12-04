using UnityEngine;

public class SetLocation : MonoBehaviour
{
  public Transform objectToMove;

  void Start()
  {
    // Retrieve the location name from PlayerPrefs
    string locationName = PlayerPrefs.GetString("Location");

    // Set the position and rotation based on the locationName
    SetTransformBasedOnLocation(locationName);

    // Clear PlayerPrefs for the next use (optional)
    PlayerPrefs.DeleteKey("Location");
  }

  void SetTransformBasedOnLocation(string locationName)
  {
    // Example: Set different positions and rotations based on the locationName
    switch (locationName)
    {
      case "electricity":
        objectToMove.position = new Vector3(0f, 1f, 0f);
        objectToMove.rotation = Quaternion.Euler(0f, 0f, 0f); // Set rotation in degrees
        break;

      case "magnetic":
        objectToMove.position = new Vector3(0f, 1f, 0f);
        objectToMove.rotation = Quaternion.Euler(0f, 180f, 0f); // Set rotation in degrees
        break;

      default:
        // Handle default case or unknown location
        Debug.LogWarning("Unknown location: " + locationName);
        break;
    }
  }
}
