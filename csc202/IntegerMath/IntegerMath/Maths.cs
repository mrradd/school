using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerMath
  {

  /****************************************************************************
  * Maths */
  /**
  * Provides functions to perform simple arithmetic operations.
  ****************************************************************************/
  public static class Maths
    {
    /**************************************************************************
    * add */
    /**
    * Adds two values together and returns string of result in equation form.
    **************************************************************************/
    public static string add(int val1, int val2)
      {
      return String.Format("{0} + {1} = {2}", val1, val2, val1 + val2);
      }

    /**************************************************************************
    * divide */
    /**
    * Divides first value by second value and returns string of result in
    * equation form.
    **************************************************************************/
    public static string divide(int dividend, int divisor)
      {
      return String.Format("{0} / {1} = {2}", dividend, divisor, dividend / divisor);
      }

    /**************************************************************************
    * modulus */
    /**
    * Applies modulo and returns string of result in equation form.
    **************************************************************************/
    public static string mod(int dividend, int divisor)
      {
      return String.Format("{0} % {1} = {2}", dividend, divisor, dividend % divisor);
      }

    /**************************************************************************
    * multiply */
    /**
    * Multiplies two numbers and returns string of result in equation form.
    **************************************************************************/
    public static string multiply(int val1, int val2)
      {
      return String.Format("{0} * {1} = {2}", val1, val2, val1 * val2);
      }

    /**************************************************************************
    * subtract */
    /**
    * Subtracts second value from first value and returns string of result in
    * equation form.
    **************************************************************************/
    public static string subtract(int val1, int val2)
      {
      return String.Format("{0} - {1} = {2}", val1, val2, val1 - val2);
      }
    }
  }
