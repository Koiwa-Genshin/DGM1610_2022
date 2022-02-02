using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 4, -13);

    void Update()
    {
        //Matches camera movement with player movement on all axes. 
        transform.position = player.transform.position + offset;
    }

}
