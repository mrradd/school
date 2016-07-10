
/*******************************************************************************
* Conrad Horton
* CSC203 - June 2016
* Complex Number
* 20160709
*******************************************************************************/

package rad;

import java.util.Scanner;

public class ComplexCalculator
  {
  private Complex mC1;
  private Complex mC2;
  private Complex mResult;

  /*****************************************************************************
  * CTOR */
  /**
  *****************************************************************************/
  public ComplexCalculator(Complex c1, Complex c2)
    {
    mC1     = c1;
    mC2     = c2;
    mResult = new Complex();
    }
  
  /*****************************************************************************
  * absoluteValue */
  /**
  * Gives absolute value.
  *****************************************************************************/
  public String absoluteValue(Complex c)
    {
    double a = Math.sqrt(Math.pow(c.getRealPart(), 2) + Math.pow(c.getImaginaryPart(), 2));

    return String.format("|%s| = %.2f", c.toString(), a);
    }
  
  /*****************************************************************************
  * add */
  /**
  * Adds two Complex numbers together.
  *****************************************************************************/
  public String add()
    {
    mResult.setRealPart     (mC1.getRealPart     () + mC2.getRealPart     ()); 
    mResult.setImaginaryPart(mC1.getImaginaryPart() + mC2.getImaginaryPart());
    
    return String.format("%s + %s = %.2f + %.2fi", mC1.toString(), mC2.toString(),
        mResult.getRealPart(), mResult.getImaginaryPart());
    }

  /*****************************************************************************
  * divide */
  /**
  * FOILs this and the passed in Complex number. NOTE: i^2 == -1
  * @param  obj  Complex number.
  *****************************************************************************/
  public String divide()
    {
    double a     = mC1.getRealPart();
    double b     = mC1.getImaginaryPart();
    double c     = mC2.getRealPart();
    double d     = mC2.getImaginaryPart();
    double conjD = d * (d >= 0 ? -1 : 1);
    
    /** Numerator **/
    double first = a * c;
    double outer = a * conjD;
    double inner = b * c;
    double last  = -1 * (b * conjD);
    
    /** Denominator **/
    double denom = c*c + conjD*conjD; 
    
    mResult.setRealPart     ((first + last ) / denom);
    mResult.setImaginaryPart((outer + inner) / denom);
    
    return String.format("%s / %s = %.2f + %.2fi", mC1.toString(), mC2.toString(),
      mResult.getRealPart(), mResult.getImaginaryPart());
    }
  
  /*****************************************************************************
  * multiply */
  /**
  * FOILs this and the passed in Complex number. NOTE: i^2 == -1
  * @param  obj  Complex number.
  *****************************************************************************/
  public String multiply()
    {
    double a     = mC1.getRealPart();
    double b     = mC1.getImaginaryPart();
    double c     = mC2.getRealPart();
    double d     = mC2.getImaginaryPart();
    double first = a * c;
    double outer = a * d;
    double inner = b * c;
    double last  = -1 * (b * d);
    
    mResult.setRealPart     (first + last);
    mResult.setImaginaryPart(outer + inner);
    
    return String.format("%s * %s = %.2f + %.2fi", mC1.toString(), mC2.toString(),
      mResult.getRealPart(), mResult.getImaginaryPart());
    }
  
  /*****************************************************************************
  * subtract */
  /**
  * Subtracts passed in Complex number from this.
  *****************************************************************************/
  public String subtract()
    {
    mResult.setRealPart     (mC1.getRealPart     () - mC2.getRealPart     ());
    mResult.setImaginaryPart(mC1.getImaginaryPart() - mC2.getImaginaryPart());
    
    return String.format("%s - %s = %.2f + %.2fi", mC1.toString(), mC2.toString(),
      mResult.getRealPart(), mResult.getImaginaryPart());
    }
  
  public String toString()
    {
    return String.format("\n%s\n%s\n%s\n%s\n%s\n", add(), subtract(), multiply(), divide(), absoluteValue(mC1));
    }
  
  public static void main( String args[])
    {
    Scanner input = new Scanner(System.in);
    System.out.print("Enter the first complex number: ");
    double a = input.nextDouble();
    double b = input.nextDouble();
    Complex c1 = new Complex(a, b);

    System.out.print("Enter the second complex number: ");
    double c = input.nextDouble();
    double d = input.nextDouble();
    Complex c2 = new Complex(c, d);

    ComplexCalculator cc = new ComplexCalculator(c1, c2);
    cc.multiply();
    Utils.print(cc.toString());
    
    input.close();
    }
  }
