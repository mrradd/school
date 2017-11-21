using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**************************************************************************
* Asteroid */ 
/**
* A space body that moves across the screen which the player must destroy.
* If it hits the player, the player loses a life. Destroyed if hit by a
* projectile.
**************************************************************************/
public class Asteroid : Thing
  {

  /**************************************************************************
  * Unity Methods 
  **************************************************************************/
  /**************************************************************************
  * Start */ 
  /**
  **************************************************************************/
  public void Start ()
    {
    float x = 18f;
    float y = 3f;

    int direction = (int) Random.Range(1f, 4f);

    /** North */
    if(direction == 1)
      {
      x = Random.Range(-23f, 23f);
      y = 14f;
      }
     //= Random.Range(-970f, 970f);
     //= Random.Range(-540f, 540f);

    transform.position = new Vector3(x, y, 0f);
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
  * move */ 
  /**
  * Moves the bullet.
  **************************************************************************/
  protected override void move ()
    {

    }
  }
 