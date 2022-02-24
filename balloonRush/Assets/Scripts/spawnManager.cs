using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    //an array with all the balloon objects we are going to use
    public GameObject[] balloonPrefabs;

    //helps with random spawning of balloons and picks them.
    public int balloonIndex;

    public float startDelay = 0.5f;

    public float spawnInterval = 1.75f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnRandomBalloon", startDelay, spawnInterval); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnRandomBalloon()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-5, 5), 10, 0);
        //set spawn points at random x values while keeping y the same


        int balloonIndex = Random.Range(0, balloonPrefabs.Length); 
        //randomly calls prefabs from the array
        
        
        //spawns random balloons from the array, this will always spawn from a valid spawn positions 
        Instantiate(balloonPrefabs[balloonIndex], spawnPos, balloonPrefabs[balloonIndex].transform.rotation);

    }
}
