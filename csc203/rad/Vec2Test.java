
/*******************************************************************************
* Conrad Horton
*******************************************************************************/
package rad;

import java.util.Scanner;

/*******************************************************************************
* Class Vec2Test */
/**
* Test class for Vec2
*******************************************************************************/
class Vec2Test
  {
  public static void main (String[] args)
    {
    Scanner input = new Scanner(System.in);
    Vec2 v1;
    Vec2 v2;
    
    boolean quit = false;
    double x = 0.0;
    double y = 0.0;
    
    System.out.println("Let's calculate the Distance between to Points!");
    while(!quit)
      {
      System.out.println("First Point: ");
      System.out.print("X1 = ");
      x = input.nextDouble();
      System.out.print("\nY1 = ");
      y = input.nextDouble();
      v1 = new Vec2(x,y);

      System.out.println("Second Point: ");
      System.out.print("X2 = ");
      x = input.nextDouble();
      System.out.print("\nY2 = ");
      y = input.nextDouble();
      v2 = new Vec2(x,y);
      
      v1.distance(v2);
      
      /** Check for EOT character. **/
      System.out.println("Type ctrl+z (win) or ctrl+d(*nix) t.");
      System.out.println("Or hit enter to continue.");
      if(!input.hasNextLine())
        quit = true;
      }
    }
  }