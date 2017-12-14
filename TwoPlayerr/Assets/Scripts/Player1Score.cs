using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Score : MonoBehaviour
{

    public Text player1text;
    public int player1score;
    //public static int player1totalscore;
    //public int changescore;
    // Use this for initialization
    void Start()
    {
        player1score = 0;
        player1text.text = "Player 1: " + player1score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void AddScorePlayer1(int player1score)
    //{
    //    player1score+=changescore;
    //    player1totalscore += changescore;
    //    player1text.text = "Player 1: " + player1score;
    //}
}
