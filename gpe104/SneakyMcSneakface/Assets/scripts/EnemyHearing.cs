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
        Debug.Log("Player heard!");
        }
      }
    }
  
  /**************************************************************************
  * Update */ 
  /**
  **************************************************************************/
  void Update ()
    {

    }
  }
