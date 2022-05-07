using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textfadein : MonoBehaviour
{
    public float waitTime;
    public Animator fadeIn;
    float countdown;


    // Update is called once per frame
    void Update()
    {
        countdown += 1;
        Debug.Log(countdown);

        if(countdown > waitTime)
        {
            fadeIn.SetBool("start", true);
        }
    }
}
