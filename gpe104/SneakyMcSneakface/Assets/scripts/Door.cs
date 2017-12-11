using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/******************************************************************************
* Door */
/**
* Checks to see if the player has the correct key and deletes itself.
******************************************************************************/
public class Door : MonoBehaviour
  {
  /** Color. */         public string color;

  /** Exit for game. */ public bool exit = false;

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
      if(GameManager.instance.checkForKey(color))
        {
        Debug.Log("Has key " + color);
        Destroy(gameObject);
        }
      else
        Debug.Log("Does not have key " + color);
      }
    }
  }
