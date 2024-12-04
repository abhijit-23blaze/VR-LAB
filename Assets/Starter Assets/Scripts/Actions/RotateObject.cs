using UnityEngine;

/// <summary>
/// Set the rotation of an object
/// </summary>
public class RotateObject : MonoBehaviour
{
  [Tooltip("The value at which the speed is applied")]
  [Range(0, 1)] public float sensitivity = 1.0f;

  [Tooltip("The max speed of the rotation")]
  public float speed = 10.0f;

  private bool isRotating = false;
  private bool negativeRotate = false;
  private float currentRotation = 0f;

  public void SetIsRotating(bool value)
  {
    if (value)
    {
      Begin();
    }
    else
    {
      End();
    }
  }

  public void Begin()
  {
    isRotating = true;
    negativeRotate = false;
  }

  public void BeginNegative()
  {
    isRotating = true;
    negativeRotate = true;
  }

  public void End()
  {
    isRotating = false;
  }

  public void ToggleRotate()
  {
    isRotating = !isRotating;
  }

  public void ResetRotation()
  {
    currentRotation = 0f;
    transform.localRotation = Quaternion.identity;
  }

  public void SetSpeed(float value)
  {
    sensitivity = Mathf.Clamp(value, 0, 1);
    isRotating = (sensitivity * speed) != 0.0f;
  }

  private void Update()
  {
    if (isRotating)
    {
      Rotate();
    }
  }

  private void Rotate()
  {
    float rotationAmount = (sensitivity * speed) * Time.deltaTime;

    if (negativeRotate)
    {
      currentRotation -= rotationAmount;
      transform.Rotate(Vector3.back, rotationAmount);
      if (currentRotation <= -50f)
      {
        End();
      }
    }
    else
    {
      currentRotation += rotationAmount;
      transform.Rotate(Vector3.forward, rotationAmount);
      if (currentRotation >= 70f)
      {
        End();
      }
    }
  }
}
