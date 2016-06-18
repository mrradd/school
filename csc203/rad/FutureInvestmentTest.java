
package rad;

/*******************************************************************************
* Test class for FutureInvestment.java
*******************************************************************************/
public class FutureInvestmentTest
  {
  /**
Enter investment amount: 1000

Enter annual interest rate: 4.25

Enter number of years: 1

Accumulated value is 1043.34
   * **/
  public static void main(String args[])
    {
    FutureInvestment fi = new FutureInvestment();
    fi.setInvestmentAmount();
    fi.setAnnualInterestRate();
    fi.setNumberOfYears();
    fi.displayFutureInvestmentValue();
    }
  }

