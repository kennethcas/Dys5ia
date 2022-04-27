using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class roomTimer : MonoBehaviour
{

    public float roomClock; //length of time before room finishes
    public string roomName; //next room to be transitioned into
    

    void Update()
    {
        roomClock -= Time.deltaTime; //countdown

        if(roomClock <= 0) //if countdown over, go to next room
        {
            SceneManager.LoadScene(roomName);
        }

    }
}
