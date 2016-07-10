
package rad;

class Utils
  {
  /*****************************************************************************
  * print */
  /**
  * Made this because I got tired of writing the actual method name constantly.
  * It's really just the same thing as System.out.format(...), but it's just a
  * bit of sugar.
  *****************************************************************************/
  static public void print(String format, Object...objects)
    {
    System.out.format(format, objects);
    }
  }