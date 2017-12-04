using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/******************************************************************************
* PlayerHit */
/**
* Handles the player being hit.
******************************************************************************/
public class PlayerHit : MonoBehaviour
  {
  /** Hit sound. */ public AudioClip  hitSound;

  /**************************************************************************
  * Unity Methods 
  **************************************************************************/
  public void OnCollisionEnter(Collision coll)
    {
    if(coll.gameObject.tag == "EnemyProjectile")
      gameObject.GetComponent<AudioSource>().PlayOneShot(hitSound);
    }
  }
