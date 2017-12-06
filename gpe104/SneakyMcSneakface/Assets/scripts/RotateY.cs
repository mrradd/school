using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/******************************************************************************
* RotateY */
/**
* Rotates the object on its Y axis over time in the positive and negative
* directions.
******************************************************************************/
  public class RotateY : MonoBehaviour
  {
  /** Amount of degrees rotate in either direction. */ public float deltaRotation = 45.0f;
  /** Speed factor to rotate at. */                    public float rotationSpeed = 3f;

  /** Current rotation. */            protected float mRotation;
  /** Rotating positive direciton. */ protected bool  mRotatePositive;
  /** Max degree to rotate to. */     protected float mMaxRotaion;
  /** Least degree to rotate to. */   protected float mMinRotation;

  /**************************************************************************
  * Unity Methods 
  **************************************************************************/
  /**************************************************************************
  * Start */ 
  /**
  **************************************************************************/
  void Start()
    {
    mRotation    = 0f;
    mMaxRotaion  = deltaRotation;
    mMinRotation = -deltaRotation;
    }
  
  /**************************************************************************
  * Update */ 
  /**
  **************************************************************************/
  void Update ()
    {

    /** Rotate in the positive direction. */
    if(mRotatePositive)
      {
      mRotation += rotationSpeed * Time.deltaTime;

      if(mRotation <= mMaxRotaion)
        gameObject.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
      else
        {
        mRotatePositive = !mRotatePositive;
        }
      }

    /** Rotate in the negative direction. */
    if(!mRotatePositive)
      {
      mRotation -= rotationSpeed * Time.deltaTime;

      if(mRotation >= mMinRotation)
        gameObject.transform.Rotate(0, -rotationSpeed * Time.deltaTime,0);
      else
        {
        mRotatePositive = !mRotatePositive;
        }
      }
    }
  
  }
