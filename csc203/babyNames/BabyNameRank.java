
/*******************************************************************************
* Conrad Horton
* CISC203 June 2016
* Baby Name Asgn
* 20170717
*******************************************************************************/

package rad;

/*******************************************************************************
* Class BabyName */
/**
* Represents a single rank of both boy and girl baby names.
*******************************************************************************/
class BabyNameRank
  {
  private String mBoyName;
  private String mGirlName;
  private String mRank;
  private String mYear;

  /** Getters **/
  public String getName    (String sex) { return sex.equals("boy") ? mBoyName : mGirlName; }
  public String getGirlName()           { return mGirlName; }
  public String getYear    ()           { return mYear;     }

  /*****************************************************************************
  * CTOR */
  /**
  *****************************************************************************/
  public BabyNameRank(){ this("-1", "bName", "gName", "1890"); }
  public BabyNameRank(String rank, String bName, String gName, String year)
    {
    mBoyName  = bName;
    mGirlName = gName;
    mRank     = rank;
    mYear     = year;
    }

  /*****************************************************************************
  * printData */
  /**
  * Print data based on passed in sex. 
  * @param  sex  Sex of the child. "b" for boy.
  *****************************************************************************/
  public void printData(String sex)
    {
    String name = sex.equals("boy") ? mBoyName : mGirlName;
    System.out.printf("\nName: %s\nRank: %s\nYear: %s\n",name, mRank, mYear);
    }
  }