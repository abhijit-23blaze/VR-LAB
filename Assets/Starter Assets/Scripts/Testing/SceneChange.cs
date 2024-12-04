using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{

  private string chapter1Location = "electricity";
  private string chapter2Location = "magnetic";

  private void LoadMainScene(string locationName)
  {
    PlayerPrefs.SetString("Location", locationName); // Save the location name in PlayerPrefs

    SceneManager.LoadScene("Main Scene");
  }

  public void OnChapter1Click()
  {
    LoadMainScene(chapter1Location);
  }

  public void OnChapter2Click()
  {
    LoadMainScene(chapter2Location);
  }

  public void OnMagnetismClick()
  {
    SceneManager.LoadScene("barMagnet");
  }

    public void OnEMIClick()
    {
        SceneManager.LoadScene("EMI_1");
    }
}
