
package rad;

import java.util.Scanner;

/*******************************************************************************
* Write a program that reads in investment amount, annual interest rate, and
* number of years, and displays the future investment value using the following
* formula:
* futureInvestmentValue = investmentAmount * (1 + APR)^(numberOfYears)
*******************************************************************************/
public class FutureInvestment
  {
  private double mInvestmentAmount;
  private double mAnnualInterestRate;
  private int    mNumberOfYears;
  
  /* Get/Set mInvestmentAmount. Set methods take value from std input to set
   * data members.*/
  public double getInvestmentAmount(){ return mInvestmentAmount; }
  public void   setInvestmentAmount()
    {
    Scanner input     = new Scanner(System.in);
    System.out.println("Enter innitial investment...");
    mInvestmentAmount = input.nextDouble();
    }
  
  /** Get/Set mMonthlyInterestRate. */
  public double getAnnualInterestRate(){ return mAnnualInterestRate; }
  public void   setAnnualInterestRate()
    {
    Scanner input       = new Scanner(System.in);
    System.out.println("Enter investment's APR...");
    mAnnualInterestRate = input.nextDouble();
    }
  
  /** Get/Set mNumberOfYears. */
  public int    getNumberOfYears(){ return mNumberOfYears; }
  public void   setNumberOfYears()
    {
    Scanner input  = new Scanner(System.in);
    System.out.println("Enter time until maturity in years...");
    mNumberOfYears = input.nextInt();
    }
  
  /** Get/Set mFutureInvestmentValue. */
  public void displayFutureInvestmentValue()
    { System.out.printf("Estimated FV: %.2f", (mInvestmentAmount * Math.pow((1 + mAnnualInterestRate), mNumberOfYears))) ; }
  
  }

