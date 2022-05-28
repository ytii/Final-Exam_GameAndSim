using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit(); // Quit
        Debug.Log("<color=red> Quitting </color>"); // Tell us in unity editor that the game is exiting so we don't have to build the game to test
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName);
    }
}
