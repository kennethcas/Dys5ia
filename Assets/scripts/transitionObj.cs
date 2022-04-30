using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transitionObj : MonoBehaviour
{

    public AudioSource glitch;

    private void Start()
    {
        glitch.Play();
    }



    void Update()
    {

         void endAnim()
        {
            Destroy(gameObject);
        }

    }
}
