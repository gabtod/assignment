using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoseBorderLeft : MonoBehaviour
{
    public ball ball;
    LevelManager levelManager = new LevelManager();
    public Text player2text;
    public int scorepl2;
    public int max;
    public static int player2totalscore;
    public int changescore;

    //Scene scene = SceneManager.GetActiveScene();

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
        scorepl2 = scorepl2 + changescore;

        player2text.text = "Player 2: " + scorepl2;
        //print(max1);

        if (max == scorepl2)
        {
            scorepl2 = 0;
            levelManager.LoadNewScene("Level2");
        }

    }

}
