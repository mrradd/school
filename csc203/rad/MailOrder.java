
/******************************************************************************
* Conrad Horton
* CSC203 June 2016
* Lab4 Part3 Sales
* 20160621
*******************************************************************************
* A mail-order house sells five products whose retail prices are as follows:
* Product 1, $2.98; product 2, $4.50; product 3, $9.98; product 4, $4.49 and
* product 5, $6.87. Write an application that reads a series of pairs of
* numbers as follows:
* a) product number
* b) quantity sold
* Your program should use a switch statement to determine the retail price for
* each product. It should calculate and display the total retail value of all
* products sold. Use a sentinel-controlled loop to determine when the program
* should stop looping and display the final results.
*******************************************************************************/
package rad;

import java.util.Scanner;

public class Sales
  {
  /*****************************************************************************
  * INTERNAL CLASS Product */
  /***
  * Represents the Product used in the program. 
  *****************************************************************************/
  public class Product
    {
    private int    number;
    private double totalValue;
    private int    quantity;
    
    /***************************************************************************
    * CTOR */
    /***
    * Represents the Product used in the program. 
    * @param  num   Product number.
    * @param  val   Value of the Product.
    ***************************************************************************/
    public Product(int num)
      {
      number    = num;
      quantity  = 0;
      }
    
    /** Setters/Getters **/
    public void setQuantity  (int qty)    { quantity   += qty;           }
    public void setTotalValue(double val) { totalValue = val * quantity; }
    
    /** Prints data about the product. **/
    public void print()
      {
      String s = String.format("Product %d: %.2f", number, totalValue);
      System.out.println(s);
      }
    }
  
  /*****************************************************************************
  * main */
  /***
  *****************************************************************************/
  public static void main (String[] args)
    {
    Sales s         = new Sales();
    Scanner input   = new Scanner(System.in);
    
    /** List of product objects. **/
    Product prods[] =
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
    
    /** Main loop to take user entries, and calculate product values. **/
    int userEntry = 0;
    do
      {
      /** Request product number. **/
      System.out.print(prodPrompt);
      userEntry = input.nextInt();
     
      /** Make sure idex is in range. **/
      if (userEntry - 1 >= 0 && userEntry <= prods.length)
        {
        
        /** Request number of Products sold. **/
        System.out.print(qtyPrompt);
        int index = userEntry- 1;
        prods[index].setQuantity(input.nextInt());
        
        /** Determine the value of the object and calculate new total value. **/
        switch(index)
          {
          case 1: prods[index].setTotalValue(2.98); break;
          case 2: prods[index].setTotalValue(4.50); break;
          case 3: prods[index].setTotalValue(9.98); break;
          case 4: prods[index].setTotalValue(4.49); break;
          case 5: prods[index].setTotalValue(6.87); break;
          }
        }
      /** Clear the input. **/
      input.nextLine();
      }
    while(userEntry > 0);
    
    /** Print out product data. **/
    for(int i = 0; i < prods.length; i++)
      prods[i].print();
    
    input.close();
    }
  }