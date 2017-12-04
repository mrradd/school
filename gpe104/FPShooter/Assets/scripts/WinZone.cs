using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/******************************************************************************
* WinZone */
/**
* Win game trigger.
******************************************************************************/
public class WinZone : MonoBehaviour
  {
  /**************************************************************************
  * Unity Methods 
  **************************************************************************/
  /**************************************************************************
  * OnTriggerEnter */ 
  /**
  **************************************************************************/
  public void OnTriggerEnter(Collider other)
    {
    if(other.gameObject.tag == "Player")
      {
      GameManager.instance.loadScene("WinScene");
      }
    }

  }
