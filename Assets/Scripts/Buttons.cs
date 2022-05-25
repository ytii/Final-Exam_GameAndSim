using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void StartLevel()
    {
        SceneManager.LoadScene(1); // 1 being the build index of Level_1
    }

    public void QuitGame()
    {
        Application.Quit(); // Quit
        Debug.Log("<color=red> Quitting </color>"); // Tell us in unity editor that the game is exiting so we don't have to build the game to test
    }
}
