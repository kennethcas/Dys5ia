using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WrongLevelTriggers : MonoBehaviour
{
    private BoxCollider collision;
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

    public AudioSource winNoise;
    public ParticleSystem winParticles;

    private void Awake()
    {
        collision = GetComponent<BoxCollider>();
        student1Cue.SetActive(false);
        student2Cue.SetActive(false);
        student3Cue.SetActive(false);
        student4Cue.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        // SETTING ACTIVE CUES
        if(collision.gameObject.tag == "stuTrig1")
        {
            Debug.Log("colliding with stuTrig1");
            student1Cue.SetActive(true);
        }
        if (collision.gameObject.tag == "stuTrig2")
        {
            student2Cue.SetActive(true);
        }
        if (collision.gameObject.tag == "stuTrig3")
        {
            student3Cue.SetActive(true);
        }
        if (collision.gameObject.tag == "stuTrig4")
        {
            student4Cue.SetActive(true);
            winNoise.Play();
            winParticles.Play();
        }

        if (collision.gameObject.tag == "exitTrig")
        {
            Debug.Log("colliding with exit trigger");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
