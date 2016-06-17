
package rad;
import java.util.Formatter;
import java.util.Scanner;

/*******************************************************************************
* For testing Invoice class.
*******************************************************************************/
public class InvoiceTest
  {
  public static void main(String args[])
    {
    Invoice inv1 = new Invoice("Sprocket", "3l33t15t", 3, 9.0f);
    Invoice inv2 = new Invoice("SomethingOrOther", "id10t", 10, 4.0f);
    
    System.out.println("Invoice1");
    System.out.println(String.format("Item  : %s",    inv1.getPartDescription()));
    System.out.println(String.format("Part# : %s",    inv1.getPartNumber()));
    System.out.println(String.format("Qty   : %d",    inv1.getQtyPurchased()));
    System.out.println(String.format("$/item: $%.2f", inv1.getPriceOfItem()));
    System.out.println(String.format("Total : $%.2f", inv1.getInvoiceAmount()));

    System.out.println("\nInvoice2");
    System.out.println(String.format("Item  : %s",    inv2.getPartDescription()));
    System.out.println(String.format("Part# : %s",    inv2.getPartNumber()));
    System.out.println(String.format("Qty   : %d",    inv2.getQtyPurchased()));
    System.out.println(String.format("$/item: $%.2f", inv2.getPriceOfItem()));
    System.out.println(String.format("Total : $%.2f", inv2.getInvoiceAmount()));    
    
    }
  }

