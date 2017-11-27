using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/****************************************************************************
* GameOverSceneManager */ 
/**
* Singleton class which manages the Game Over Scene.
****************************************************************************/
public class GameOverSceneManager : BaseManager
  {

  protected static GameOverSceneManager mInstance;

  /** Returns an instance of GameOverSceneManager. */
  public GameOverSceneManager instance
    {
    get
      {
      if(mInstance == null)
        mInstance = new GameOverSceneManager();

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
  public override void Update ()
    {
    base.Update();
    }

  /**************************************************************************
  * Methods 
  **************************************************************************/
  /**************************************************************************
  * Constructor */ 
  /**
  **************************************************************************/
  protected GameOverSceneManager()
    {
    }

  /**************************************************************************
  * launchMainGame */ 
  /**
  * Go to the Main Game.
  **************************************************************************/
  public void launchMainGame()
    {
    SceneManager.LoadScene("MainGameScene", LoadSceneMode.Single);
    }

  /**************************************************************************
  * launchMainMenu */ 
  /**
  * Go to the Main Menu.
  **************************************************************************/
  public void launchMainMenu()
    {
    SceneManager.LoadScene("StartScene", LoadSceneMode.Single);
    }


}
