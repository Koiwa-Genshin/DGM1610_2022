using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public string[] friendNames = { "Dan", "Hamlet", "JJ" , "Lee", "Hans", "Jerry" };

    public int[] numbers = { 12, 13, 14, 15, 18, 19, 20, 23, 28, 30};

    public float[] magicNumbers = { 1.3f, 2.5f, 2.7f, 2.6f, 2.6f, 3.98f };

    public string[] friendLastNames = { "Hyuga", "Rando", "Takenuma", "Umezawa"};

    public int[] bankFile = { 1, 3, 5, 6, 4, 2, 9 };

    public float[] pointAverages = { 23.4f, 33.5f, 45.2f, 12.9f };

    public string[] className = { "Berseker", "Ranger", "Paladin", "Cleric", "Rouge", "Samurai", "Thief"};

    public int[] classLvl = { 23, 50, 39, 43, 12, 14, 10 };

    public float[] classSkillRating = { 10.0f, 4.5f, 2.0f, 10.0f, 9.5f, 5.5f, 8.5f };

    public string[] favoriteFood = { "Burgers", "Tacos", "Ice Cream", "Ramen", "Candy"};
    void Start()
    {
        
        Debug.Log("Former friend " + friendNames[0]);
        Debug.Log(friendNames[5] + " notions towards his growling stomach, frowning.");
        friendNames[0] = "Akali";
        Debug.Log(friendNames[0]);
        
        foreach (int classLvl in classLvl)
        {
            print(classLvl);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
