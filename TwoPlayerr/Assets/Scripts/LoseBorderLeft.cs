using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseBorderLeft : MonoBehaviour
{

    LevelManager levelManager = new LevelManager();
    public Text player2text;
    public int scorepl2;
    public int max;

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
        
        scorepl2 = scorepl2 + 1;
        player2text.text = "Player 2: " + scorepl2;
        //print(max1);

        if (max == scorepl2)
        {
            levelManager.LoadNewScene("Level02");
        }

    }

}
