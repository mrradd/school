using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/******************************************************************************
* EnemyHearing */
/**
* Determines if the enemy can hear the player.
******************************************************************************/
public class EnemyHearing : MonoBehaviour
  {
  /** Reference to its parent. */ public GameObject parentObject;

  /** Heard player. */               protected bool    mAlerted = false;
  /** Player's previous position. */ protected Vector3 mPreviousPosition;

  /**************************************************************************
  * Unity Methods
  **************************************************************************/
  /**************************************************************************
  * OnTriggerEnter
  **************************************************************************/
  void OnTriggerEnter(Collider other)
    {
    if(other.gameObject.tag == "Player")
      mPreviousPosition = other.gameObject.transform.position;
    }

  /**************************************************************************
  * OnTriggerEXIT
  **************************************************************************/
  void OnTriggerExit(Collider other)
    {
    if(other.gameObject.tag == "Player")
      {
      mAlerted = false;
      Debug.Log("Exitted hearing range.");
      }
    }

  /**************************************************************************
  * OnTriggerStay
  **************************************************************************/
  void OnTriggerStay(Collider other)
    {

    /** See of player within the trigger area. */
    if(other.gameObject.tag == "Player")
      {
      Vector3 currentPosition;

      currentPosition = other.gameObject.transform.position;

      /** Player moved which makes a sound. */
      if(mPreviousPosition != currentPosition)
        {
        mPreviousPosition = other.gameObject.transform.position;
        parentObject.transform.LookAt(other.gameObject.transform);

        alerted();
        }
      }
    }
  
  /**************************************************************************
  * Update */ 
  /**
  **************************************************************************/
  public virtual void Update ()
    {

    }

  /**************************************************************************
  * Methods 
  **************************************************************************/
  /**************************************************************************
  * alerted */ 
  /**
  * Action when alerted.
  **************************************************************************/
  public virtual void alerted()
    {
    GameManager.instance.playerLives--;
    }
  }
