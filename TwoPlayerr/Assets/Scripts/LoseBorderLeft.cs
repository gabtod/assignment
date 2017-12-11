using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseBorderLeft : MonoBehaviour {

    LevelManager levelManager = new LevelManager();
    //Player2Score plr = new Player2Score();
    public Text player2text;
    public int scorepl2=0;
	
	void Start () {
       // DontDestroyOnLoad(this);
        //DontDestroyOnLoad(scorepl2);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //print("Collision");
      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //print("Trigger");
       
       AddScorePlayer2(scorepl2);
       //levelManager.LoadNewScene("Level01");
    }

    public void AddScorePlayer2(int scorepl2)
    {
       scorepl2++;
        player2text.text = "Player 2: " + scorepl2;
    }
}
