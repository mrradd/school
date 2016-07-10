
/*******************************************************************************
* Conrad Horton
* CSC203 - June 2016
* Complex Number
* 20160709
*******************************************************************************/

package rad;

public class Complex
  {
  private double mA;
  private double mB;
  
  /** Setters/Getters **/
  public double getRealPart     ()         { return mA;           }
  public void   setRealPart     (double a) { mA = a;              }
  public double getImaginaryPart()         { return mB;           }
  public void   setImaginaryPart(double b) { mB = b;              }
  
  /*****************************************************************************
  * CTOR */
  /**
  *****************************************************************************/
  public Complex()
    {
    this(0,0);
    }
  /**
  * @param  a  First component of a + bi.
  *****************************************************************************/
  public Complex(double a)
    {
    this(a,0);
    }
  /**
  * 
  * @param  a  Component of a + bi.
  * @param  b  Component of a + bi.
  *****************************************************************************/
  public Complex(double a, double b)
    {
    mA = a;
    mB = b;
    }
  
  public String toString()
    {
    return String.format("(%.2f + %.2fi)", mA, mB);
    }
  }
