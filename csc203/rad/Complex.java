
/*******************************************************************************
* Conrad Horton
* CSC203 - June 2016
* Complex Number
* 20160709
*******************************************************************************/

package rad;

import java.util.Scanner;

public class Complex
  {
  private float mA;
  private float mB;
  
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
  public Complex(float a)
    {
    this(a,0);
    }
  /**
  * 
  * @param  a  Component of a + bi.
  * @param  b  Component of a + bi.
  *****************************************************************************/
  public Complex(float a, float b)
    {
    mA = a;
    mB = b; 
    }
  
  public static void main( String args[])
    {
    }
  }
