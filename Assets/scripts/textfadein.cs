using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class textfadein : MonoBehaviour
{
    public float waitTime;
    public Animator fadeIn;
    float countdown;
    public float endTime;
    

    // Update is called once per frame
    void Update()
    {
        countdown += 1;
        Debug.Log(countdown);

        if(countdown > waitTime)
        {
            fadeIn.SetBool("start", true);
        }

        if(countdown > endTime)
        {
            SceneManager.LoadScene("smileyroom");
        }



    }
}
