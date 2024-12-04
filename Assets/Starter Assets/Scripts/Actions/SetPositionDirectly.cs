using UnityEngine;

public class SetPositionDirectly : MonoBehaviour
{
  private bool setPosition = false;
  private Vector3 targetPosition = new Vector3(0.005303343f, 0.00028f, 0.1911102f); // Adjust the target position as needed

  public void SetPosition()
  {
    setPosition = true;
    transform.position = targetPosition;
  }

  public void ResetPosition()
  {
    setPosition = false;
  }

  private void Update()
  {
    if (setPosition)
    {
      transform.position = targetPosition;
    }
  }
}
