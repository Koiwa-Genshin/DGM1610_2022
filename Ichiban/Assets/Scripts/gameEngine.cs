using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameEngine : MonoBehaviour

{
    public string lightColor;

    public string weather; 


    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if (lightColor == "Red")
        {
            Debug.Log(lightColor + " tide has risen! Run!");
        }
        else if (lightColor == "Yellow")
        {
            Debug.Log(lightColor + " tide has arrived! Be wary.");
        }
        else if (lightColor == "Green")
        {
            Debug.Log(lightColor + " tide has come. All is well.");
        }
        else
        {
            Debug.Log("The true tides have yet to come...");
        }

        if (weather == "Rain" || weather == "Snow")
        {
            Debug.Log("The tides look grim, I would advise you to turn back.");
        }
        else if(weather == "Sunny" || weather == "Cloudy")
        {
            Debug.Log("The tides are looking quite stunning! Carry on!");

        }

    }
}
