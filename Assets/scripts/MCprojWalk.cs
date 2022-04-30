using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCprojWalk : MonoBehaviour
{

    public GameObject playerObject;
    public Rigidbody2D playerBody;
    public int speedVar = 5; //how fast player moves
    public SpriteRenderer playerSprite;
    public Animator playerWalk; //walkanim
    public AudioSource playerNoise; //controls beep noise 
    Vector3 startPos;


    // Start is called before the first frame update
    void Start()
    {
        startPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        checkKeys();
        checkWalk();
        gameObject.transform.position = new Vector3(startPos.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }




    void checkKeys() //checks for player input and sets movement
    {
        float vertMove;
        vertMove = Input.GetAxis("Vertical") * speedVar;

        playerMove(vertMove);
    }



    void checkWalk() //sets walking animation
    {
       if (Mathf.Abs(playerBody.velocity.y) > 0.01)
        {
            playerWalk.SetBool("isWalking", true);
        }
        else
        {
            playerWalk.SetBool("isWalking", false);
        }
    }



    void playerMove(float speedY) //movement itself
    {
        playerBody.velocity = new Vector2(gameObject.transform.position.x, speedY);
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "SFX")
        {
            gameObject.transform.position = startPos;
            playerNoise.Play();
            Destroy(collision.gameObject);
            FindObjectOfType<whiteFlash>().GetComponent<Animator>().SetBool("playerCol", true);
        }
    }

}
