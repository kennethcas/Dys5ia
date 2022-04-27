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

        checkKeys();
        
        if (!walking)
        {
            playerWalk.SetBool("isWalking", false);
        }
        else if (walking)
        {
            playerWalk.SetBool("isWalking", true);
        }

        walking = false;


    }


    void checkKeys()
    {

        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerMove(0, -speedVar);
        }
        else
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerMove(0, speedVar);
        }


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerMove(-speedVar, 0);
            playerSprite.flipX = false;
        }
        else
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerMove(speedVar, 0);
            playerSprite.flipX = true;
        }


    }


    void playerMove(int speedX, int speedY)
    {
        walking = true;
        playerBody.velocity = new Vector2(speedX, speedY);
    }
}

