using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour
{
    [SerializeField]
    float LevelLoadDelay = 2f;
    [SerializeField]
    float LevelExitSlowMo = 0.2f;

    void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine(LoadNextLevel());
    }

    IEnumerator LoadNextLevel()
    {
        Time.timeScale = LevelExitSlowMo;
        yield return new WaitForSecondsRealtime(LevelLoadDelay);
        Time.timeScale = 1.0f;

        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex; // find active scene so we can advance by one after interaction
        SceneManager.LoadScene(currentSceneIndex + 1); // current scene +1 based on build index
    }
}
