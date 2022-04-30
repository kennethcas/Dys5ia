using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileDestroy : MonoBehaviour
{
    public float speed;
    Vector3 newPos;

    private void Update()
    {
        float currentPos = gameObject.transform.position.x; 
        newPos = new Vector3(currentPos - speed, gameObject.transform.position.y, gameObject.transform.position.z);
        gameObject.transform.position = newPos;  

        if(gameObject.transform.position.x < (0 - gameObject.GetComponent<SpriteRenderer>().size.x)) 
        {
            selfDestruct();
        }

    }



    void selfDestruct()
    {
        Destroy(gameObject);
    }
 
}
