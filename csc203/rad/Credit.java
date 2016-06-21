/*****************************************************************************
* Conrad Horton
* CSC203 June 2016
* Week2 Lab3 Part3: Credit
* 20160621
******************************************************************************
* Develop a Java application that will determine whether any of several
* department-store customers has exceeded the credit limit on a charge account.
*****************************************************************************/

package rad;

import java.util.Scanner;

public class Credit
  {
  
  /*****************************************************************************
  * CalculateBalance */
  /**
  * Asks the user to enter various pieces of data about a credit card then
  * checks to see if the user if over the limit. This is done in a loop until
  * the user quits.
  *****************************************************************************/
  public void calculateBalance()
    {
    Scanner input = new Scanner(System.in);
    int account;
    int charges;
    int creditLimit;
    int credits;
    int newBalance;
    int oldBalance;
    
    /*-------------------------------------------*/
    /* User enters account info until they quit. */
    /*-------------------------------------------*/
    do
      {
      account     = 0;
      charges     = 0;
      creditLimit = 0;
      credits     = 0;
      newBalance  = 0;
      oldBalance  = 0;
      
      /*-----------------------------------------------------------------------*/
      /* Scanner nextInt() will go into an infinite loop if a string with no   */
      /* number is enterred. Since this is an exception, we catch it, clear    */
      /* out the Scnaner with nextLine(), and start the input loop over again. */
      /*-----------------------------------------------------------------------*/
      try
        {  
        System.out.println("Enter an account number, or -1 to quit...");
        account = input.nextInt();
        
        if (account != -1)
          {
          /*-------------------*/
          /* Gather some info. */
          /*-------------------*/
          System.out.println("Enter current balance...");
          oldBalance  = input.nextInt();
          
          System.out.println("Enter total charges...");
          charges     = input.nextInt();
          
          System.out.println("Enter total credits...");
          credits     = input.nextInt();
          
          System.out.println("Enter credit limit...");
          creditLimit = input.nextInt();
  
          /*------------------------*/
          /* Calculate new balance. */
          /*------------------------*/
          newBalance = oldBalance + charges - credits; 
          System.out.printf("\nNew balance is: %d\n", newBalance);
          
          /*------------------------------*/
          /* Print credit limit exceeded. */
          /*------------------------------*/
          if (newBalance > creditLimit) 
            System.out.println("\nCredit limit exceeded.");
          }
        }
      catch(Exception e)
        {
        System.out.println("\nBad input. Starting over.\n");
        input.nextLine();
        continue;
        }
      
      }while(account != -1);
    }
  
  
  /*------------*/
  /* TEST MAIN. */
  /*------------*/
  public static void  main(String args[])
    {
    Credit cr = new Credit();
    cr.calculateBalance();
    }
  }