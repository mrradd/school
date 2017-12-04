using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

/******************************************************************************
* GameManager */
/**
* Singleton class which manages the game.
******************************************************************************/
public class GameManager : MonoBehaviour
  {
  /** Instance. */ protected static GameManager mInstance;

  /** Ammo Remaining. */              public int playerAmmo;
  /** Amount of health Player has. */ public int playerHealth;
  /** Player's score. */              public int playerScore;

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
    /** Esc pressed. Exit. */
    if(Input.GetKeyDown(KeyCode.Escape))
      Application.Quit();

    if(SceneManager.GetActiveScene().name == "MainGameScene")
      {
      GameObject.Find("TxtAmmo").gameObject.GetComponent<Text>().text   = "Ammo: "   + playerAmmo + "/" + GameObject.FindWithTag("MainCamera").gameObject.GetComponent<Shooter>().projectileLimit;
      GameObject.Find("TxtHealth").gameObject.GetComponent<Text>().text = "Health: " + playerHealth;
      GameObject.Find("TxtScore").gameObject.GetComponent<Text>().text  = "Score: "  + playerScore;

      /** Player loses. */
      if(playerHealth <= 0)
        {
        loadScene("GameOverScene");
        }
      }
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
  * loadScene */ 
  /**
  * Loads the passed in Scene name, and turns on the mouse.
  * @param  sceneName  Scene Name to load.
  **************************************************************************/
  public void loadScene(string sceneName)
    {
    /** Unhide and unlock the cursor. This was locked and hidden by the FirstPersonController from Unity. */
    GameObject.Find("FPSController").GetComponent<FirstPersonController>().mouseLook.SetCursorLock(false);
    SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
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
