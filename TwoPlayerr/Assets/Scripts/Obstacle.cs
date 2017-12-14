using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {


     public Vector3 miny = new Vector3(0,4.5f,-5);
     public Vector3 maxy = new Vector3(0, -4.5f, -5);
     public float speed = 0.5f;
    // Use this for initialization

    void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
         transform.position = Vector3.Lerp(miny, maxy, Mathf.PingPong(Time.time*speed, 1.0f));

        //transform.position = new Vector3(transform.position.x, transform.position.y +speed);
    }
}
