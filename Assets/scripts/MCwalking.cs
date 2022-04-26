using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCwalking : MonoBehaviour
{

    public GameObject playerObject;
    public Rigidbody2D playerBody;
    int speedVar = 5; //how fast player moves
    public SpriteRenderer playerSprite;
    public Animator playerWalk;
    bool walking;


    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerMove(0, -speedVar);
            walking = true;
        } else
        {
            walking = false;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerMove(0, speedVar);
            walking = true;
        }
        else
        {
            walking = false;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerMove(-speedVar, 0);
            spriteAnimLR(false);
            walking = true;
        }
        else
        {
            walking = false;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerMove(speedVar, 0);
            spriteAnimLR(true);
            walking = true;
        }
        else
        {
            walking = false;
        }


        if (!walking)
        {
            playerWalk.SetBool("isWalking", false);
        } else if (walking)
        {
            playerWalk.SetBool("isWalking", true);
        }

        
        

    }


    void playerMove(int speedX, int speedY)
    {
        playerBody.velocity = new Vector2(speedX, speedY);
    }

    void spriteAnimLR(bool flipped) //controls sprite changes for left right movement
    {
        playerSprite.flipX = flipped;
    }
}
