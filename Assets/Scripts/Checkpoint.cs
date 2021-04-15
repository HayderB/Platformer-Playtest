using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private GameMaster gm;
    //private GameObject gm;
    //private GameObject gm;
    void Start()
    {
       // gm = GameObject.FindGameObjectsWithTag("GM");
        // gm = GameMaster.instance.lastCheckPointPos;
        //gm = GameObject.Find("Game Master");
        gm = GameObject.Find("Game Master").GetComponent<GameMaster>();
    }

    void onTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gm.lastCheckPointPos = transform.position;
        }
    }
}