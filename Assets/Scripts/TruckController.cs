using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckController : MonoBehaviour
{
    public int speed;
    public float turnSpeed;
    public float horizontalInput;
    public float forwardInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * (Time.deltaTime * speed*forwardInput));
        //transform.Translate(Vector3.right*(Time.deltaTime * turnSpeed*horizontalInput));
        transform.Rotate(Vector3.up,(Time.deltaTime * turnSpeed*horizontalInput));
    }
}

