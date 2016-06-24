
/******************************************************************************
* Conrad Horton
* CSC203 June 2016
* Post Lab3 Assignment
* 20160621
*******************************************************************************
* Calculates taxes based on user inputs.
*******************************************************************************/
package rad;

import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Vector;

import com.sun.xml.internal.bind.v2.runtime.unmarshaller.XsiNilLoader.Single;

public class Taxes
  {
  /** Filing statuses for user. */
  private final int STATUS_SINGLE           = 0;
  private final int STATUS_MARRIED_JOINT    = 1;
  private final int STATUS_MARRIED_SEPARATE = 2;
  private final int STATUS_HEAD_HOUSEHOLD   = 3;
  
  private int mIncome;
  private int mFilingStatus;
  
  /** Tax bracket $ limits. Percentages in order .10, .15, .25, .28, .33, .35*/
  private Map<Integer, Integer> SINGLE;
  private Map<Integer, Integer> MARRIED_JOINT;
  private Map<Integer, Integer> MARRIED_SEPARATE;
  private Map<Integer, Integer> HEAD_HOUSEHOLD;
  
  /*****************************************************************************
  * CTOR */
  /*** 
  *****************************************************************************/
  public Taxes()
    {
    SINGLE           = new HashMap<Integer, Integer>();
    MARRIED_JOINT    = new HashMap<Integer, Integer>();
    MARRIED_SEPARATE = new HashMap<Integer, Integer>();
    HEAD_HOUSEHOLD   = new HashMap<Integer, Integer>();
    
    /** Create arrays of each tax bracket, we will iterate through these to make
     *  our Maps. This is definitely overkill, but I like Maps. */
    int single         [] = { 8350,  33950, 82250,  171550, 372950, 372951 };
    int marriedJoint   [] = { 16700, 67900, 137050, 208850, 372950, 372951 };
    int marriedSeparate[] = { 8350,  33950, 68525,  104425, 186475, 186476 };
    int headHousehold  [] = { 11950, 45500, 117450, 190200, 372950, 372951 };
    int taxRate        [] = { 10,    15,    25,     28,     33,     35     };
    
    /** Init the maps with the above arrays. */
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
    Map<Integer, Integer> taxMap = null;
    
    switch(mFilingStatus)
      {
      case 0: taxMap = SINGLE;           break;
      case 1: taxMap = MARRIED_JOINT;    break;
      case 2: taxMap = MARRIED_SEPARATE; break;
      case 3: taxMap = HEAD_HOUSEHOLD;   break;
      }
   

    }

  /*****************************************************************************
  * main */
  /***
  *****************************************************************************/
  public static void main (String[] args)
    {
    Taxes boo = new Taxes();
    
    boo.mIncome       = 10000;
    boo.mFilingStatus = boo.STATUS_SINGLE;
    
    boo.calculateTaxes();
    }
  }