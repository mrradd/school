using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**************************************************************************
* Asteroid */ 
/**
* A space body that moves across the screen which the player must destroy.
* If it hits the player, the player loses a life. Destroyed if hit by a
* projectile.
**************************************************************************/
public class Asteroid : Thing 
  {

  /** Delay before destroyed. */ public float destroyDelay;
  /** Follow player. */          public bool  followPlayer;

  /** Asteroid is active. */                protected bool    mActive = true;
  /** Asteroid's initial point of entry. */ protected Vector3 mStartPoint;
  /** Asteroid's target point. */           protected Vector3 mTargetPoint;

  /** Asteroid's colliders. Used to update Polygon Collider on every anim update. */
  [SerializeField]
  protected PolygonCollider2D[] mColliders;
  protected int                 mCurrentColliderIndex = 0;

  /************************************************************************
  * Unity Methods 
  ************************************************************************/
  /************************************************************************
  * OnCollisionEnter */ 
  /**
  ************************************************************************/
  public void OnCollisionEnter2D(Collision2D coll)
    {
    if (coll.gameObject.tag == "Player" || coll.gameObject.tag == "Bullet")
      {
      coll.gameObject.SendMessage("kill");
      }
    }

  /************************************************************************
  * Start */ 
  /**
  ************************************************************************/
  public void Start ()
    {

    float x = 0f;
    float y = 0f;

    /** Establish which side of the board the Asteroid spawns from. */
    int direction = (int) Random.Range(1f, 4f);

    /** North */
    if(direction == 1)
      {
      x = Random.Range(-24f, 24f);
      y = 18f;
      }

    /** West. */
    if(direction == 2)
      {
      x = -24f;
      y = Random.Range(-18f, 18f);
      }

    /** East. */
    if(direction == 3)
      {
      x = 24f;
      y = Random.Range(-18f, 18f);
      }

    /** South. */
    if(direction == 4)
      {
      x = Random.Range(-24f, 24f);
      y = -18f;
      }

    mStartPoint = transform.position = new Vector3(x, y, 0f);
    mTargetPoint  = new Vector3(-x, -y, 0f);
    }

  /************************************************************************
  * Update */ 
  /**
  ************************************************************************/
  public void Update ()
    {

    /** Check to see if object should be destroyed. */
    if(!mActive)
      {
      destroyDelay -= Time.deltaTime;

      if(destroyDelay <= 0f)
        Destroy(gameObject);
      }
    else
      move();

    if(transform.position == mTargetPoint)
      transform.position = mStartPoint;
    }

  /************************************************************************
  * Methods 
  ************************************************************************/
  /************************************************************************
  * kill */ 
  /**
  * Kill the Player.
  ************************************************************************/
  public override void kill()
    {
    /** Only deactivate now, so we can play death sound. */
    mActive = false;

    /** HACK: Need to find a way to properly disable all colliders, and
     *  stop rendering anim which updates active colliders. */
    transform.position = new Vector3(200f, 200f, 0f);

    gameObject.GetComponent<AudioSource>().Play();

    GameObject.FindGameObjectWithTag("GameManager").GetComponent<MainGameSceneManager>().decrementAsteroidCounter();
    }

  /************************************************************************
  * move */ 
  /**
  * Moves the bullet toward the target point, or player.
  ************************************************************************/
  protected override void move ()
    {
    if(followPlayer)
      {
      Vector3 playerPos = GameObject.FindGameObjectWithTag("Player").gameObject.transform.position;
      transform.position = Vector3.MoveTowards(transform.position, playerPos, speed * Time.deltaTime);
      }
    else
      transform.position = Vector3.MoveTowards(transform.position, mTargetPoint, speed * Time.deltaTime);
    }
  
  /************************************************************************
  * updateCollider */ 
  /**
  * Updates the Polygon Collider.
  * @param  spriteNum  Current sprite number.
  ************************************************************************/
  public void updateCollider (int spriteNum)
    {
    mColliders[mCurrentColliderIndex].enabled = false;
    mCurrentColliderIndex = spriteNum;
    mColliders[mCurrentColliderIndex].enabled = true;
    }
  }
 