using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/******************************************************************************
* Checkpoint */
/**
* Checkpoint character spawns from.
******************************************************************************/
public class Checkpoint : MonoBehaviour
  {
  /** Sound when triggered. */ public AudioClip triggeredSound;

  /** Checkpoint triggered. */ protected bool mTriggered = false;

  /**************************************************************************
  * Unity Methods 
  **************************************************************************/
  /**************************************************************************
  * OnCollisionEnter */ 
  /**
  **************************************************************************/
  void OnTriggerEnter(Collider other)
    {
    if(other.gameObject.tag == "Player" && !mTriggered)
      {
      mTriggered = true;
      Debug.Log("Checkpoint!");
      GameManager.instance.lastCheckPoint = transform.position;
      gameObject.GetComponent<AudioSource>().PlayOneShot(triggeredSound);
      }
    }
  
  }
