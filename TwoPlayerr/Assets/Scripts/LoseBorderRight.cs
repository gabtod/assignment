using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseBorderRight : MonoBehaviour
{

    LevelManager levelManager = new LevelManager();
    public Text player1text;
    public int scorepl1=0;

    void Start()
    {
        DontDestroyOnLoad(this);
        //scorepl1 = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //print("Collision");

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //print("Trigger");
        levelManager.LoadNewScene("Start");
        
        AddScorePlayer1(scorepl1);
       //levelManager.LoadNewScene("Level01");
    }

    public void AddScorePlayer1(int scorepl1)
    {
        scorepl1++;
        player1text.text = "Player 1: " + (scorepl1);
    }
}