
/*******************************************************************************
* Conrad Horton
* CSC203 June 2016
* Lab 6 - Craps
* 20160702
*******************************************************************************/
package rad;

import java.util.HashMap;
import java.util.Map;
import java.util.Random;

/*******************************************************************************
* Class Craps */
/**
* Simulate craps game.
*******************************************************************************/
class Craps
  {
  private enum   State { WIN, LOSE, PLAY };

  private Random mD6;
  private State  mGameState;
  private int    mLosses;
  private int    mPoint;
  private int    mRollCount;
  private int    mRollResult;
  private int    mTotalRolls;
  private int    mWins;
  private Map<Integer,Integer>mWinLog;
  private Map<Integer,Integer>mLossLog;
  
  
  /*****************************************************************************
  * CTOR */
  /**
  *****************************************************************************/
  public Craps()
    {
    mD6        = new Random();

    mPoint     = 0; 
    mLosses    = 0;
    mRollCount = 0;
    mWins      = 0;
    mWinLog    = new HashMap<Integer, Integer>();
    mLossLog   = new HashMap<Integer, Integer>();
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
      mGameState = State.PLAY;
      /** First roll. Win on 7 or 11. Lose on 2, 3, or 12. **/
      mRollCount   = 0;
      mPoint       = roll();
      Integer iObj = new Integer(mRollCount);
      
      switch(mPoint)
        {
        case(7) :
        case(11):
          mGameState = State.WIN;
          mWins++;
          updateWinLog(iObj);
          break;
        case(2) :
        case(3) :
        case(12):
          mGameState = State.LOSE;
          mLosses++;
          updateLossLog(iObj);
          break;
        }
      
      /** Roll until Win or Lose. **/
      while (mGameState == State.PLAY)
        {
        mRollResult = roll();
        iObj = new Integer(mRollCount);
        
        /** Win. **/
        if (mRollResult == mPoint)
          {
          mGameState = State.WIN;
          mWins++;
          updateWinLog(iObj);
          }
        
        /** Craps. **/
        else if (mRollResult == 7)
          {
          mGameState = State.LOSE;
          mLosses++;
          updateLossLog(iObj);
          } 
        }
      }
    
    printResults();
    }

  /*****************************************************************************
  * prtintResults */
  /**
  * Prints the win loss results.
  *****************************************************************************/
  public void printResults()
    {
    int sumWinsAfterRoll20 = 0;
    int sumLossAfterRoll20 = 0;
    
    for(int i = 1; i <= Math.max (20, Math.max(mWinLog.size(), mLossLog.size())); i++)
      {
      if (i <= 20)
        {
        int wins   = mWinLog .containsKey(i) ? mWinLog .get(i).intValue() : 0;
        int losses = mLossLog.containsKey(i) ? mLossLog.get(i).intValue() : 0;
        System.out.println("Roll #" + i + ": " + wins + " games won. " + losses + " games lost." );
        }
      else
        {
        sumWinsAfterRoll20 += mWinLog .containsKey(i) ? mWinLog .get(i).intValue() : 0;
        sumLossAfterRoll20 += mLossLog.containsKey(i) ? mLossLog.get(i).intValue() : 0;
        }
      }
    
    System.out.println("\nAfter roll 20: " + sumWinsAfterRoll20 + " games won. " + sumLossAfterRoll20 + " games lost." );
    System.out.println("Chances of winning: " + mWins + "/1000 or " + (((float)mWins/1000)*100) + "%.");
    System.out.println("Average rolls per game: " + (((float)mTotalRolls/1000)));
    }
  
  /*****************************************************************************
  * roll */
  /**
  * Roll 2 D6. Sets the current point value.
  *****************************************************************************/
  public int roll()
    {
    mRollCount ++;
    mTotalRolls++;
    return 2 + mD6.nextInt(6) + mD6.nextInt(6); 
    }

  /*****************************************************************************
  * updateLossLog */
  /**
  * Updates the Loss Log.
  * 
  * @param  iObj  Integer object to use as the key.
  *****************************************************************************/
  public void updateLossLog(Integer iObj)
    {
    /** Find the key for the number of rolls, and increment it. If it does
    not exist, make a new entry where the roll is the key. **/
    if(!mLossLog.containsKey(iObj))
      mLossLog.put(iObj, new Integer(1));
    
    /** Update the value at the key. **/
    else
      {
      int val = mLossLog.get(iObj).intValue();
      mLossLog.replace(iObj, val, new Integer(++val));
      }
    }
  
  /*****************************************************************************
  * updateWinLog */
  /**
  * Updates the Win Log.
  * @param  iObj  Integer object to use as the key.
  *****************************************************************************/
  public void updateWinLog(Integer iObj)
    {
    /** Find the key for the number of rolls, and increment it. If it does
    not exist, make a new entry where the roll is the key. **/
    if(!mWinLog.containsKey(iObj))
      mWinLog.put(iObj, new Integer(1));
    
    /** Update the value at the key. **/
    else
      {
      int val = mWinLog.get(iObj).intValue();
      mWinLog.replace(iObj, val, new Integer(++val));
      }
    }
  }