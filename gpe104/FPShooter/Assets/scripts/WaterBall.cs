using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/******************************************************************************
* WaterBall */
/**
* Water Ball projectile. Fired by the enemies.
******************************************************************************/
public class WaterBall : Projectile
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
      GameManager.instance.playerHealth -= 10;
    if(coll.gameObject.tag == "PlayerProjectile")
      GameManager.instance.playerScore += 50;
    }
  }
