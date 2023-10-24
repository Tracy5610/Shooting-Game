using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    //variables 
    public Transform SpawnBullet;
    public GameObject bulletPrefab;

    //variable for speed of bullet
    public float bulletSpeed = 5f;

    //variable for movement
    public float xBorder = 3.6f;

    //variables for speed
    public float xSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 0.017f;   //declare value for horizontal speed
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))    //When the spacebar is pressed 
        {
            var bullet = Instantiate(bulletPrefab, SpawnBullet.position, SpawnBullet.rotation); //spawn bullet into the game
            bullet.GetComponent<Rigidbody2D>().velocity = SpawnBullet.up * bulletSpeed; //shoots bullet up 
        }

        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.y < xBorder)    //when the left arrow is pressed
        {
            transform.position = new Vector2(transform.position.x - xSpeed, transform.position.y); //move left
        }

        if (Input.GetKey(KeyCode.RightArrow) && transform.position.y > -xBorder)    //when the right arrow is pressed
        {
            transform.position = new Vector2(transform.position.x + xSpeed, transform.position.y); //move right
        }
    }
}


