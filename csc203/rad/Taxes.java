
/*****************************************************************************
* Conrad Horton
* CSC203 June 2016
* Post Lab3 Assignment
* 20160621
******************************************************************************
* Calculates taxes based on user inputs.
******************************************************************************/
package rad;

import java.util.List;
import java.util.Vector;

public class Taxes
  {
  
  private int mIncome;
  private int mFilingStatus;
  
  /** Filing statuses. */
  private int SINGLE[]           = {8350,  33950, 82250,  171550, 372950, 372951};
  private int MARRIED_JOINT[]    = {16700, 67900, 137050, 208850, 372950, 372951};
  private int MARRIED_SEPARATE[] = {8350,  33950, 68525,  104425, 186475, 186476};
  private int HEAD_HOUSEHOLD[]   = {11950, 45500, 117450, 190200, 372950, 372951};
  
  public static void main (String[] args)
    {
    Taxes boo = new Taxes();
    
    
    Vector<Integer> brackets;
    
    boo.mIncome = 10000;
    
    
      
    
    }
  }