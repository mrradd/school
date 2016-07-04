
/*******************************************************************************
* Conrad Horton
* CSC203 June 2016
* Post Lab5 Airline
* 20160703
*******************************************************************************/
package rad;

import java.util.Scanner;

class Airline
  {
  private boolean[] mSeats;
  private int       mChoice;
  private int       mFirstClassCounter;
  private int       mEconoClassCounter;

  /*****************************************************************************
  /* CTOR */
  /**
  *****************************************************************************/
  public Airline()
    {
    mSeats = new boolean[10];
    for (int i = 0; i < mSeats.length; i++)
      mSeats[i] = true;
    }

  /*****************************************************************************
  /* checkAvailable */
  /**
  * Checks if there is a seat available.
  * @param  clazz  Class to check available seating.
  *****************************************************************************/
  public int checkAvailable(int clazz)
    {
    int seat = -1;
    
    /** First class. **/
    if (clazz == 1)
      {
      for (int i = 0; i < 5; i++)
        if (mSeats[i])
          {
          mSeats[i] = false;
          seat = i+1;
          mFirstClassCounter++;
          break;
          }
      }
    
    /** Economy class. **/
    else
      {
      for (int i = 5; i < 10; i++)
        if (mSeats[i])
          {
          mSeats[i] = false;
          seat = i+1;
          mEconoClassCounter++;
          break;
          }
      }
    return seat;
    }
  
  /*****************************************************************************
  /* menu */
  /**
  * Handles the menu.
  *****************************************************************************/
  public void menu()
    {
    while (mFirstClassCounter < 5 || mEconoClassCounter < 5)
      {
      Scanner input = new Scanner(System.in);
      System.out.println("\n\n[1] For First Class.\n[2] For Economy Class.");
      mChoice       = input.nextInt();
      int seat      = checkAvailable(mChoice);
      
      /** Try to assign a seat. **/
      if (seat == -1)
        {        
        int altChoice = 0;

        /** Bump to Economy. **/
        if (mChoice == 1 && mEconoClassCounter < 5)
          {
          System.out.println("First Class is full. Would you like to try Economy?");
          System.out.print("[1] Yes. [2] No.");
          altChoice = input.nextInt();
          
          /** User wants new seat in economy. Change choice. **/
          if (altChoice == 1)
            {
            mChoice = 2;
            seat    = checkAvailable(mChoice);
            }
          }
        
        /** Bump to First. **/
        if (mChoice == 2 && mFirstClassCounter < 5)
          {
          System.out.println("Economy Class is full. Would you like to try First?");
          System.out.print("[1] Yes. [2] No.");
          altChoice = input.nextInt();
          
          /** User wants new seat in first. Change choice. **/
          if (altChoice == 1)
            {
            mChoice = 1;
            seat    = checkAvailable(mChoice);
            }
          }
        }

      /** Print out first choice or alternate choice seats. **/
      if (seat > 0)
        {
        if (mChoice == 1)
          System.out.println("First Class: Seat# " + seat);
        else if (mChoice == 2)
          System.out.println("Economy Class: Seat# " + seat);        
        }
      else
        System.out.println("Next flight is in 3 hours.");
      }
    
    System.out.println("Plane is all booked! No more seats available!");
    }
  
  public static void main (String[] args)
    {
    Airline a = new Airline();
    a.menu();
    }
  }