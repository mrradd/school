﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/****************************************************************************
* Bullet */ 
/**
* A projectile fired by the player's space ship.
*
* Destroyed when it hits an asteroid, or goes off screen.
****************************************************************************/
public class Bullet : Thing
  {
  /**************************************************************************
  * Unity Methods 
  **************************************************************************/
  /**************************************************************************
  * OnBecameInvisible */ 
  /**
  **************************************************************************/
  public void OnBecameInvisible()
    {
    kill();
    }
  
  /**************************************************************************
  * OnCollisionEnter */ 
  /**
  **************************************************************************/
  public void OnCollisionEnter2D(Collision2D coll)
    {
    if(coll.gameObject.tag == "Asteroid")
      {
      coll.gameObject.SendMessage("kill");
      GameObject.FindGameObjectWithTag("GameManager").GetComponent<MainGameSceneManager>().incrementPlayerScore(10);
      }
    }

  /**************************************************************************
  * Update */ 
  /**
  **************************************************************************/
  public void Update ()
    {
    move();
    }

  /**************************************************************************
  * Methods 
  **************************************************************************/
  /**************************************************************************
  * kill */ 
  /**
  * Kill the Player.
  **************************************************************************/
  public override void kill()
    {
    Destroy(gameObject);
    }
  
  /**************************************************************************
  * move */ 
  /**
  * Moves the bullet.
  **************************************************************************/
  protected override void move ()
    {
    Vector3 pos      = transform.position;
    Vector3 velocity = new Vector3(0, speed * Time.deltaTime, 0);

    pos += transform.rotation * velocity;
    transform.position = pos;
    }
  }
