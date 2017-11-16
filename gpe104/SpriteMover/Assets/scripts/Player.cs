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

  protected const int NORTH = 1;
  protected const int SOUTH = 2;
  protected const int EAST  = 3;
  protected const int WEST  = 4;

  /** Velocity of the sprite. */
  public float speed;

  /** Animator reference. */
  protected Animator mAnimator;

  /** Direction player is facing. */
  protected int mPlayerFacing;

  /** Rigid body 2D component. */
  protected Rigidbody2D mRigidBody2D;

  /** Starting position of the asset. */
  protected Vector2 mStartPosition;


  /******************************************************************************
  * Unity methods.
  ******************************************************************************/
  /******************************************************************************
  * Start
  ******************************************************************************/
  public void Start ()
    {
    mRigidBody2D   = GetComponent<Rigidbody2D>();
    mStartPosition = mRigidBody2D.position;
    mAnimator      = GetComponent<Animator>();
    mPlayerFacing  = SOUTH;
	  }
	
  /******************************************************************************
  * Update
  ******************************************************************************/
	public void Update ()
    {
    move();
  	}

  /******************************************************************************
  * changeFacing  */
  /**
  * Change the facing of the asset.
  ******************************************************************************/
  public void changeFacing(float x, float y)
    {
    if(x > 0)
      mPlayerFacing = EAST;
    if(x < 0)
      mPlayerFacing = WEST;
    if(y > 0)
      mPlayerFacing = NORTH;
    if(y < 0)
      mPlayerFacing = SOUTH;
    }

  /******************************************************************************
  * move */
  /**
  * Moves the player asset.
  ******************************************************************************/
  public void move()
    {
    float x = 0.0f;
    float y = 0.0f;

    /** Left Shift held. Move the asset one unit. */
    if(Input.GetKey(KeyCode.LeftShift))
      {
      /** Left Arrow pressed. */
      if(Input.GetKeyDown(KeyCode.LeftArrow))
        x = -speed;

      /** Right Arrow pressed. */
      if(Input.GetKeyDown(KeyCode.RightArrow))
        x = speed;

      /** Up Arrow pressed. */
      if(Input.GetKeyDown(KeyCode.UpArrow))
        y = speed;

      /** Down Arrow pressed. */
      if(Input.GetKeyDown(KeyCode.DownArrow))
        y = -speed;

      changeFacing(x, y);
      transform.Translate(x, y, 0.0f);
      }

    /** Space was pressed. Return to center. */
    else if(Input.GetKey(KeyCode.Space))
      mRigidBody2D.MovePosition(mStartPosition);

    /** Move the asset smoothly. */
    else
      {
      /** Left Arrow pressed. */
      if(Input.GetKey(KeyCode.LeftArrow))
        {
        x = -speed;
        }

      /** Right Arrow pressed. */
      if(Input.GetKey(KeyCode.RightArrow))
        {
        x = speed;
        }

      /** Up Arrow pressed. */
      if(Input.GetKey(KeyCode.UpArrow))
        {
        y = speed;
        mAnimator.SetTrigger("playerMoveUp");
        }

      /** Down Arrow pressed. */
      if(Input.GetKey(KeyCode.DownArrow))
        {
        y = -speed;
        mAnimator.SetTrigger("playerMoveDown");
        }

      changeFacing(x, y);
      mRigidBody2D.MovePosition(mRigidBody2D.position + new Vector2(x, y) * Time.fixedDeltaTime);
      }
    
    if(x == 0 && y == 0)
      {
      if(mPlayerFacing == SOUTH)
        mAnimator.SetTrigger("playerIdleDown");
      else if(mPlayerFacing == NORTH)
        mAnimator.SetTrigger("playerIdleUp");
      }
    }
  }
