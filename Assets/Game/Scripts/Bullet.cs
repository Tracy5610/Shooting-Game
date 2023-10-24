using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Bullet : MonoBehaviour
{
    //variable for how long the bullet last before disappearing 
    public float life = 3;

    //Awake is called once initialised
    void Awake()
    {
        Destroy(gameObject, life);
    }

    //Function for collision
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);  //When bullet touchs the obstacle 
        Destroy(gameObject);            //Obstacle is destroyed 
    }
}
