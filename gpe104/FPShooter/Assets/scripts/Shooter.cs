using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/******************************************************************************
* Shooter */
/**
* Fires a projectile.
******************************************************************************/
public class Shooter : MonoBehaviour
  {

  /** Amount of time before charging starts. */ public float      chargeDelay;
  /** Force to fire projectile by. */           public float      force;
  /** Rate at which force increases. */         public float      forceDelta;
  /** Max force allowable. */                   public float      maxForce;
  /** Minimum force allowable. */               public float      minForce;
  /** Projectile to fire. */                    public GameObject projectile;
  /** Max number of projectiles. */             public int        projectileLimit;

  /** Amount of time before charging starts. */   protected float mInitialChargeDelay;
  /** Remaining amount of projectiles to fire. */ protected int   mProjectilesRemaining;

  /**************************************************************************
  * Unity Methods 
  **************************************************************************/
  /**************************************************************************
  * Start */ 
  /**
  **************************************************************************/
  public void Start ()
    {
    mInitialChargeDelay   = chargeDelay;
    mProjectilesRemaining = projectileLimit;
    }
  
  /**************************************************************************
  * Update */ 
  /**
  **************************************************************************/
  public void Update ()
    {
    shoot();
    reload();
    }

  /**************************************************************************
  * Methods 
  **************************************************************************/
  /**************************************************************************
  * reload */ 
  /**
  * Resetes the amount of projectiles that can be fired.
  **************************************************************************/
  protected void reload()
    {
    /** RMB pressed. Relaod projectiles. */
    if(Input.GetMouseButtonDown(1))
      {
      mProjectilesRemaining = projectileLimit;
      }
    }

  /**************************************************************************
  * shoot */ 
  /**
  * Shoots a projectile forward.
  **************************************************************************/
  protected void shoot()
    {
    /** Check to see if we have any projectiles to shoot. */
    if(mProjectilesRemaining > 0)
      {

      /** LMB being held down. Increase force. */
      if(Input.GetMouseButton(0))
        {
        chargeDelay -= chargeDelay >= 0f ? Time.deltaTime : 0f;

        force += chargeDelay <= 0f && force <= maxForce ? forceDelta : 0f;
        }
      
      /** LMB released. Fire projectile. */
      if(Input.GetMouseButtonUp(0))
        {
        mProjectilesRemaining--;
        GameObject g = Instantiate(projectile, transform.position + transform.forward, Quaternion.identity);
        g.GetComponent<Rigidbody>().AddForce(force * transform.forward);

        /** Reset force. */
        force = minForce;

        /** Reset charge delay. */
        chargeDelay = mInitialChargeDelay;
        }
      }
    }
  }
