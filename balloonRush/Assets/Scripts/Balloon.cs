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


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
            Destroy(gameObject);
            Debug.Log("Balloon Destroyed!");

        }
    }
}
