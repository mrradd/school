
/*******************************************************************************
* Conrad Horton
* CSC203 June 2016
* Lab 6 - Craps
* 20160702
*******************************************************************************/
package rad;

import java.util.Random;

/*******************************************************************************
* Class Craps */
/**
* Simulate craps game.
*******************************************************************************/
class Craps
  {
  private Random d6;
  private int    losses;
  private int    point;
  private int    rollCount;
  private int    rollResult;
  private int    wins;
  
  
  private enum   State { WIN, LOSE, PLAY };
  private State  gameState;
  
  /*****************************************************************************
  * CTOR */
  /**
  *****************************************************************************/
  public Craps()
    {
    d6        = new Random();
    point     = 0; 
    losses    = 0;
    rollCount = 0;
    wins      = 0;
    gameState = State.PLAY;
    }

  /*****************************************************************************
  * play */
  /**
  * Play some craps.
  *****************************************************************************/  
  public void play()
    {
    /** Play craps 1000 times; **/
    for (int i = 1; i <= 1000; i++)
      {
      
      /** First roll. Win on 7 or 11. Lose on 2, 3, or 12. **/
      point = roll();
      switch(point)
        {
        case(7) :
        case(11): gameState = State.WIN;  break;
        case(2) :
        case(3) :
        case(12): gameState = State.LOSE; break;
        }
      
      /** Roll until Win or Lose. **/
      while (gameState == State.PLAY)
        {
        rollResult = roll();
        if (rollResult == point)
          gameState = State.WIN;
        else if (rollResult == 7)
          gameState = State.LOSE;
        }
      }
    }
  
  /*****************************************************************************
  * roll */
  /**
  * Roll 2 D6. Sets the current point value.
  *****************************************************************************/  
  public int roll()
    {
    rollCount++;
    return 2 + d6.nextInt(6) + d6.nextInt(6); 
    }
  }