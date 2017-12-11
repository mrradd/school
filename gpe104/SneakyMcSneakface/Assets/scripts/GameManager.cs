using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

/******************************************************************************
* GameManager */
/**
* Singleton class which manages the game.
******************************************************************************/
public class GameManager : MonoBehaviour
  {
  /** Instance. */ protected static GameManager mInstance;

  /** Has pink key flag. */   public bool    hasPinkKey   = false;
  /** The main objective. */  public bool    hasTheObject = false;
  /** Has yellow key flag. */ public bool    hasYellowKey = false;
  /** Has pink key flag. */   public bool    hasWhiteKey  = false;
  /** Checkpoint position.*/  public Vector3 lastCheckPoint; 

  /** God Mode. */ public bool godMode = false;

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
  * Start */ 
  /**
  **************************************************************************/
  public void Awake ()
    {
    mInstance = this;
    lastCheckPoint = new Vector3(1031, 1001, 970);
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

    /** Toggle God Mode. */
    if(Input.GetKeyDown(KeyCode.F10))
      godMode = !godMode;

    /** God Mode activated. */
    if(godMode)
      {
      if(Input.GetKeyDown(KeyCode.P))
        {
        GameObject.Find("FPSController").gameObject.transform.position = lastCheckPoint;
        }
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
      return hasPinkKey;

    if(color == "yellow")
      return hasYellowKey;

    if(color == "white")
      return hasWhiteKey;

    if(color == "blurple")
      return hasTheObject;

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
      hasPinkKey = true;

    if(color == "yellow")
      hasYellowKey = true;

    if(color == "white")
      hasWhiteKey = true;

    if(color == "blurple")
      hasTheObject = true;
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
  }
