
/*******************************************************************************
* Conrad Horton
* CSC203 June 2016
* Classes and Objects Lab Part 3
* 20160706
*******************************************************************************/
package rad;

class Time2
  {
  private int mHours;
  private int mMinutes;
  private int mSeconds;
  
  /*****************************************************************************
  * CTOR */
  /** 
  *****************************************************************************/
  public Time2()
    {
    this(0,0,0);
    }
  /** 
  * @param  h  Hours. 
  *****************************************************************************/
  public Time2(int h)
    {
    this(h,0,0);
    }
  /** 
  * @param  h  Hours. 
  * @param  m  Minutes.
  *****************************************************************************/
  public Time2(int h, int m)
    {
    this(h,m,0);
    }
  /** 
  * @param  h  Hours. 
  * @param  m  Minutes.
  * @param  s  Seconds.
  *****************************************************************************/
  public Time2(int h, int m, int s)
    {
    setTime(h,m,s);
    }
  /** 
  * @param  t  Time2 object.
  *****************************************************************************/
  public Time2(Time2 t)
    {
    this(t.mHours, t.mMinutes, t.mSeconds);
    }

  /*****************************************************************************
  * setHours */
  /** 
  * @param  h  Hours. 
  *****************************************************************************/
  public void setHours(int h)
    {
    mHours = h >= 0 && h < 24 ? h : 0;
    }
  
  /*****************************************************************************
  * setMinutes */
  /** 
  * @param  m  Minutes.
  *****************************************************************************/
  public void setMinutes(int m)
    {
    mMinutes = m >= 0 && m < 60 ? m : 0;
    }
  
  /*****************************************************************************
  * setSeconds */
  /** 
  * @param  s  Seconds.
  *****************************************************************************/
  public void setSeconds(int s)
    {
    mSeconds = s >= 0 && s < 60 ? s : 0;
    }
  
  /*****************************************************************************
  * setTime */
  /** 
  * Sets the hours minutes and seconds of the Time2 instance.
  *  
  * @param  h  Hours. 
  * @param  m  Minutes.
  * @param  s  Seconds.
  *****************************************************************************/
  public void setTime(int h, int m, int s)
    {
    setHours  (h);
    setMinutes(m);
    setSeconds(s);
    }

  /*****************************************************************************
  * tick */
  /** 
  * Increment seconds by 1. Adjust minutes and hours accordingly.
  *****************************************************************************/
  public void tick()
    {
    /** If seconds will hit 60, increment minutes. **/
    boolean flipMins = mSeconds == 59;
    
    /** If minutes will flip to 60, flip the hours. **/
    boolean flipHrs  = mMinutes == 59 && flipMins;
    
    /** Tick seconds stuff. **/
    setSeconds(mSeconds + 1);
    
    /** Tick minutes. **/
    if (flipMins)
      setMinutes(mMinutes + 1);
    
    /** Tick hours. **/
    if (flipHrs)
      setHours  (mHours + 1);
    }
  
  /** toString overload. **/
  public String toString()
    {
    
    String meridian = mHours >= 12 ? "PM" : "AM";
    
    /** Stringify hours, add leading 0 for universal. **/
    String h        = String.format("%d", mHours > 12 ? mHours - 12 : mHours == 0 ? 12 : mHours);
    String uh       = (mHours   < 10 ? "0" : "") + mHours;
    
    /** Minutes. **/
    String m        = (mMinutes < 10 ? "0" : "") + mMinutes;
    
    /** Seconds. **/
    String s        = (mSeconds < 10 ? "0" : "") + mSeconds;
    
    /** Time **/
    String t        = h  + ":" + m + ":" + s + meridian;
    String ut       = uh + ":" + m + ":" + s;
    
    return "Universal Time: " + ut + "\tStandard Time: " + t;
    }
  }
