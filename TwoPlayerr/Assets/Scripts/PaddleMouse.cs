using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMouse : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

       

        float mousePosInUnits = (Input.mousePosition.y/ Screen.width * 16) -6;
        

        Vector3 newPaddlePos = new Vector3(gameObject.transform.position.x, mousePosInUnits,
                                            gameObject.transform.position.z);

        


        newPaddlePos.y = Mathf.Clamp(mousePosInUnits, -4.35f, 4.35f);

        gameObject.transform.position = newPaddlePos;
        // setting our object's position (the paddle) to the new calculated position

    }
}
