using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/******************************************************************************
* CollisionSensor */
/**
* Responds when player collides with game object.
******************************************************************************/
public class CollisionSensor : MonoBehaviour
  {
  /**************************************************************************
  * Unity Methods 
  **************************************************************************/
  /**************************************************************************
  * OnCollisionEnter */ 
  /**
  **************************************************************************/
  void OnTriggerEnter(Collider other)
    {
    if(other.gameObject.tag == "Player")
      {
      Debug.Log("Player triggered!");
      }
    }
  
  }
