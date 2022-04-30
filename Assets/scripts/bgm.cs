using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgm : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("MusicManager"); //look for multiple music managers if there are any 

        if(musicObj.Length > 1) //if there are more than one
        {
            Destroy(this.gameObject); //destroy until it gets to one
        }

        DontDestroyOnLoad(this.gameObject);

    }
}
