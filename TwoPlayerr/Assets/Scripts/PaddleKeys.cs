using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleKeys : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
   
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            position.y+=0.1f;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            position.y-=0.1f;
            this.transform.position = position;
        }

        transform.position = new Vector3(
     transform.position.x,
     Mathf.Clamp(transform.position.y, -4.35f,4.35f),
     transform.position.z);

        //newPaddlePos.y = Mathf.Clamp(mousePosInUnits, -4.25f, 4.25f);
    }


   
    

}
