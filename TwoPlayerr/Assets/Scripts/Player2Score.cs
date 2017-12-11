using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Score : MonoBehaviour {

    public Text player2text;
    public int player2score=0;

    // Use this for initialization
    void Start () {

        player2score = 0;
        player2text.text = "Player 2: " + player2score;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

   
}
