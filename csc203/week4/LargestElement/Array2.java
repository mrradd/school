
/*******************************************************************************
* Conrad Horton
* CSC203 - June 2016
* Largest Element
* 20160709
*******************************************************************************/

package rad;

import java.util.Scanner;

public class Array2
  {
  /*****************************************************************************
  * locateLargest */
  /**
  * Locates the largest element in a 2D array of doubles.
  *  
  * @param  dubArray  2D array of doubles.
  * @returns the location of the largest element in a two-dimensional array.
  *****************************************************************************/
  public static int[] locateLargest(double[][] dubArray)
    {
    /** Location index of the largest element. **/
    int[] index = {0,0};
    
    /** Get the number of rows, and columns in the array. **/
    int rows    = dubArray.length;
    int columns = dubArray[0].length;
    
    /** Init to arbitrary value. **/
    double large = dubArray[0][0];
    
    /** Loop through passed in array to find the largest element. **/
    for (int r = 0; r < rows; r++)
      for (int c = 0; c < columns; c++)
        /** Check element for size. **/
        if (dubArray[r][c] > large)
          {
          large = dubArray[r][c];
          index[0] = r;
          index[1] = c;
          }
    
    return index;
    }
  
  public static void main( String args[])
    {
    Scanner input = new Scanner(System.in);
    int rows      = 0;
    int columns   = 0;
    
    Utils.print("Enter a number of rows and columns of the array: ");
    rows    = input.nextInt();
    columns = input.nextInt();
    
    /** Make a double[][] and load user input. **/
    double[][] doubleArray = new double[rows][columns];
    Utils.print("Time to enter some floating point numbers!\n");
    for (int r = 0; r < rows; r++)
      for (int c = 0; c < columns; c++)
        {
        Utils.print("\n[%d][%d] =  ", r, c);
        double d          = input.nextDouble();
        doubleArray[r][c] = d;
        }
    
    /** Find the largest element. **/
    Utils.print("The largest element is... ");
    int[] results = Array2.locateLargest(doubleArray);
    Utils.print("[%d][%d] =  %.2f\n", results[0],results[1],doubleArray[results[0]][results[1]]); 
    input.close();
    }
  }
