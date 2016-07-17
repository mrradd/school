
package rad;

import java.io.File;
import java.util.Scanner;

/*******************************************************************************
* Class BabyNames */
/**
* Finds the most popular baby names from 2005-2015
*******************************************************************************/
class BabyNames
  {

  public static void main(String args[])
    {
    try
      {
      Scanner input = new Scanner(new File("bbn5.csv"));
      input.useDelimiter(",");
      
      String s = input.next();
      System.out.println(s);
      }
    catch(Exception e)
      {
      System.out.println(e.getMessage());
      }
    }
  }