using UnityEngine;
using TMPro;

/// <summary>
/// This script makes it easier to change text of a UI TextMeshPro Element
/// </summary>
public class ChangeText : MonoBehaviour
{
  [Tooltip("The text that has to be placed.")]
  private string newText;
  private int score = 0;

  private TextMeshProUGUI textMesh = null;

  private void Awake()
  {
    textMesh = GetComponent<TextMeshProUGUI>();
  }

  public void SetAmmeter0()
  {
    newText = "0A";
    textMesh.text = newText;
  }
  public void SetAmmeter0Point5()
  {
    newText = "0.5A";
    textMesh.text = newText;
  }
  public void SetAmmeter1()
  {
    newText = "1.0A";
    textMesh.text = newText;
  }
  public void SetAmmeter1Point5()
  {
    newText = "1.5A";
    textMesh.text = newText;
  }
  public void SetAmmeter2()
  {
    newText = "2.0A";
    textMesh.text = newText;
  }
  public void SetAmmeter3()
  {
    newText = "3.0A";
    textMesh.text = newText;
  }
  public void SetAmmeter6()
  {
    newText = "6.0A";
    textMesh.text = newText;
  }
  public void SetAmmeter11()
  {
    newText = "11A";
    textMesh.text = newText;
  }

  public void SetVoltmeter0()
  {
    newText = "0V";
    textMesh.text = newText;
  }
  public void SetVoltmeter1()
  {
    newText = "1.0V";
    textMesh.text = newText;
  }
  public void SetVoltmeter1Point5()
  {
    newText = "1.5V";
    textMesh.text = newText;
  }
  public void SetVoltmeter2()
  {
    newText = "2.0V";
    textMesh.text = newText;
  }
  public void SetVoltmeter3()
  {
    newText = "3.0V";
    textMesh.text = newText;
  }
  public void SetVoltmeter4Point5()
  {
    newText = "4.5V";
    textMesh.text = newText;
  }
  public void SetVoltmeter65()
  {
    newText = "6.0V";
    textMesh.text = newText;
  }

  public void TextGreen()
  {
    textMesh.color = Color.green;
  }

  public void IncrementScore()
  {
    score++;
  }

  public void displayScore()
  {
    textMesh.text = "Score : " + score + " / 20";
  }

}
