using UnityEngine;

/// <summary>
/// Move an object using linear translation
/// </summary>
public class MoveSocket : MonoBehaviour
{
  [Tooltip("The value at which the speed is applied")]
  [Range(0, 1)] public float sensitivity = 1.0f;

  [Tooltip("The max speed of the translation")]
  public float speed = 10.0f;

  private bool isTranslating = false;
  private bool negativeTranslate = false;
  private float currentTranslation = 0f;

  public void SetIsTranslating(bool value)
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
    isTranslating = true;
    negativeTranslate = false;
  }

  public void BeginNegative()
  {
    isTranslating = true;
    negativeTranslate = true;
  }

  public void End()
  {
    isTranslating = false;
  }

  public void ToggleTranslate()
  {
    isTranslating = !isTranslating;
  }

  public void ResetTranslation()
  {
    currentTranslation = 0f;
    transform.localPosition = Vector3.zero;
  }

  public void SetSpeed(float value)
  {
    sensitivity = Mathf.Clamp(value, 0, 1);
    isTranslating = (sensitivity * speed) != 0.0f;
  }

  private void Update()
  {
    if (isTranslating)
    {
      Translate();
    }
  }

  private void Translate()
  {
    float translationAmount = (sensitivity * speed) * Time.deltaTime;

    if (negativeTranslate)
    {
      currentTranslation -= translationAmount;
      transform.Translate(Vector3.down * translationAmount);
      if (currentTranslation <= -50f)
      {
        End();
      }
    }
    else
    {
      currentTranslation += translationAmount;
      transform.Translate(Vector3.up * translationAmount);
      if (transform.position.y >= 0.0003)
      {
        End();
      }
    }
  }
}
