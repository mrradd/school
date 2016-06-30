
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
    public int  getNumber    ()           { return number;               }
    public void setQuantity  (int qty)    { quantity   += qty;           }
    public void setTotalValue(double val) { totalValue = val * quantity; }
    
    /** Prints data about the product. **/
    public void print()
      {
      String s = String.format("Product %d: %.2f", number, totalValue);
      System.out.println(s);
      }
    }
  }