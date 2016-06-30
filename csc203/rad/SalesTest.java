
/******************************************************************************
* Conrad Horton
* CSC203 June 2016
* Lab4 Part3 Sales
* 20160621
*******************************************************************************
* Test program for the Sales class.
*******************************************************************************/
package rad;

import java.util.Scanner;

public class SalesTest
  {
  /*****************************************************************************
  * main */
  /***
  *****************************************************************************/
  public static void main (String[] args)
    {
    Sales s         = new Sales();
    Scanner input   = new Scanner(System.in);
    
    /** List of product objects. **/
    Sales.Product prods[] =
      {
      s.new Product(1),
      s.new Product(2),
      s.new Product(3),
      s.new Product(4),
      s.new Product(5)
      };

    
    /** Screen prompts for user. **/
    String  prodPrompt = "\nEnter product number (1-5) (0 to stop): ";
    String  qtyPrompt  = "\nEnter quantity sold: ";
    
    /*---------------------------------------------------------------*/
    /* Main loop to take user entries, and calculate product values. */
    /*---------------------------------------------------------------*/
    int userEntry = 0;
    do
      {
      /*-------------------------*/
      /* Request product number. */
      /*-------------------------*/
      System.out.print(prodPrompt);
      userEntry = input.nextInt();
     
      /*------------------------------------------------*/
      /* Find the product, set it's quantity and value. */
      /*------------------------------------------------*/
      for(Sales.Product p : prods)
        if (p.getNumber() == userEntry)
          {
          /*----------------------------------*/
          /* Request number of Products sold. */
          /*----------------------------------*/
          System.out.print(qtyPrompt);
          p.setQuantity(input.nextInt());
          
          /*-----------------------------------------------------*/
          /* Set the value of the item based on the item number. */
          /*-----------------------------------------------------*/
          switch(p.getNumber())
            {
            case 1: p.setTotalValue(2.98); break;
            case 2: p.setTotalValue(4.50); break;
            case 3: p.setTotalValue(9.98); break;
            case 4: p.setTotalValue(4.49); break;
            case 5: p.setTotalValue(6.87); break;
            }
          }

      /*------------------*/
      /* Clear the input. */
      /*------------------*/
      input.nextLine();
      }
    while(userEntry > 0);
    
    /*-------------------------*/
    /* Print out product data. */
    /*-------------------------*/
    for(int i = 0; i < prods.length; i++)
      prods[i].print();
    
    input.close();
    }
  }