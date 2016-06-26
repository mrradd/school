
/*****************************************************************************
* Conrad Horton
* CSC203 June 2016
* Post Lab4 Assignment
* 20160625
******************************************************************************/
package rad;
class Factorial
  {
  int nFac[];
  public int calculate(int num)
    {
    int n = num - 1;
    
    if (n <= 0)
      return 1;
    
    return num * calculate(num - 1);
    }
  public static void main (String[] args)
    {
    Factorial f = new Factorial();
    System.out.println(f.calculate(20));
    }
  }