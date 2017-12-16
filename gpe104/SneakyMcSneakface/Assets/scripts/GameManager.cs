using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;
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
  /** Player found. */        public bool    found = false;

  /** Initial spawn location. */ protected Vector3 mStartPoint;

  public GameObject player;
  public GameObject menuCamera;
  public GameObject menuCanvas;

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
        instance.godMode = !instance.godMode;

      /** God Mode activated. */
      if(instance.godMode)
        {
        /** Teleport player to last checkpoint. */
        if(Input.GetKeyDown(KeyCode.P))
          {
          respawnFromLastCheckpoint();
          }
        }

      /** Player lost. */
      if(instance.playerLives < 1)
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
    Debug.Log("loadGameOverScene");
    loadScene("GameOverScene");
    }

  /**************************************************************************
  * loadMainGameScene */ 
  /**
  * Loads the Main Game Scene.
  **************************************************************************/
  public void loadMainGameScene()
    {
    Debug.Log("loadMainGameScene");
    loadScene("MainGameScene");
    restart();
    }
  
  /**************************************************************************
  * loadMainMenuScene */ 
  /**
  * Loads the Main Menu Scene.
  **************************************************************************/
  public void loadMainMenuScene()
    {
    Debug.Log("loadMainMenuScene");
    loadScene("MainMenuScene");
    }

  /**************************************************************************
  * loadScene */ 
  /**
  * Loads the passed in Scene name, and turns on the mouse.
  * @param  sceneName  Scene name to load.
  **************************************************************************/
  public void loadScene(string sceneName)
    {

    if(GameObject.Find("FPSController") != null)
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
    Debug.Log("loadWinScene");
    loadScene("WinScene");
    }

  /**************************************************************************
  * loseLife */
  /**
  * Makes the player lose a life.
  **************************************************************************/
  public void loseLife()
    {
    if(!godMode)
      {
      instance.playerLives--;
      Debug.Log("loseLife: " + instance.playerLives);
      GameObject.Find("FPSController").GetComponent<FirstPersonController>().mouseLook.SetCursorLock(false);
      instance.player.SetActive(false);
      instance.menuCamera.SetActive(true);
      }
    }

  /**************************************************************************
  * respawnFromLastCheckpoint */ 
  /**
  * Moves the player to the last checkpoint.
  **************************************************************************/
  public void respawnFromLastCheckpoint()
    {
    Debug.Log("respawnFromLastCheckpoint");
    GameManager.instance.found = false;

    player.SetActive(true);
    menuCamera.SetActive(false);

    GameObject.Find("FPSController").GetComponent<FirstPersonController>().mouseLook.SetCursorLock(true);
    GameObject.Find("FPSController").gameObject.transform.position = instance.lastCheckPoint;

    }

  /**************************************************************************
  * restart */ 
  /**
  * Restart the game.
  **************************************************************************/
  public void restart()
    {
    Debug.Log("restart");

    GameObject g = GameObject.Find("FPSController");

    if(g != null)
      {
      GameObject.Find("FPSController").GetComponent<FirstPersonController>().mouseLook.SetCursorLock(true);
      GameObject.Find("FPSController").gameObject.transform.position = instance.mStartPoint;
      }
    
    instance.hasPinkKey = instance.hasTheObject = instance.hasWhiteKey = instance.hasYellowKey = false;
    instance.playerLives = 3;
    GameManager.instance.found = false;
    }
  }
