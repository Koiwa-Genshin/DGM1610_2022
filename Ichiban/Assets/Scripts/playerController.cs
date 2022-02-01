using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed = 20.0f;

    public float turnSpeed = 50.0f;

    public float hInput;

    public float vInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        //Player movement, forward in Z axis.
        transform.Translate(Vector3.forward * Time.deltaTime * speed * vInput);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * hInput);
    }
}