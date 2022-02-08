using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleCalc : MonoBehaviour
{
    // Access Modifier DataType Name;
    public int numA = 10;

    public int numB = 15;

    public int numC = 20;

    public float numD = 19f;

    public float numE = 3f;

    // Start is called before the first frame update
    void Start()
    {
        Multi();
        Add();
        Sub();
        Div();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Add()
    {
        int total;

        total = numA + numB;

        Debug.Log(numA + " + " + numB + " = " + total);
    }

    void Sub()
    {
        int total;

        total = numB - numC;

        Debug.Log(numB + " - " + numC + " = " + total);
    }

    void Multi()
    {

        int total;

        total = numA * numB;

        Debug.Log(numA + " x " + numB + " = " + total);
    }

    void Div()
    {
        int total;
        int Rem;
        float tot;

        total = numB / numA;
        Rem = numB % numA;
        tot = numD / numE;

        Debug.Log(numB + " / " + numA + " = " + total +"." + Rem);
        Debug.Log("remainder is:" + Rem);
        Debug.Log(numD + " / " + numE + " = " + tot);
    }
}
