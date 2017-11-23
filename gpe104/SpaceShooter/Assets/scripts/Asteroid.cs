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
  * OnCollisionEnter */ 
  /**
  **************************************************************************/
  public void OnCollisionEnter2D(Collision2D coll)
    {
    if (coll.gameObject.tag == "Player" || coll.gameObject.tag == "Bullet")
      {
      coll.gameObject.SendMessage("kill");
      }
    }

  /**************************************************************************
  * Start */ 
  /**
  **************************************************************************/
  public void Start ()
    {

    float x = 0f;
    float y = 0f;

    /** Establish which side of the board the Asteroid spawns from. */
    int direction = (int) Random.Range(1f, 4f);

    /** North */
    if(direction == 1)
      {
      x = Random.Range(-24f, 24f);
      y = 18f;
      }

    /** West. */
    if(direction == 2)
      {
      x = -24f;
      y = Random.Range(-18f, 18f);
      }

    /** East. */
    if(direction == 3)
      {
      x = Random.Range(-24f, 24f);
      y = -18f;
      }

    /** South. */
    if(direction == 4)
      {
      x = 24f;
      y = Random.Range(-18f, 18f);
      }

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
  * kill */ 
  /**
  * Kill the Player.
  **************************************************************************/
  public override void kill()
    {
    Destroy(gameObject);
    GameObject.FindGameObjectWithTag("GameManager").GetComponent<MainGameSceneManager>().decrementAsteroidCounter();
    }

  /**************************************************************************
  * move */ 
  /**
  * Moves the bullet toward the player.
  **************************************************************************/
  protected override void move ()
    {
    Vector3 playerPos = GameObject.FindGameObjectWithTag("Player").gameObject.transform.position;

    transform.position = Vector3.MoveTowards(transform.position, playerPos, speed * Time.deltaTime);
    }
  }
 