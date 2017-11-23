using UnityEngine;
using System.Collections;

/**************************************************************************
* Movable */ 
/**
* Base class for all game assets.
**************************************************************************/
public abstract class Thing : MonoBehaviour
  {
  public float speed;
  protected abstract void move();
  public abstract void kill();
  }

