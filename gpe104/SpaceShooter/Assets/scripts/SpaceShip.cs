using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/****************************************************************************
* SpaceShip */ 
/**
* Asset controlled by the player. It stays in the center of the screen and
* rotates about its center in different directions based on input.
****************************************************************************/
public class SpaceShip : Thing 
  {
  /** Bullet game object. */      public GameObject bullet;
  /** Explosion sound. */         public AudioClip  explosionSound;
  /** Speed of the projectile. */ public float      rotationSpeed;

  /** Z axis rotation value. */ protected float mDeltaZ = 0;

  /**************************************************************************
  * Unity Methods 
  **************************************************************************/

  /**************************************************************************
  * OnCollisionEnter */ 
  /**
  **************************************************************************/
  public void OnCollisionEnter2D(Collision2D coll)
    {
    if(coll.gameObject.tag == "Asteroid")
      coll.gameObject.SendMessage("kill");
    }

  /**************************************************************************
  * Update */ 
  /**
  **************************************************************************/
  public void Update ()
    {
    move();
    fireProjectile();
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
    GameObject.FindGameObjectWithTag("GameManager").GetComponent<MainGameSceneManager>().decrementPlayerLives();
    gameObject.GetComponent<AudioSource>().PlayOneShot(explosionSound);
    }

  /**************************************************************************
  * fireProjectile */ 
  /**
  * Fires a projectile in the direction being faced.
  **************************************************************************/
  public void fireProjectile()
    {
    /** Spacebar pressed. Fire projectile. */
    if(Input.GetKeyDown(KeyCode.Space))
      {
      Instantiate(bullet, transform.position, transform.rotation);
      }
    }
  
  /**************************************************************************
  * rotate */ 
  /**
  * Rotate the spaceship left and right, and move it forward and backward.
  * TODO CH  Consider using physics for movement.
  **************************************************************************/
  protected override void move()
    {
    Vector3 pos      = transform.position;
    float   newSpeed = 0;

    /** Left Arrow pressed. Rotate left. */
    if(Input.GetKey(KeyCode.LeftArrow))
      {
      mDeltaZ += Time.deltaTime * rotationSpeed;
      transform.rotation = Quaternion.Euler(0, 0, mDeltaZ);
      }

    /** Right Arrow pressed. Rotate right. */
    if(Input.GetKey(KeyCode.RightArrow))
      {
      mDeltaZ -= Time.deltaTime * rotationSpeed;
      transform.rotation = Quaternion.Euler(0, 0, mDeltaZ);
      }

    /** Up Arrow. Move forward. */
    if(Input.GetKey(KeyCode.UpArrow))
      {
      newSpeed = speed;
      }

    /** Down Arrow. Move backward. */
    if(Input.GetKey(KeyCode.DownArrow))
      {
      newSpeed = -speed;
      }

    /** Update position. */
    if(newSpeed != 0f)
      {
      Vector3 velocity = new Vector3(0, newSpeed * Time.deltaTime, 0);
      pos += transform.rotation * velocity;
      transform.position = pos;
      }
    }
  }
