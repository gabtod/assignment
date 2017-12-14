using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

    bool gameStarted = false;
    Vector3 initialPos;

    //public Random r = new Random();
    // Use this for initialization
    void Start () {
        initialPos = gameObject.transform.position;
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

            //this.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(ranX[0], ranX[1]), 2f);

            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-10f, 2f);
        }
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
    }

    public void ballreset()
    {
        gameStarted = false;
        
        gameObject.transform.position = initialPos;
        GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0,0);
    }

    
}
