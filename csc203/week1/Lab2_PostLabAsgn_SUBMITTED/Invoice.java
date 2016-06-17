
package rad;
import java.util.Scanner;

/*******************************************************************************
* Conrad Horton
* CSC203
* June 2016
* Week1 Lab2: Post-Lab
* 20160615
********************************************************************************
* Create a class called Invoice that a hardware store might use to represent an
* invoice for an item sold at the store. An Invoice should include four pieces
* of information as instance variables part number (type String), a part
* description (type String), a quantity of the item being purchased (type int)
* and a price per item (double). Your class should have a constructor that
* initializes the four instance variables. Provide a set and a get method for
* each instance variable. In addition, provide a method named getInvoiceAmount
* that calculates the invoice amount (i.e., multiplies the quantity by the price
* per item), then returns the amount as a double value. If the quantity is not
* positive, it should be set to 0. If the price per item is not positive, it
* should be set to 0.0. Write a test application named InvoiceTest that
* demonstrates class Invoices capabilities.
*******************************************************************************/
public class Invoice
  {
  private String partDescription;
  private String partNumber;
  private double priceOfItem;
  private int    qtyPurchased;
  
  //CTOR.
  public Invoice(String desc, String num, int qty, float price)
    {
    setPartNumber     (num);
    setPartDescription(desc);
    setQtyPurchased   (qty);
    setPriceOfItem    (price);
    }

  /** Calculate invoice amount. */
  public double getInvoiceAmount()
    { return priceOfItem * qtyPurchased; }
  
  /** get/set Part Description. */
  public String getPartDescription()
    { return partDescription; }
  public void   setPartDescription(String desc)
    { partDescription = desc; }
  
  /** get/set  Part Number. */
  public String getPartNumber()
    { return partNumber; }
  public void   setPartNumber(String number)
    { partNumber = number; }
  
  /** get/set Price of item. */
  public double getPriceOfItem()
    { return priceOfItem;     }
  public void   setPriceOfItem(double poi)
    { priceOfItem = poi > 0 ? poi : 0.0; }
  
  /** get/set Quantity Purchased. */
  public int  getQtyPurchased ()
    { return qtyPurchased;}
  public void setQtyPurchased (int qty)
    { qtyPurchased = qty > 0 ? qty : 0; }
  }

