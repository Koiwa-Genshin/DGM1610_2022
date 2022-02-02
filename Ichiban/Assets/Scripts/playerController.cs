using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
   private float speed = 20.0f;

    private float turnSpeed = 50.0f;

    private float hInput;

    private float vInput;

 
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        //Player movement, forward in Z axis.
        transform.Translate(Vector3.forward * Time.deltaTime * speed * vInput);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * hInput);
    }
}
