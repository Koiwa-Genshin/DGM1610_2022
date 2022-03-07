using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float moveSpeed = 5f; //speed the player moves at 

    private Rigidbody2D rb; // this helps reference the 2d rigidbody
        
    Vector2 movement; //stores player x,y position for movements

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        movement.x = Input.GetAxis("Horizontal"); //Left and Right inputs for movement
        movement.y = Input.GetAxis("Vertical"); //UP and down inputs for movement

    }

    //Set number of calls per frame

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
    }
}
