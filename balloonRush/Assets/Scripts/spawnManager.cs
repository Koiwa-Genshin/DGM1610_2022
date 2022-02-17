using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{

    public GameObject[] balloonPrefabs;

    //helps with random spawning of balloons
    public int balloonIndex;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnRandomBalloon()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-5, 5), 10, Random.Range(-2, 2)); //set spawn points at random x and z values while keeping y the same
        int balloonIndex = Random.Range(0, balloonPrefabs.Length); //randomly calls prefabs from the array 
        Instantiate(balloonPrefabs[balloonIndex], spawnPos, balloonPrefabs[balloonIndex].transform.rotation);

    }
}
