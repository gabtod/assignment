using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

    bool gameStarted = false;
    Vector3 initialPos;
    public float velocityX;
    public float velocityY;

   

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

            //float[] velocityY = new float[] { -10f, 10f };
            //float[] velocityX = new float[] {-10f, 10f};
            //float x = Random.Range(velocityX[0], velocityX[1]);

            //this.GetComponent<Rigidbody2D>().velocity = new Vector2(x, 2f);// Random.Range(velocityY[0], velocityY[1]));

            
           this.GetComponent<Rigidbody2D>().velocity = new Vector2(velocityX, velocityY);
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
