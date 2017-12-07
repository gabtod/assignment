using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

    bool gameStarted = false;

    //public Random r = new Random();
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //if (!gameStarted) // if(gameStarted == false)
       // {
            
        //}

        if (Input.GetKeyDown(KeyCode.Space) && !gameStarted)
        {
            gameStarted = true;

            float[] ranX = new float[] { -10f, 10f };
            
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(ranX[0], ranX[1]), 2f);
        }

        
    }
}
