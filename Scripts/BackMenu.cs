using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class BackMenu : MonoBehaviour
{
    Text text;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        ScoreScript.coinAmount = 0;
        Score2.coinAmount = 0;
    }
    public void QuitGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        ScoreScript.coinAmount = 0;
        Score2.coinAmount = 0;
    }
}
