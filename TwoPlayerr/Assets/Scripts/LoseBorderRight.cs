using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoseBorderRight : MonoBehaviour
{
    //public LoseBorderLeft lbl;
    public ball ball;
    LevelManager levelManager = new LevelManager();
    public Text player1text;
    //public Text winner;
    public int scorepl1;
    public int max;
    public static int Player1TotalScore;
    public int changescore;

    void Start()
    {
        //max = 10;
    }
    
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //print("Collision");

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ball.ballreset();
        scorepl1 = scorepl1 + changescore;
        Player1TotalScore += changescore;
        print("the score of pl 1 is "+Player1TotalScore);
        player1text.text = "Player 1: " + scorepl1;


        if (max == scorepl1)
        {
            scorepl1 = 0;
            int currentScene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentScene + 1);
        }

    }

    
    
    
}