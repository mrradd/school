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
    }

  /**************************************************************************
  * Update */ 
  /**
  **************************************************************************/
  public void Update ()
    {
    }

  /**************************************************************************
  * Methods 
  **************************************************************************/
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
