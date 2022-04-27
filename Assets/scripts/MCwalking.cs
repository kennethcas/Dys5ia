using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCwalking : MonoBehaviour
{

    public GameObject playerObject;
    public Rigidbody2D playerBody;
    public int speedVar = 5; //how fast player moves
    public SpriteRenderer playerSprite;
    public Animator playerWalk;



    void FixedUpdate()
    {

        checkKeys();

        checkWalk();


    }


    void checkKeys() //checks for player input and sets movement
    {
        float horiMove;
        horiMove = Input.GetAxis("Horizontal") * speedVar;

        float vertMove;
        vertMove = Input.GetAxis("Vertical") * speedVar;
       
        playerMove(horiMove, vertMove);


    }


    void checkWalk() //sets walking animation
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



}

