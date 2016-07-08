
/*******************************************************************************
* Conrad Horton
* Rectangle Test Class
*******************************************************************************/
package rad;

import java.util.Scanner;

class RectangleTest
  {
  public static void main (String[] args)
    {
    int       stdIn = -1;
    Scanner   input = new Scanner(System.in);
    boolean   quit  = false;
    Rectangle r     = new Rectangle();
    
    /** Main loop. **/
    do
      {
      try
        {
        /** Menu. **/
        Utils.print("\n\n%s\n%s\n%s\n%s", "1. Set Length", "2. Set Width",
          "3. Exit", "Choice: ");
        stdIn = input.nextInt();
      
        switch(stdIn)
          {
          case 1:
            Utils.print("Enter Length: ");
            r.setLength(input.nextInt());
            break;
          case 2:
            Utils.print("Enter Width: ");
            r.setWidth(input.nextInt());
            break;
          case 3:
              quit = true;
            break;
          }
        
        /** Print Rectangle object. **/
        if (!quit)
          Utils.print(r.toString());
        }
      
      /** Prevent crit failure. **/
      catch(Exception e)
        {
        System.err.println("Woops! " + e.getMessage());
        input.close();
        }
      }
    while (!quit);
    }
  }
