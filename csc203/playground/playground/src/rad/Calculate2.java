package rad;

import java.util.Scanner;

public class Calculate2
  {
  /*****************************************************************************
  * Conrad Horton
  * CSC203
  * June 2016
  * Week1 Lab1 Part4: Calculate2
  * 20160615
  ******************************************************************************
  * Write an application that inputs three integers from the user and displays
  * the sum, average, product, smallest and largest of the numbers. [Note: The
  * calculation of the average in this exercise should result in an integer
  * represen- tation of the average. So if the sum of the values is 7, the
  * average should be 2, not 2.3333....]
  *****************************************************************************/
  public static void main(String[] args)
    {
    int average  = 0;
    int largest  = 0;
    int product  = 1;
    int smallest = 0;
    int sum      = 0;
        
    System.out.println("Enter 3 integers.");
    Scanner input = new Scanner(System.in);

    /** Loop through the input string, validate and capture the values. */
    String  inputStr;
    Integer nums[] = { 0,0,0 };
    for (int i = 0; i < 3; i++)
      {
      inputStr = input.next();
      nums[i]  = Integer.parseInt(inputStr);
      }
    
    /** Do the math. */
    largest  = nums[0];
    smallest = nums[0];
    for (int j = 0; j <= 2; j++)
      {
      sum     += nums[j];
      product *= nums[j];
      
      largest  = largest  < nums[j] ? nums[j] : largest; 
      smallest = smallest > nums[j] ? nums[j] : smallest;
      
      average += nums[j];
      if (j >= 2)
        average /= j+1;
      }
    
    System.out.println(String.format("Integers: %d, %d, %d", nums[0], nums[1], nums[2]));
    System.out.println(String.format("Sum     : %d", sum));
    System.out.println(String.format("Product : %d", product));
    System.out.println(String.format("Average : %d", average));
    System.out.println(String.format("Largest : %d", largest));
    System.out.println(String.format("Smallest: %d", smallest));
    }
  }
