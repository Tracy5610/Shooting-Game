using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.Requests;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    //variable for reset 
    public Vector2 StartPos;

    //variables for speed
    public float xSpeed = 0; //variable for horizontal speed
    public float ySpeed = 0; //variable for vertical speed

    //variables for borders
    private float xBorder = 7.5f; //variable for horizontal border
    private float yBorder = 4.5f; //variable for vertical border

    //variables for move state
    public bool xMove = true;
    public bool yMove = true;

    //varialbles for score
    int playerOneScore;
    public Text scoreTextP1;

    int playerTwoScore;
    public Text scoreTextP2;


    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 0.017f;   //declare value for horizontal speed
        ySpeed = 0.017f;   //declare value for vertical speed
    }

    // Update is called once per frame
    void Update()
    {

        //horizontal movement
        if (xMove == true)
        {
            transform.position = new Vector2(transform.position.x + xSpeed, transform.position.y); //move right
        }
        else
        {
            transform.position = new Vector2(transform.position.x - xSpeed, transform.position.y); //move left
        }


        if (transform.position.x >= xBorder)
        {
            xMove = false; //make it go left
            playerOneScore++;
        }

        if (transform.position.x <= -xBorder)
        {
            xMove = true;
            playerTwoScore += 1;
        }

        //vertical movement
        if (yMove == true)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + ySpeed); //move up
        }

        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - ySpeed);   //move down
        }
        if (transform.position.y >= yBorder)
        {
            yMove = false;
        }

        if (transform.position.y <= -yBorder)
        {
            yMove = true;
        }

        scoreTextP1.text = playerOneScore.ToString();

        scoreTextP2.text = playerTwoScore.ToString();
    }

    void OnCollisionEnter2D(Collision2D collision) //when a collision happens
    {
        Debug.Log("hit");
        if (collision.collider.CompareTag("Player"))
        {
            if (xMove == true)
            {
                xMove = false;
            }
            else if (xMove == false)
            {
                RestartPosition();
            }
        }
    }

    private void RestartPosition()
    {
        if (transform.position.x > (StartPos.x + 10) || transform.position.x < (StartPos.x - 10))
        {
            this.transform.position = StartPos;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        RestartPosition();
    }

}

