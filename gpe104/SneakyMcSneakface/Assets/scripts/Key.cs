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
  /** Color. */                public string    color;
  /** Sound when picked up. */ public AudioClip pickupSound;

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
      transform.position = new Vector3(0f, 0f, 0f);
      gameObject.GetComponent<AudioSource>().PlayOneShot(pickupSound);
      Destroy(gameObject, 4f);
      }
    }
  
  }
