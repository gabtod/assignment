using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseBorderRight : MonoBehaviour
{
    public ball ball;
    LevelManager levelManager = new LevelManager();
    public Text player1text;
    public int scorepl1;
    public int max;
    public static int player1totalscore;
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
        
        scorepl1 = scorepl1 + changescore;
        player1text.text = "Player 1: " + scorepl1;
        ball.ballreset();

        if (max == scorepl1)
        {
            scorepl1 = 0;
            levelManager.LoadNewScene("Start");
        }

    }
    
}