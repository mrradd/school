using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/******************************************************************************
* Key */
/**
* Key for opening doors.
******************************************************************************/
public class Key : MonoBehaviour
  {
  /** Color. */
  public string color;

  /**************************************************************************
  * Unity Methods 
  **************************************************************************/
  /**************************************************************************
  * OnTriggerEnter
  **************************************************************************/
  void OnTriggerEnter(Collider other)
    {
    if(other.gameObject.tag == "Player")
      {
      GameManager.instance.keyCollected(color);
      Debug.Log("Picked up " + color);
      Destroy(gameObject);
      }
    }
  }
