
package rad;

class RadUtils
  {
  /** Prints the passe in string and arguments. **/
  static public void prnt(String format, Object...objects)
    {
    System.out.print(String.format(format,objects));
    }
  }