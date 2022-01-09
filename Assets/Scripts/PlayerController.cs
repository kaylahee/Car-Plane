using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /*public*/ private float speed = 20.0f;
    /*public*/ private float turnSpeed = 45.0f;
    /*public*/ private float horizontalInput;
    /*public*/ private float forwardInput;
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Move the vehicle forward
        //transform.Translate(0, 0, 1);
        // Move the car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotates the car based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
