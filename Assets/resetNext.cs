using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetNext : MonoBehaviour
{
    bool isPaused = false;

    public void pauseScene()
    {
        isPaused = !isPaused;
    }

    private void Update()
    {
        if (isPaused) { Time.timeScale = 0; }
        else { Time.timeScale = 1; }
    }
    public void ResetScene()
    {
        // Get the current scene index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Reload the current scene
        SceneManager.LoadScene(currentSceneIndex);
    }
    public void NextScene()
    {
        // Get the current scene index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex+1;

        // Reload the current scene
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void PrevScene()
    {
        // Get the current scene index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex - 1;

        // Reload the current scene
        SceneManager.LoadScene(currentSceneIndex);
    }
}
