using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camShake : MonoBehaviour
{

   
    public float magnitude;
    public float duration;
    public float smoothing;

    Vector3 startPos;

    private void Start()
    {
        startPos = gameObject.transform.localPosition;
    }

    public void startShake()
    {
        StartCoroutine(Shake());
    }

    IEnumerator Shake()
    {
        float elapsed = 0.0f; //how much has passed 

        while (elapsed < duration) // as long as time elapsed is not more than duration
        {
            
            float x = Random.Range((gameObject.transform.localPosition.x - 1.0f) * magnitude, (gameObject.transform.localPosition.x + 1.0f) * magnitude);
            float y = Random.Range((gameObject.transform.localPosition.y - 0.5f) * magnitude, (gameObject.transform.localPosition.y + 0.5f) * magnitude);

            transform.localPosition = Vector3.Lerp
                (
                transform.position, 
                new Vector3(x, y, transform.localPosition.z), 
                smoothing
                );

            elapsed += Time.deltaTime; //add time until it exceeds duration

            yield return null;
        }

        transform.localPosition = startPos;
    }

}
