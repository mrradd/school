using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

/****************************************************************************
* StartSceneManager */ 
/**
* Singleton class which manages the Start Scene.
****************************************************************************/
public class StartSceneManager : MonoBehaviour
  {
  public Button startGameButton;

  protected static StartSceneManager mInstance;

  /** Returns an instance of StartSceneManager. */
  public StartSceneManager instance
    {
    get
      {
      if(mInstance == null)
        mInstance = new StartSceneManager();

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
  * Methods 
  **************************************************************************/
  /**************************************************************************
  * Constructor */ 
  /**
  **************************************************************************/
  protected StartSceneManager()
    {
    }

  /**************************************************************************
  * getInstance */ 
  /**
  * Returns an instance of StartSceneManager.
  **************************************************************************/
  public static StartSceneManager getInstance()
    {
    if(mInstance == null)
      mInstance = new StartSceneManager();
    
    return mInstance;
    }

  /**************************************************************************
  * loadMainGame */ 
  /**
  * UnityEvent that is triggered when the button is pressed. Loads the Main
  * Game Scene.
  **************************************************************************/
  public void loadMainGameScene()
    {
    SceneManager.LoadScene("MainGameScene", LoadSceneMode.Single);
    }
  }
