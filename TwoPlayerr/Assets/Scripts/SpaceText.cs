using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceText : MonoBehaviour {

    public UnityEngine.UI.Text text;
    // Use this for initialization
    
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            text.text = "";
        }
	}
}
