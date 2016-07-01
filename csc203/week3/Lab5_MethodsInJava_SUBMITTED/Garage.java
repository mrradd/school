
/*******************************************************************************
* Conrad Horton
* CSC203 June 2016
* Lab5 Assignment: Garage
* 20160629
********************************************************************************
* A parking garage charges a $2.00 minimum fee to park for up to three hours.
* The garage charges an additional $0.50 per hour for each hour or part thereof
* in excess of three hours. The maximum charge for any given 24-hour period is
* $10.00. Assume that no car parks for longer than 24 hours at a time. Write an
* application that calculates and displays the parking charges for each customer
* who parked in the garage yesterday. You should enter the hours parked for each
* customer. The program should display the charge for the current customer and
* should calculate and display the running total of yesterday�s receipts. The
* program should use the method calculate- Charges to determine the charge for
* each customer.
*******************************************************************************/
package rad;

import java.util.ArrayList;
import java.util.Scanner;

class Garage
  {
  /** Cars parked in the garage. **/
  private ArrayList<Car> mParkedCars;
  
  /*---------------------------------*/
  /* Rates and times for the garage. */
  /*---------------------------------*/
  private float mMinCharge   = 2.00f;
  private float mHourRate    = 0.5f;
  private float mGracePeriod = 3.00f;
  private float mMaxCharge   = 10.00f;
  
  /*****************************************************************************
  * CTOR */
  /*** 
  *****************************************************************************/
  public Garage()
    {
    mParkedCars = new ArrayList<Car>();
    }
  
  /*****************************************************************************
  * calculate */
  /*** 
  * Calculates the total charge for parking. 
  *****************************************************************************/
  public float calculate(float time)
    {
    /*-------------------------------------------------------*/
    /* If after 3 hours, and the time is not a whole number, */
    /* adjust to next hour for calculating charges since     */
    /* fractions of an hour are charged as a full hour.      */
    /*-------------------------------------------------------*/
    float t               = time - time % 1 + (time % 1 > 0 ? 1 : 0);
    float adjustedTime    = t - mGracePeriod <= 0 ? 0 : t - mGracePeriod;
    float estimatedCharge = mMinCharge + (adjustedTime * mHourRate);
    
    return mMaxCharge < estimatedCharge ? mMaxCharge : estimatedCharge;
    }
  
  /*****************************************************************************
  * addCars */
  /*** 
  * Create a new Car and add it to the list of parked Cars. 
  *****************************************************************************/
  public void addCars()
    {
    Scanner input = new Scanner(System.in);
    float   time  = 1.0f;
    boolean quit  = false;
    
    /** Add cars until user quits. **/
    while(!quit)
      {
      System.out.println("Enter hours this car has been parked. (0 to quit)");
      time = input.nextFloat();
      quit = time <= 0.0f;

      if (!quit)
        {
        /** Make a new car, display charges, and add it to the list. **/
        Car car = new Car(time);
        System.out.printf("Charge:\t$%.2f\n", calculate(car.getTimeParked()));
        mParkedCars.add(car);
        
        /** Clear the Scanner. **/
        input.nextLine();
        
        printRunningTotals();
        }
      }
    
    input.close();
    }
  
  /*****************************************************************************
  * printRunningTotals */
  /*** 
  * Print out all cars' charges. 
  *****************************************************************************/
  public void  printRunningTotals()
    {
    float total = 0.0f;
    for (Car car : mParkedCars)
      total += calculate(car.getTimeParked());

    System.out.printf("Running Total:\t$%.2f\n", total);
    }
  
  /*****************************************************************************
  * INTERNAL CLASS Car*/
  /*** 
  * Represents a car that is staying in the Garage. 
  *****************************************************************************/
  private class Car
    {
    /*------------------------*/
    /* Time parked in Garage. */
    /*------------------------*/
    private float mTimeParked;
    
    /***************************************************************************
    * CTOR */
    /*** 
    ***************************************************************************/
    public Car(float time)
      {
      mTimeParked = time;
      }
     
    /*------------------*/
    /* Setters/Getters. */
    /*------------------*/
    public float getTimeParked() { return mTimeParked; }  
    }
  }