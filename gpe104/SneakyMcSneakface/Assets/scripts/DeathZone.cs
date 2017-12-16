using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/******************************************************************************
* DeathZone */
/**
* Trigger that kills the player.
******************************************************************************/
public class DeathZone : MonoBehaviour
  {
  public AudioClip deathSound;

  /**************************************************************************
  * Unity Methods 
  **************************************************************************/
  /**************************************************************************
  * OnTriggerEnter */ 
  /**
  **************************************************************************/
  public void OnTriggerEnter(Collider other)
    {
    if(other.gameObject.tag == "Player")
      {
      GameManager.instance.respawnFromLastCheckpoint();
      GameManager.instance.playerLives--;
      }
    }

  }
