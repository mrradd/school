using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/******************************************************************************
* CollisionSensor */
/**
* Responds when player collides with game object.
******************************************************************************/
public class CollisionSensor : MonoBehaviour
  {

  /** Sound when player triggers object. */ public AudioClip triggerSound;

  /**************************************************************************
  * Unity Methods 
  **************************************************************************/
  /**************************************************************************
  * OnCollisionEnter */ 
  /**
  **************************************************************************/
  void OnTriggerEnter(Collider other)
    {
    if(other.gameObject.tag == "Player")
      {
      gameObject.GetComponent<AudioSource>().PlayOneShot(triggerSound);
      Debug.Log("Player triggered!");
      }
    }
  
  }
