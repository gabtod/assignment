using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    public Text winner;
   

    public void LoadNewScene(string sceneName)
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene + 1);
    }

     void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "EndScreen")
        {
            GetTotalScore();
        }
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void GetTotalScore()
    {

        if (LoseBorderRight.Player1TotalScore > LoseBorderLeft.Player2TotalScore)
        {
            winner.text = "The winner is Player1";
        }
        else if (LoseBorderRight.Player1TotalScore < LoseBorderLeft.Player2TotalScore)
        {
            winner.text = "The winner is Player2";
        }
        else
            winner.text = "The scores are equal. There is no winner";
    }
}
