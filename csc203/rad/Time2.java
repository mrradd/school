
/*******************************************************************************
* Conrad Horton
* CSC203 June 2016
* Classes and Objects Lab Part 3
* 20160706
*******************************************************************************/
package rad;

import java.sql.Time;
import java.util.Scanner;

class Time2
  {
  private int h;
  private int m;
  private int s;
  
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
    this(t.h, t.m, t.s);
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
    
    }
  
  public String toString()
    {
    
    return "";
    }
  
  public static void main (String[] args)
    {
    String  stdIn  = "";
    Scanner input = new Scanner(System.in);
    boolean quit  = false;
    Time2 t = new Time2();
    
    /** Main loop. **/
    do
      {
      /** Menu. **/
      Utils.print("%s\n%s\n%s\n%s\n%s\n%s", "1. Set Hour", "2. Set Minute",
        "3. Set Second", "4. Add 1 Second", "5. Exit", "Choice: ");
      stdIn = input.next();
      
      Utils.print("Enter minutes: ");
      stdIn = input.next();
      
      //Print object data
      //Print HH:MM:SS, print (H)H:MM:SS AM/PM.
      Utils.print(t.toString());
      }
    while (!quit);
    }
  }
