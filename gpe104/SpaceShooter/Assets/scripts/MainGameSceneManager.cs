using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/****************************************************************************
* MainGameSceneManager */ 
/**
* Singleton class to manage the main game scene.
****************************************************************************/
public class MainGameSceneManager : MonoBehaviour
  {
  protected static MainGameSceneManager mInstance;

  /** Number of Asteroids on screen. */ protected int mAsteroidCounter = 0;
  /** Number of player lives. */        protected int mPlayerLives     = 3;
  /** Player score. */                  protected int mPlayerScore     = 0;

  /** Asteroid. */                                 public GameObject asteroid;
  /** Maximum Asteroids allowed to be on field. */ public int        maxAsteroids;


  /** Returns an instance of MainGameSceneManager. */
  public MainGameSceneManager instance
    {
    get
      {
      if(mInstance == null)
        mInstance = new MainGameSceneManager();

      return mInstance;
      }
    }

  /**************************************************************************
  * Unity Methods 
  **************************************************************************/
  /**************************************************************************
  * Awake */ 
  /**
  **************************************************************************/
  public void Awake()
    {
    if(!mInstance)
      mInstance = this;
    else
      {
      Debug.LogError("ERROR: There can only be one MainGameSceneManager.");
      Destroy(gameObject);
      }
    }
	
  /**************************************************************************
  * Update */ 
  /**
  **************************************************************************/
	public void Update ()
    {
    spawnAsteroid();
    checkLose();
	  }

  /**************************************************************************
  * Methods 
  **************************************************************************/
  /**************************************************************************
  * Constructor */ 
  /**
  **************************************************************************/
  protected MainGameSceneManager()
    {
    }

  /**************************************************************************
  * checkLose */ 
  /**
  * Checks if the Player lost.
  **************************************************************************/
  protected void checkLose()
    {
    /** Go to Game Over Scene. */
    if(mPlayerLives <= 0)
      {
      SceneManager.LoadScene("GameOverScene", LoadSceneMode.Single);
      }
    }

  /**************************************************************************
  * decrementAsteroidCounter */ 
  /**
  * Decrements the Asteroid Counter.
  **************************************************************************/
  public void decrementAsteroidCounter()
    {
    mAsteroidCounter--;
    }

  /**************************************************************************
  * decrementPlayerLives */ 
  /**
  * Decrements the Player Lives.
  **************************************************************************/
  public void decrementPlayerLives()
    {
    mPlayerLives--;
    }

  /**************************************************************************
  * incrementAsteroidCounter */ 
  /**
  * Increments the Asteroid Counter.
  **************************************************************************/
  public void incrementAsteroidCounter()
    {
    mAsteroidCounter++;
    }

  /**************************************************************************
  * incrementPlayerScore */ 
  /**
  * Increment the Player Score by passed in amount.
  **************************************************************************/
  public void incrementPlayerScore(int value)
    {
    mPlayerScore += value;
    }

  /**************************************************************************
  * spawnAsteroid */ 
  /**
  * Randomly spawns an Asteroid.
  **************************************************************************/
  protected void spawnAsteroid()
    {
    int roll = (int)Random.Range(0f, 16.0f);
    if(mAsteroidCounter != maxAsteroids && (roll == 1 || roll == 16))
      {
      Instantiate(asteroid);
      incrementAsteroidCounter();
      }
    }
  }
