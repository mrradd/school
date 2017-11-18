using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/****************************************************************************
* SpaceShip */ 
/**
* Asset controlled by the player. It stays in the center of the screen and
* rotates about its center in different directions based on input.
****************************************************************************/
public class SpaceShip : MonoBehaviour 
  {
  /** Bullet game object. */      public GameObject bullet;
  /** Speed of the projectile. */ public float rotationSpeed;

  /** Z axis rotation value. */ protected float mDeltaZ = 0;

  /****************************************************************************
  * Unity Methods 
  ****************************************************************************/
  /****************************************************************************
  * Start */ 
  /**
  ****************************************************************************/
  public void Start ()
    {

    }

  /****************************************************************************
  * Update */ 
  /**
  ****************************************************************************/
  public void Update ()
    {
    rotate();
    fireProjectile();
    }

  /****************************************************************************
  * Methods 
  ****************************************************************************/
  /****************************************************************************
  * fireProjectile */ 
  /**
  * Fires a projectile in the direction being faced.
  ****************************************************************************/
  public void fireProjectile()
    {
    /** Spacebar pressed. Fire projectile. */
    if(Input.GetKeyDown(KeyCode.Space))
      {
      Instantiate(bullet);
      }
    }
  
  /****************************************************************************
  * rotate */ 
  /**
  * Rotate the spaceship left and right.
  ****************************************************************************/
  public void rotate()
    {
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
    }
  }
