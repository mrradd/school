
/*******************************************************************************
* Conrad Horton
* CSC203 June 2016
* Assignment Credit Card Validator Test Class
* 20160703
*******************************************************************************/
package rad;

import java.util.Scanner;

class CreditCardTest
  {
  public static void main (String[] args)
    {
    Scanner input = new Scanner(System.in);
    
    System.out.println("Please enter a Credit Card number...");
    long num = input.nextLong();
    
    System.out.println("Checking validity...");   
    System.out.println(new CreditCard(num).isValid() ? "Valid." : "Invalid.");
    
    input.close();
    }
  }



