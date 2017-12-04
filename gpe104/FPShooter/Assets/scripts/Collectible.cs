using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/******************************************************************************
* Collectible */
/**
* Something to be collected by the player.
******************************************************************************/
public class Collectible : MonoBehaviour
  {

  public AudioClip pickupSound;

  /** Life span before destroyed. */ protected float mLifeSpan  = 5f;
  /** Player collected object. */    protected bool  mCollected = false;

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
      GameManager.instance.playerScore += 1000;
      transform.position = new Vector3(0, 0, 0);
      mCollected = true;
      gameObject.GetComponent<AudioSource>().PlayOneShot(pickupSound);
      }
    }
  
  /**************************************************************************
  * Update */ 
  /**
  **************************************************************************/
  public void Update()
    {
    if(mCollected)
      {
      mLifeSpan -= Time.deltaTime;

      if(mLifeSpan <= 0f)
        Destroy(gameObject);
      }
    }
  }
