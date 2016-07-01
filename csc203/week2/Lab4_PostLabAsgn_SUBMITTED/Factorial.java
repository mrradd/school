
/*****************************************************************************
* Conrad Horton
* CSC203 June 2016
* Post Lab4 Assignment Factorial
* 20160625
******************************************************************************/
package rad;

class Factorial
  {
  /** Calculates the factorial recursively. **/
  public int calculate(int num)
    {
    int n = num - 1;
    
    if (num <= 0)
      return 1;
    
    return num * calculate(n);
    }
  
  public static void main (String[] args)
    {
    Factorial f = new Factorial();
    
    /** Iterate while calculating n! recursively and printing the result. */
    for (int i = 1; i <= 5; i++)
      System.out.printf("%d\t%d\n", i, f.calculate(i));
    
    //The n! of 20 is larger than int32 can hold and throws an Exception.
    }
  }