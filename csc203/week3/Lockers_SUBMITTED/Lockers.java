
/*******************************************************************************
* Conrad Horton 
* CSC203 June 2016
* Locker Puzzle
* 20160703
*******************************************************************************/
package rad;

/*******************************************************************************
* Class Lockers */
/**
* Locker puzzle.
*******************************************************************************/
class Lockers
  {
  /*******************************************************************************
  * main */
  /**
  *******************************************************************************/  
  public static void main(String args[])
    {
    /** Default to false. **/
    boolean lockers[] = new boolean[101];
    
    /** Loop through students. **/
    for (int i = 1; i <= 100; i++)
      
      /** Loop through lockers. **/
      for (int j = i; j <= 100; j += i)
        lockers[j] = !lockers[j];
    
    /** Print locker if it is open. **/
    for (int i = 0; i < lockers.length; i++)
      if (lockers[i])
        System.out.println("L" + (i)+ " is open.");
    }
  }