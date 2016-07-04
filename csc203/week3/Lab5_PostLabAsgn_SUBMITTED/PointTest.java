
/*******************************************************************************
* Conrad Horton
*******************************************************************************/
package rad;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.Scanner;

/*******************************************************************************
* Class PointTest */
/**
* Test class for Vec2
*******************************************************************************/
class PointTest
  {
  public static void main (String[] args)
    {
    Scanner input = new Scanner(System.in);
    Point p1;
    Point p2;
    
    boolean quit = false;
    double x = 0.0;
    double y = 0.0;
    
    System.out.println("Let's calculate the distance between to Points!");
    while(!quit)
      {
      /*-------------------------*/
      /* Create the first point. */
      /*-------------------------*/
      System.out.println("First Point: ");
      System.out.print("X1 = ");
      x = input.nextDouble();
      System.out.print("Y1 = ");
      y = input.nextDouble();
      p1 = new Point(x,y);
      
      x = 0.0;
      y = 0.0;
      
      /*--------------------------*/
      /* Create the second point. */
      /*--------------------------*/
      System.out.println("\nSecond Point: ");
      System.out.print("X2 = ");
      x = input.nextDouble();
      System.out.print("Y2 = ");
      y = input.nextDouble();
      p2 = new Point(x,y);
      
      System.out.printf("Distance =\t%f\n", p1.distance(p2));

      /** Check for EOT character. **/
      try
        {
        System.out.println("\nHit enter to continue.");
        System.out.println("To exit type ctrl+z+enter (win) or ctrl+d+enter (*nix).");
        
        /*-------------------------------------------------------*/
        /* InputStreamReader returns -1 for the EOT. By wrapping */
        /* System.in in an InputStreamReader and feeding it to a */
        /* BufferReader, when the EOT is enterred we should get  */
        /* a result of null as long as EOT had its own line.     */
        /*-------------------------------------------------------*/
        BufferedReader in = new BufferedReader(new InputStreamReader(System.in));
        String s = in.readLine();
        quit = s == null;
        }
      /*-----------------------------------------------------*/
      /* This will prevent crit failure, so we keep looping. */
      /*-----------------------------------------------------*/
      catch(Exception e)
        {
        System.err.println("\nWoops!\n" + e.getMessage());
        }
      
      x = 0.0;
      y = 0.0;
      }
    System.out.println("Good bye");
    input.close();
    }
  }