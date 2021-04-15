using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour{

    private GameMaster gm;
    //private GameObject gm;


    void Start() {
        gm = GameObject.Find("Game Master").GetComponent<GameMaster>();
        //gm = GameObject.FindGameObjectsWithTag("GM");
            //.<GameMaster>();
        transform.position = gm.lastCheckPointPos;
        
    }

    void Update(){
        if (Input.GetKeyDown(KeyCode.Space)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
