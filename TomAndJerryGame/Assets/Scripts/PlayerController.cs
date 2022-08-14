using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    // making all the variable private
    private float speed = 10;
    private float turnSpeed = 25;
    private float horizontalInput;//for side direction
    private float verticalInput;//for forward and vertical movement
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        // Using unity Input System
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //Moving the Vehicle Forward 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // To move the vehicle left and right
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        // Rotating the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

    }
}

