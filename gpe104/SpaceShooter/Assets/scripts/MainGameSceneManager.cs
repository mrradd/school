using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/****************************************************************************
* MainGameSceneManager */ 
/**
* Singleton class to manage the main game scene.
****************************************************************************/
public class MainGameSceneManager : MonoBehaviour
  {
  protected static MainGameSceneManager mInstance;

  /****************************************************************************
  * Unity Methods 
  ****************************************************************************/
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

  /****************************************************************************
  * Start */ 
  /**
  ****************************************************************************/
	public void Start ()
    {
		
	  }
	
  /****************************************************************************
  * Update */ 
  /**
  ****************************************************************************/
	public void Update ()
    {
		
	  }

  /****************************************************************************
  * Methods 
  ****************************************************************************/
  /****************************************************************************
  * Constructor */ 
  /**
  ****************************************************************************/
  protected MainGameSceneManager()
    {
    }

  /****************************************************************************
  * getInstance */ 
  /**
  * Returns an instance of MainGameSceneManager.
  ****************************************************************************/
  public static MainGameSceneManager getInstance()
    {
    if(mInstance == null)
      mInstance = new MainGameSceneManager();

    return mInstance;
    }
  }
