using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**************************************************************************
* ScoreText */ 
/**
* Text object for which depicts the Player's score.
**************************************************************************/
public class ScoreText : MonoBehaviour
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
  * updateScore */ 
  /**
  * Updates the score.
  * @param  value  Value to update display with.
  ************************************************************************/
  public void updateScore(int value)
    {
    mText.text = "Score: " + value;
    }
  }
