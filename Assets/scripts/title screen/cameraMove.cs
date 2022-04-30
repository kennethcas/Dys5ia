using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cameraMove : MonoBehaviour
{
    public GameObject group1;
    public string firstLevel;

    private void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            //group1.transform.position = new Vector3(0, 300, 0);
            SceneManager.LoadScene(firstLevel);
        }
    }
}
