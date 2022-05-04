using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class singleTrigger : MonoBehaviour
{
    private BoxCollider collision;
    [Header("Trigger")]
    public GameObject triggerObj;
    [Header("Visual Cues")]
    public GameObject cueObj;
    [Header("Timer")]
    public float timer;
    public bool timerStarted;
    

    private void Awake()
    {
        collision = GetComponent<BoxCollider>();
        cueObj.SetActive(false);
        timerStarted = false;
    }

    private void Update()
    {
        Debug.Log(timer);
        if (timerStarted)
        {
            timer -= Time.deltaTime;
            if(timer <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("colliding with trigger obj");
        cueObj.SetActive(true);
        timerStarted = true;

        //timer -= Time.deltaTime;

    }

   /* public void startTimer()
    {
        timer -= Time.deltaTime;
    }*/
}
