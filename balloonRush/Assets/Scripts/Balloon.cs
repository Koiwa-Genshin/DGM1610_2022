using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    //points given for a popped balloon
    public int scoreToGive = 100;

    // how many clicks to destory balloon object 
    public int clickToPop = 3;

    //scale to increase each time the balloon is clicked
    public float scaleToIncrease = 0.10f;

    public scoreManager scoreManager; //variable to reference the scoreManager script

    void Start()
    {
        //references scoreManager script
        scoreManager = GameObject.Find("scoreManager").GetComponent<scoreManager>();
    }

   

    void OnMouseDown()
    {
        //reduces click threshold by one
        clickToPop -= 1;

        //increases balloon size when clicked on 
        transform.localScale += Vector3.one * scaleToIncrease;

        if (clickToPop == 0)
        {
            //Destroys balloons when threshold hits 0 and displays message
            scoreManager.increaseScore(scoreToGive);
            Destroy(gameObject);
            Debug.Log("Balloon Destroyed!");

        }

        if (clickToPop <= 1)
        {

            Debug.Log("Ooof! You missed a Balloon!");
        }
    }
}
