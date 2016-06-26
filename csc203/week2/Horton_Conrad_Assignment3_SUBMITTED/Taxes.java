
/******************************************************************************
* Conrad Horton
* CSC203 June 2016
* Assignment Calculate Taxes
* 20160621
*******************************************************************************
* Calculates taxes based on user inputs.
*******************************************************************************/
package rad;

import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class Taxes
  {
  private int mIncome;
  private int mFilingStatus;
  
  /** Tax bracket $ limits. Percentages in order .10, .15, .25, .28, .33, .35
  *   Using LinkedHashMap to maintain insertion order. **/
  private LinkedHashMap<Integer, Integer> SINGLE;
  private LinkedHashMap<Integer, Integer> MARRIED_JOINT;
  private LinkedHashMap<Integer, Integer> MARRIED_SEPARATE;
  private LinkedHashMap<Integer, Integer> HEAD_HOUSEHOLD;
  
  /*****************************************************************************
  * CTOR */
  /*** 
  *****************************************************************************/
  public Taxes()
    {
    SINGLE           = new LinkedHashMap<Integer, Integer>();
    MARRIED_JOINT    = new LinkedHashMap<Integer, Integer>();
    MARRIED_SEPARATE = new LinkedHashMap<Integer, Integer>();
    HEAD_HOUSEHOLD   = new LinkedHashMap<Integer, Integer>();
    
    /** Create arrays of each tax bracket, we will iterate through these to make
     *  our Maps. This is definitely overkill, but I like Maps. The last bracket
     *  has not cap, so I am setting it arbitrarily large. **/
    int single         [] = { 8350,  33950, 82250,  171550, 372950, 2000000000 };
    int marriedJoint   [] = { 16700, 67900, 137050, 208850, 372950, 2000000000 };
    int marriedSeparate[] = { 8350,  33950, 68525,  104425, 186475, 2000000000 };
    int headHousehold  [] = { 11950, 45500, 117450, 190200, 372950, 2000000000 };
    int taxRate        [] = { 10,    15,    25,     28,     33,     35     };
    
    /** Init the maps with the above arrays. Loading them backwards, because put
    *   pushes data onto the map closest to the front. **/
    for(int i = 0; i < taxRate.length; i++)
      {
      SINGLE          .put(taxRate[i], single         [i]);
      MARRIED_JOINT   .put(taxRate[i], marriedJoint   [i]);
      MARRIED_SEPARATE.put(taxRate[i], marriedSeparate[i]);
      HEAD_HOUSEHOLD  .put(taxRate[i], headHousehold  [i]);
      }
    }
  
  /*****************************************************************************
  * calculateTaxes */
  /***
  * Calculates taxes based on user inputs. 
  *****************************************************************************/
  public void calculateTaxes()
    {
    Map<Integer,Integer> taxMap = null;
    
    Scanner input = new Scanner(System.in);
    System.out.println("\nEnter your filing status.\n [0]Single\n [1]Married Filing Jointly\n [2]Married Filing Separately\n [3]Head of Household.");
    mFilingStatus = input.nextInt();
    System.out.println("Enter your taxable income: ");
    mIncome       = input.nextInt();
    
    switch(mFilingStatus)
      {
      case 1 : taxMap = MARRIED_JOINT;    break;
      case 2 : taxMap = MARRIED_SEPARATE; break;
      case 3 : taxMap = HEAD_HOUSEHOLD;   break;
      default: taxMap = SINGLE;           break; 
      }
   
    double taxAmountOwed   = 0.0;
    int    previousBracket = 0;
    int    remainingIncome = mIncome;
    for(Map.Entry<Integer, Integer> bracket: taxMap.entrySet())
      {
      if (remainingIncome >= 0)
        {
        int    bracketVal  = bracket.getValue().intValue();
        int    bracketMax  = mIncome >= bracketVal ? bracketVal - previousBracket : mIncome - previousBracket;
        double taxRate     = (double)bracket.getKey().intValue()/100;
        taxAmountOwed     += taxRate * bracketMax;
        
        System.out.println(taxAmountOwed);

        remainingIncome   -= bracketVal - previousBracket; 
        previousBracket    = bracketVal;
        }
      else
        break;
      }
    
    System.out.printf("Tax Owed: $%.2f\n\n", taxAmountOwed);
    input.close();
    }

  /*****************************************************************************
  * main */
  /***
  *****************************************************************************/
  public static void main (String[] args)
    {
    Taxes boo = new Taxes();
    
    boo.mIncome       = 100000;
    boo.mFilingStatus = 0;
    boo.calculateTaxes();
    
    boo.mIncome       = 300339;
    boo.mFilingStatus = 1;
    boo.calculateTaxes();
    
    boo.mIncome       = 123500;
    boo.mFilingStatus = 2;
    boo.calculateTaxes();
    
    boo.mIncome       = 4545402;
    boo.mFilingStatus = 3;
    boo.calculateTaxes();
    }
  }