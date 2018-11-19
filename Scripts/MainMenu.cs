using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        ScoreScript.coinAmount = 0;
        Score2.coinAmount = 0;
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
