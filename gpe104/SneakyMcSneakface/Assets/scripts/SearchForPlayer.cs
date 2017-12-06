﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/******************************************************************************
* SearchForPlayer */
/**
* Uses RayCasts to search for the player.
******************************************************************************/
public class SearchForPlayer : MonoBehaviour
  {
  public float fieldOfView = 45.0f;

  /**************************************************************************
  * Unity Methods 
  **************************************************************************/
  /**************************************************************************
  * Update */ 
  /**
  **************************************************************************/
	void Update ()
    {
    if(canSee(GameObject.FindGameObjectWithTag("Player").gameObject))
      Debug.Log("found");
	  }

  /**************************************************************************
  * Methods 
  **************************************************************************/
  /**************************************************************************
  * canSee */ 
  /**
  * Searches for the passed in target.
  **************************************************************************/
  public bool canSee ( GameObject target )
    {
    Vector3 targetPosition = target.transform.position;

    /* Find the vector from the agent to the target We do this by subtracting
     * "destination minus origin", so that "origin plus vector equals destination." */
    Vector3 agentToTargetVector = targetPosition - transform.position;

    /* Find the angle between the direction our agent is facing (forward in
     * local space) and the vector to the target. */
    float angleToTarget = Vector3.Angle (agentToTargetVector, transform.forward);

    /* if that angle is less than our field of view */
    if ( angleToTarget < fieldOfView )
      {
      /* Create a variable to hold a ray from our position to the target */
      Ray rayToTarget = new Ray();

      /* Set the origin of the ray to our position, and the direction to the
       * vector to the target */
      rayToTarget.origin = transform.position;
      rayToTarget.direction = agentToTargetVector;

      /* Create a variable to hold information about anything the ray
       * collides with */
      RaycastHit hitInfo;

      /* Cast our ray for infinity in the direciton of our ray. -- If we
       * hit something... */
      if (Physics.Raycast (rayToTarget, out hitInfo, Mathf.Infinity))
        {
        /* ... and that something is our target */
          if (hitInfo.collider.gameObject == target)
            {
            return true;
            }
        }
      }

    /* we hit nothing or if we hit something that is not our target. */
    return false; 
    }
  }
