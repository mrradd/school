using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

/******************************************************************************
* GameManager */
/**
* Singleton class which manages the game.
******************************************************************************/
public class GameManager : MonoBehaviour
  {
  /** Instance. */ protected static GameManager mInstance;

  /** God Mode. */            public bool    godMode      = false;
  /** Has pink key flag. */   public bool    hasPinkKey   = false;
  /** The main objective. */  public bool    hasTheObject = false;
  /** Has yellow key flag. */ public bool    hasYellowKey = false;
  /** Has pink key flag. */   public bool    hasWhiteKey  = false;
  /** Checkpoint position.*/  public Vector3 lastCheckPoint;
  /** Player lives. */        public int     playerLives  = 3;

  /** Initial spawn location. */ protected Vector3 mStartPoint;

  /** Returns an instance of this. */
  public static GameManager instance
    {
    get
      {
      if(mInstance == null)
        mInstance = new GameManager();

      return mInstance;
      }
    }
    
  protected GameManager(){}
  
  /**************************************************************************
  * Unity Methods 
  **************************************************************************/
  /**************************************************************************
  * Awake */ 
  /**
  **************************************************************************/
  public void Awake ()
    {
    mInstance = this;
    }

  /**************************************************************************
  * Start */ 
  /**
  **************************************************************************/
  public void Start ()
    {
    instance.mStartPoint = instance.lastCheckPoint = new Vector3(1031, 1001, 970);
    }

  /**************************************************************************
  * Update */ 
  /**
  **************************************************************************/
  public void Update ()
    {
    /** Exc pressed. Exit game. */
    if(Input.GetKeyDown(KeyCode.Escape))
      Application.Quit();
    
    if(SceneManager.GetActiveScene().name == "MainGameScene")
      {
      /** Toggle God Mode. */
      if(Input.GetKeyDown(KeyCode.Alpha0))
        godMode = !godMode;

      /** God Mode activated. */
      if(godMode)
        {
        /** Teleport player to last checkpoint. */
        if(Input.GetKeyDown(KeyCode.P))
          {
          respawnFromLastCheckpoint();
          }
        }

      /** Player lost. */
      if(playerLives < 1)
        {
        loadGameOverScene();
        instance.playerLives = 3;
        }

      GameObject.Find("TxtLives").GetComponent<Text>().text         = "Lives: " + instance.playerLives;
      GameObject.Find("TxtWhiteKey").GetComponent<Text>().enabled   = instance.hasWhiteKey;
      GameObject.Find("TxtYellowKey").GetComponent<Text>().enabled  = instance.hasYellowKey;
      GameObject.Find("TxtPinkKey").GetComponent<Text>().enabled    = instance.hasPinkKey;
      GameObject.Find("TxtBlurpleOrb").GetComponent<Text>().enabled = instance.hasTheObject;
      GameObject.Find("TxtGodMode").GetComponent<Text>().enabled    = instance.godMode;
      }

    }

  /**************************************************************************
  * Methods 
  **************************************************************************/
  /**************************************************************************
  * checkForKey */ 
  /**
  * Checks if the player has the key of the passed in color.
  * @param  color  Color of the key to check for.
  **************************************************************************/
  public bool checkForKey(string color)
    {
    if(color == "pink")
      return instance.hasPinkKey;

    if(color == "yellow")
      return instance.hasYellowKey;

    if(color == "white")
      return instance.hasWhiteKey;

    if(color == "blurple")
      return instance.hasTheObject;

    return false;
    }
  
  /**************************************************************************
  * keyCollected */ 
  /**
  * Checks what key was collected.
  * @param  color  Color of the key.
  **************************************************************************/
  public void keyCollected(string color)
    {
    if(color == "pink")
      instance.hasPinkKey = true;

    if(color == "yellow")
      instance.hasYellowKey = true;

    if(color == "white")
      instance.hasWhiteKey = true;

    if(color == "blurple")
      instance.hasTheObject = true;
    }

  /**************************************************************************
  * loadGameOverScene */ 
  /**
  * Loads the Game Over Scene.
  **************************************************************************/
  public void loadGameOverScene()
    {
    SceneManager.LoadScene("GameOverScene", LoadSceneMode.Single);
    }

  /**************************************************************************
  * loadMainGameScene */ 
  /**
  * Loads the Main Game Scene.
  **************************************************************************/
  public void loadMainGameScene()
    {
    SceneManager.LoadScene("MainGameScene", LoadSceneMode.Single);
    }
  
  /**************************************************************************
  * loadMainMenuScene */ 
  /**
  * Loads the Main Menu Scene.
  **************************************************************************/
  public void loadMainMenuScene()
    {
    SceneManager.LoadScene("MainMenuScene", LoadSceneMode.Single);
    }

  /**************************************************************************
  * loadWinScene */ 
  /**
  * Loads the Win Scene.
  **************************************************************************/
  public void loadWinScene()
    {
    SceneManager.LoadScene("WinScene", LoadSceneMode.Single);
    }

  /**************************************************************************
  * respawnFromLastCheckpoint */ 
  /**
  * Moves the player to the last checkpoint.
  **************************************************************************/
  public void respawnFromLastCheckpoint()
    {
    GameObject.Find("FPSController").gameObject.transform.position = instance.lastCheckPoint;
    }

  /**************************************************************************
  * restart */ 
  /**
  * Restart the game.
  **************************************************************************/
  public void restart()
    {
    instance.hasPinkKey = instance.hasTheObject = instance.hasWhiteKey = instance.hasYellowKey = false;
    GameObject.Find("FPSController").gameObject.transform.position = instance.mStartPoint;
    instance.playerLives = 3;
    }
  }
