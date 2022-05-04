using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endScreen : MonoBehaviour
{
    public float waittime;
    int waitTimer = 0;

    public GameObject txt1;
    public GameObject txt2;
    public GameObject txt3;
    public GameObject txt4;
    public GameObject txt5;
    public GameObject txt6;



    // Update is called once per frame
    void FixedUpdate()
    {
        waitTimer += 1;
        

        if(waitTimer > waittime)
        {

        }


    }
}
