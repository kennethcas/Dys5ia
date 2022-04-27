using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashCollision: MonoBehaviour
{
    public Camera mainCam;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "SFX")
        {
            mainCam.GetComponent<camShake>().startShake();
        }
    }
}
