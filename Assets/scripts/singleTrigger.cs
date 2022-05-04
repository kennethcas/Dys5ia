using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class singleTrigger : MonoBehaviour
{
    private BoxCollider collision;
    [Header("Trigger")]
    public GameObject triggerObj;
    [Header("Visual Cues")]
    public GameObject cueObj;

    private void Awake()
    {
        collision = GetComponent<BoxCollider>();
        cueObj.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("colliding with trigger obj");
        cueObj.SetActive(true);
    }
}
