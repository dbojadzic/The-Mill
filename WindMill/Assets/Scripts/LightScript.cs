using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour {

    // Use this for initialization
    private Light flashlight;
	void Start () {
        flashlight = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.F))        
            flashlight.enabled = !flashlight.enabled;
        
    }
}
