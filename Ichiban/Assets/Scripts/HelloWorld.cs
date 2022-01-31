using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update

    public int money; //Variable Declaration, Whole numbers
    public float change = 0.75f; //Floating point numbers. Fractions.
    public bool isDay = true; //Boolean true or false 
    public string fName = "Richard"; //Texts, alphabetical values in quotations
    


    void Start()
    {
        print("Hello World.");
        Debug.Log("Hello " + fName);
        money = 100;
        Debug.Log("Money in account = $" + money);

    }

    // Update is called once per frame
    void Update()
    {
        if (isDay)
        {
            Debug.Log("Daytime.");
        }
        else if(isDay == false)
        {
            Debug.Log("Nighttime.");
        }

        if (change <= 1.00f)
        {
            Debug.Log("Insuffcient Funds.");
        }
        else if(change >= 1.01f)
        {
            Debug.Log("You have unlocked the Shop!");
        }
        if(fName == "Richard")
        {
            Debug.Log("Hello Richard! Welcome.");
        }
        else
        {
            Debug.Log("Intruder Detected.");
        }
    }
}
