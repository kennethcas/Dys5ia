using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCwalking : MonoBehaviour
{

    public GameObject playerObject;
    public Rigidbody2D playerBody;
    public float speedVar = 5.0f; //how fast player moves

    public SpriteRenderer playerSprite;
    public Animator playerWalk; //walk anim

    public AudioSource playerNoise; //controls beep noise
    
    Vector3 startPos; //holds starting position

    public GameObject smileyObj;
    public AudioSource pickupNoise;

    public ParticleSystem winParts;
    int pickupCounter;
    public AudioSource pickupWin;


    private void Start()
    {
        startPos = gameObject.transform.position;
    }


  
    void FixedUpdate()
    {
        
        checkKeys();

        checkWalk();

        checkPickups();

        Debug.Log(pickupCounter);

    }


    void checkKeys() //checks for player input and sets movement
    {
        float horiMove;
        horiMove = Input.GetAxis("Horizontal") * speedVar;

        float vertMove;
        vertMove = Input.GetAxis("Vertical") * speedVar;
       
        playerMove(horiMove, vertMove);


    }


    void checkWalk() //sets walking animation and direction
    {
        if (Mathf.Abs(playerBody.velocity.x) > 0.01)
        {
            playerWalk.SetBool("isWalking", true);
        }
        else if (Mathf.Abs(playerBody.velocity.y) > 0.01)
        {
            playerWalk.SetBool("isWalking", true);
        }
        else
        {
            playerWalk.SetBool("isWalking", false);
        }


        if(playerBody.velocity.x < 0)
        {
            playerSprite.flipX = false;
        } else if (playerBody.velocity.x > 0)
        {
            playerSprite.flipX = true;
        }

    }


    void playerMove(float speedX, float speedY) //movement itself
    {
        playerBody.velocity = new Vector2(speedX, speedY);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "SFX")
        {
            collision.gameObject.GetComponent<Animator>().SetBool("playerCol", true); //call flash
            playerNoise.Play(); //play noise
            gameObject.transform.position = startPos; //reset player pos
        }

        if(collision.gameObject.tag == "clothes")
        {
            smileySpawn(collision.gameObject);
            pickupNoise.Play(); 
            Destroy(collision.gameObject);
        }




    }


    void smileySpawn(GameObject clothes)
    {
        GameObject smiley = Instantiate(smileyObj);
        smiley.transform.localPosition = new Vector3(clothes.gameObject.transform.position.x, clothes.gameObject.transform.position.y, clothes.gameObject.transform.position.z);
        pickupCounter += 1;
    }



    void checkPickups()
    {
        if(pickupCounter == 4)
        {
            winParts.Play();
            pickupWin.Play();
            pickupCounter += 1;
        }
    }



}

