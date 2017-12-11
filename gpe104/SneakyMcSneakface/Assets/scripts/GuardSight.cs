using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/******************************************************************************
* GuardSight */
/**
* Guard behavior when looking for player.
******************************************************************************/
public class GuardSight : EnemySight
  {
  /** Sound when player found. */ public AudioClip alertedSound;

  /**************************************************************************
  * Unity Methods 
  **************************************************************************/
  /**************************************************************************
  * Update */ 
  /**
  **************************************************************************/
  public override void Update()
    {
    base.Update();
    }

  /**************************************************************************
  * Methods 
  **************************************************************************/
  /**************************************************************************
  * alerted */ 
  /**
  * Action when alerted.
  **************************************************************************/
  public override void alerted()
    {
    if(!mAlerted)
      {
      mAlerted = true;
      gameObject.GetComponent<AudioSource>().PlayOneShot(alertedSound);
      Debug.Log("Player sighted by Camera!");
      }
    }
  }
