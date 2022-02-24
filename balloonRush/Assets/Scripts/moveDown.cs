using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveDown : MonoBehaviour
{

    public float moveSpeed = 1f;

    //sets penalty bound for missed balloons and destorys them
    public float lowerBound = -10f;

    public scoreManager scoreManager;

    private Balloon balloon;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("scoreManager").GetComponent<scoreManager>();
        balloon = GetComponent<Balloon>();
    }

    // Update is called once per frame
    void Update()
    {
        //constantly dragging down game object in the y axis 
        transform.Translate(0, -moveSpeed * Time.deltaTime, 0);

        //if balloon goes below y value, it is destroyed 
        if(transform.position.y < lowerBound)
        {
            scoreManager.decreaseScore(balloon.scoreToGive);
            Destroy(gameObject);
        }

    }
}
