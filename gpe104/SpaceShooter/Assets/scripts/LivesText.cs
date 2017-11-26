using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**************************************************************************
* LivesText */ 
/**
* Text object for which depicts the Player's lives remaining.
**************************************************************************/
public class LivesText : MonoBehaviour
  {

  /** Text object. */ protected Text mText;

  /**************************************************************************
  * Awake */ 
  /**
  **************************************************************************/
  public void Awake ()
    {
    mText = gameObject.GetComponent<Text>();
    }
  
  /************************************************************************
  * updateLives */ 
  /**
  * Updates the text.
  * @param  value  Value to update display with.
  ************************************************************************/
  public void updateLivesRemaining(int value)
    {
    mText.text = "Lives: " + value;
    }
  }
