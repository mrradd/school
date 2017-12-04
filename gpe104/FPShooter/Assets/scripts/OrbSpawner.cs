using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/******************************************************************************
* OrbSpawner */
/**
* Launches orbs in the direction it is facing.
******************************************************************************/
public class OrbSpawner : MonoBehaviour
  {
  /** Delay for firing shots. */ public float      delay;
  /** Force to launch orb at. */ public float      force; 
  /** Orb object. */             public GameObject orb;

  /** Initial delay setting. */ protected float mInitialDelay;

  /**************************************************************************
  * Unity Methods 
  **************************************************************************/
  /**************************************************************************
  * Start */ 
  /**
  **************************************************************************/
  public void Start ()
    {
    mInitialDelay      = delay;
    }

  /**************************************************************************
  * Update */ 
  /**
  **************************************************************************/
  public void Update ()
    {
    delay -= Time.deltaTime;

    if(delay <= 0f)
      {
      GameObject g = Instantiate(orb, transform.position + transform.forward, Quaternion.identity);
      g.GetComponent<Rigidbody>().AddForce(force * transform.forward);
      delay = mInitialDelay;
      }
    
    }
  
  }
