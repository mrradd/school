using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/******************************************************************************
* GuardHearing */
/**
* Guard behavior when listening for player.
******************************************************************************/
public class GuardHearing : EnemyHearing
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
      base.alerted();
      gameObject.GetComponent<AudioSource>().PlayOneShot(alertedSound);
      Debug.Log("Player sighted by Camera!");
      }
    }
  }
