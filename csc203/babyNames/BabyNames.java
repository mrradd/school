
package rad;

import java.io.File;
import java.util.Scanner;
import java.util.Vector;

/*******************************************************************************
* Class BabyNames */
/**
* Finds the most popular baby names from 2005-2015
*******************************************************************************/
class BabyNames
  {
  private Vector<BabyNameRank> mVecNames = new Vector<BabyNameRank>();
  private int                  mMaxYear  = 2015;
  private int                  mMinYear  = 2005;

  /*****************************************************************************
  * findNameData */
  /**
  * Find the name data for user entry.
  * 
  * @param  bn    BabyName object.
  * @param  year  Year to look in.
  * @param  sex   Sex of baby name.
  * @param  name  Name to find.
  * @return  Whether a name was found or not.
  *****************************************************************************/
  public static void findNameData(BabyNames bn, String year, String sex, String name)
    {
    for (BabyNameRank bnr : bn.mVecNames)
      {
      if (bnr.getYear().equals(year) && bnr.getName(sex).toLowerCase().equals(name.toLowerCase()))
        {
        bnr.printData(sex);
        return;
        }
      }
    
    System.out.println("No data found.");
    
    }
  
  /*****************************************************************************
  * loadNames */
  /**
  * Load names to the list from file.
  *****************************************************************************/
  public void loadNames()
    {
    /** Load the vector of ranked baby names. **/
    try
      {
      for(int i = mMinYear; i <= mMaxYear; i++ )
        {
        /** Open the file. **/
        Scanner fileScanner = new Scanner(new File("bbn" + i + ".csv"));
        
        /** Read data out of the file. **/
        while (fileScanner.hasNext())
          {
          /** Split the string. **/
          String[] r = fileScanner.nextLine().split(",", -1);
          
          /** The pattern matches 5 times, but we only want 3 matches. **/
          String rank   = r[0];
          String bName  = r[1];
          String gName  = r[3];
          
          mVecNames.addElement(new BabyNameRank(rank, bName, gName, Integer.toString(i)));
          }

        fileScanner.close();
        }
      
      }
    catch(Exception e)
      {
      System.out.println(e.getMessage());
      }   
    }
  
  /*****************************************************************************
  * main */
  /**
  *
  *****************************************************************************/
  public static void main(String args[])
    {
    BabyNames bn = new BabyNames();   
    
    bn.loadNames();
    
    /** Handle user input. **/
    try
      {
      Scanner input = new Scanner(System.in);
      Integer year  = -1;
      String  sex   = "";
      String  name  = "";
      
      boolean quit      = false;
      
      do
        {
        try
          {
          /** Get year. **/
          System.out.print("\nEnter year from 2005-2015 (9001 to quit): ");
          year = input.nextInt();
         
          /** Check for quit. **/
          if (year == 9001)
            return;
          
          /** Validate year. **/
          if (year == null || (year < 2005 || year > 2015) && year != 9001)
            throw new Exception("I don't know what that is.");

          /** Get sex. **/
          System.out.print("\nEnter 'boy' or 'girl': ");
          sex  = input.next();
          
          /** Validate gender. **/
          if (!(sex.equals("boy") || sex.equals("girl")))
            throw new Exception( "What is a " + sex + "?");

          /** Get name. **/
          System.out.print("\nEnter name: ");
          name = input.next();
          
          /** Find the name. **/
          findNameData( bn, Integer.toString(year), sex, name);
          }
        catch(Exception e)
          {
          input.nextLine();
          System.out.println(e.getMessage());
          }
        }
      while (!quit);
        
      }
    catch(Exception e)
      {
      System.out.println(e.getMessage());
      }
    }
  }