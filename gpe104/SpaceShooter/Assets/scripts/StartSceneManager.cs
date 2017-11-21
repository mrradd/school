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
  public int    mainGameSceneIndex;

  protected static StartSceneManager mInstance;

  /**************************************************************************
  * Unity Methods 
  **************************************************************************/
  /*
  public void Awake()
    {
    if(!instance)
      instance = this;
    else
      {
      Debug.LogError("ERROR: There can only be one MainGameSceneManager.");
      Destroy(gameObject);
      }
    }
  */

  /**************************************************************************
  * Start */ 
  /**
  **************************************************************************/
  public void Start ()
    {
    startGameButton.GetComponent<Button>().onClick.AddListener(loadMainGameScene);
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
  * 
  * Note: Triggered on MouseUp after MouseDown on the same object.
  * see: https://docs.unity3d.com/ScriptReference/UI.Button-onClick.html
  **************************************************************************/
  protected void loadMainGameScene()
    {
    SceneManager.LoadScene(mainGameSceneIndex);
    }
  }
