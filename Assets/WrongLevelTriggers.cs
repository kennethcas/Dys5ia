using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WrongLevelTriggers : MonoBehaviour
{
    [Header("Triggers")]
    public GameObject student1Trigger;
    public GameObject student2Trigger;
    public GameObject student3Trigger;
    public GameObject student4Trigger;
    public GameObject exitSceneTrigger;

    [Header("Visual Cues")]
    public GameObject student1Cue;
    public GameObject student2Cue;
    public GameObject student3Cue;  
    public GameObject student4Cue;

    private void Awake()
    {
        student1Cue.SetActive(false);
        student2Cue.SetActive(false);
        student3Cue.SetActive(false);
        student4Cue.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "stuTrig1")
        {
            student1Cue.SetActive(true);
        }

        if (collision.gameObject.tag == "exitTrigger")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
