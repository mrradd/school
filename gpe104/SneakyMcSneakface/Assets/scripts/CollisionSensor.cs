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
    if(other.gameObject.tag == "Player" && !GameManager.instance.found)
      {
      Debug.Log("Player triggered!");
      gameObject.GetComponent<AudioSource>().PlayOneShot(triggerSound);
      GameManager.instance.found = true;
      GameManager.instance.loseLife();
      }
    }
  
  }
