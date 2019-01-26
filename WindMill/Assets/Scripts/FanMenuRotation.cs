using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanMenuRotation : MonoBehaviour {
    public int speed = 10;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.back, speed * Time.deltaTime);
    }
}
