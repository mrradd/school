
/*******************************************************************************
* Conrad Horton
* Time2 Test Class
*******************************************************************************/
package rad;

import java.util.Scanner;

class Time2Test
  {
  public static void main (String[] args)
    {
    int  stdIn = -1;
    Scanner input = new Scanner(System.in);
    boolean quit  = false;
    Time2   t     = new Time2();
    
    /** Main loop. **/
    do
      {
      try
        {
        /** Menu. **/
        Utils.print("\n\n%s\n%s\n%s\n%s\n%s\n%s", "1. Set Hour", "2. Set Minute",
          "3. Set Second", "4. Add 1 Second", "5. Exit", "Choice: ");
        stdIn = input.nextInt();
      
        switch(stdIn)
          {
          case 1:
            Utils.print("Enter hours: ");
            t.setHours(input.nextInt());
            break;
          case 2:
            Utils.print("Enter Minutes: ");
            t.setMinutes(input.nextInt());
            break;
          case 3:
            Utils.print("Enter Seconds: ");
            t.setSeconds(input.nextInt());
            break;
          case 4:
            t.tick();
            break;
          case 5:
              quit = true;
            break;
          }
        
        /** Print Time2 object. **/
        if (!quit)
          Utils.print(t.toString());
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
