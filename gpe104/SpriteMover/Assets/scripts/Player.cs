using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/******************************************************************************
* Player */
/**
* Player controller.
******************************************************************************/
public class Player : MonoBehaviour
  {

  /******************************************************************************
  * Unity methods.
  ******************************************************************************/
  /******************************************************************************
  * Start
  ******************************************************************************/
  public void Start ()
    {
		
	  }
	
  /******************************************************************************
  * Update
  ******************************************************************************/
	public void Update ()
    {
    move();
  	}

  /******************************************************************************
  * move */
  /**
  * Moves the player.
  ******************************************************************************/
  public void move()
    {
    Vector3 position = transform.position;

    if(Input.GetKey(KeyCode.LeftArrow))
      position.x--;

    if(Input.GetKey(KeyCode.RightArrow))
      position.x++;

    if(Input.GetKey(KeyCode.UpArrow))
      position.y++;

    if(Input.GetKey(KeyCode.DownArrow))
      position.y--;

    transform.position = position;
    }
  }
