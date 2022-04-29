using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whiteFlash : MonoBehaviour
{
    private void endAnim()
    {
        gameObject.GetComponent<Animator>().SetBool("playerCol", false);
    }
    
}
