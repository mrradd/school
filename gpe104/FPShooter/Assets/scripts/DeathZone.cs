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
      GameManager.instance.playerHealth -= 20;

      other.gameObject.transform.position = GameObject.Find("PlayerSpawn").gameObject.transform.position;

      gameObject.GetComponent<AudioSource>().PlayOneShot(deathSound);
      }
    }
  
  }
