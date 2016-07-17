
package rad;

/*******************************************************************************
* Class BabyName */
/**
* Represents a baby name, gender and popularity for a given year.
*******************************************************************************/
class BabyName
  {
  private int    mCount;
  private String mName;
  private int    mRank;
  private String mSex;
  private int    mYear;

  /** Getters **/
  public String getName() { return mName;  }
  public String getSex () { return mSex;   }
  public int    getYear() { return mYear;  }

  /*****************************************************************************
  * CTOR */
  /**
  *****************************************************************************/
  public BabyName(){ this(-1, "", -1, "", 1890); }
  public BabyName(int count, String name, int rank, String sex, int year)
    {
    mCount = count;
    mName  = name;
    mRank  = rank;
    mSex   = sex;
    mYear  = year;
    }
  
  public String toString()
    {
    return String.format("Name: %s\nRank: %d\nCount: %d", mName, mRank, mCount);
    }
  }