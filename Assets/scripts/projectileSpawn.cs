using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileSpawn : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Sprite[] projectileSprite;
    public float waitTime;
    public int countdown;
    public int startCountdown;


    private void Update()
    {
        countdown = countdown + 1;
        if (countdown > startCountdown)
        {
            randomizeSprite();
            countdown = 0;
        }
    }


    IEnumerator spawnIn(float waitTime)
    {
        yield return new WaitForSecondsRealtime(waitTime);
        Time.timeScale = 1.0f;
        randomizeSprite();
    }



    void randomizeSprite()
    {
        GameObject newProjectile = Instantiate(projectilePrefab); //new spawn @ current loc of head
        int randSprite = Random.Range(0, projectileSprite.Length);
        newProjectile.GetComponent<SpriteRenderer>().sprite = projectileSprite[randSprite];
        newProjectile.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        
    }

}
