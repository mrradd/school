using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/******************************************************************************
* LavaBall */
/**
* Lava Ball projectile. Fired by the player.
******************************************************************************/
public class LavaBall : Projectile
  {

  /**************************************************************************
  * Unity Methods 
  **************************************************************************/
  /**************************************************************************
  * Update */ 
  /**
  **************************************************************************/
  public void OnCollisionEnter(Collision coll)
    {
    if(coll.gameObject.tag == "Player")
      GameManager.instance.playerHealth -= 2;
    
    }
  }
