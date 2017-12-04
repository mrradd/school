using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/******************************************************************************
* Box */
/**
* Handles the box object.
******************************************************************************/
public class Box : MonoBehaviour
  {
  /** Hit sound. */ public AudioClip  hitSound;

  /**************************************************************************
  * Unity Methods 
  **************************************************************************/
  public void OnCollisionEnter(Collision coll)
    {
    if(coll.gameObject.tag == "EnemyProjectile" || coll.gameObject.tag == "PlayerProjectile")
      gameObject.GetComponent<AudioSource>().PlayOneShot(hitSound);
    }
  }