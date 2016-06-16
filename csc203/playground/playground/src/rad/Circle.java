package rad;

import java.util.Scanner;

public class Circle
  {
  
  /*****************************************************************************
  * Conrad Horton
  * CSC203 - June 2016
  * Week1 Lab1: Post-Lab
  * 20160615
  ******************************************************************************
  * Post-Lab 
  * 1. Write an application that inputs from the user the radius of a circle as
  * an integer and prints the circle’s diameter, circumference and area using
  * the floating-point value 3.14159 for π. [Note: You may also use the
  * predefined constant Math.PI for the value of π. This constant is more
  * precise than the value 3.14159. Class Math is defined in package java.lang.
  * Classes in that package are imported automatically, so you do not need to
  * import class Math to use it.] Use the following formulas (r is the radius):
  *  
  * diameter = 2r circumference = 2πr area = πr2
  * 
  * Do not store the results of each calculation in a variable. Rather, specify
  * each calculation as the value that will be output in a System.out.printf
  * statement. Note that the values produced by the circumference and area
  * calculations are floating-point numbers. Such values can be output with the
  * format specifier %f in a System.out.printf statement.
  *****************************************************************************/
  public static void main(String[] args)
    {
    /** Get user input. */
    System.out.println("Enter the radius of a circle...");
    Scanner input = new Scanner(System.in);
    
    /** Parse float. */
    String inputStr = input.next();
    Float  radius   = Float.parseFloat(inputStr);
    
    System.out.printf("Diameter     : %f\n", (2 * radius));
    System.out.printf("Circumference: %f\n", (2 * Math.PI * radius));
    System.out.printf("Area         : %f\n", ((Math.PI * Math.pow(radius,2))));
    }
  
  }
