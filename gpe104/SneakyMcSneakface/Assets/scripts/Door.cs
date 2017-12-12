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
  /** Color. */             public string    color;
  /** Door locked sound. */ public AudioClip doorLocked;
  /** Door open sound. */   public AudioClip doorOpened;
  /** Exit for game. */     public bool      exit = false;

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
      if(GameManager.instance.checkForKey(color) || GameManager.instance.godMode)
        {
        Debug.Log("Has key " + color);

        transform.position = new Vector3(0f, 0f, 0f);

        gameObject.GetComponent<AudioSource>().PlayOneShot(doorOpened);
        Destroy(gameObject, 4f);

        if(exit)
          GameManager.instance.loadWinScene();
        }
      else
        {
        Debug.Log("Does not have key " + color);
        gameObject.GetComponent<AudioSource>().PlayOneShot(doorLocked);
        }
      }
    }
  }
