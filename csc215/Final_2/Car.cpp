
#include "Car.h"
#include <iostream>

using namespace std;

/******************************************************************************
* CTOR */
/***
******************************************************************************/
Car::Car()
  {
  }
/***
* @param  milesDrivenWeekly  Number of miles driven per week.
* @param  mpg                Miles per gallon for car.
******************************************************************************/
Car::Car(float milesDrivenWeekly, float mpg)
  {
  mMilesDrivenWeekly = milesDrivenWeekly;
  mMilesPerGallon    = mpg;
  }

/******************************************************************************
* calculateCarbonFootPrint */
/***
* Calculate the carbon footprint of a car--per EPA.
******************************************************************************/  
float Car::calculateCarbonFootPrint()
  {
  return (mMilesDrivenWeekly * 52)/(mMilesPerGallon * mEFPassengerVehicle * mNoCO2EmissionVeihicleRatio);
  }

/******************************************************************************
* displayStats */
/***
* Display environmental stats.
******************************************************************************/  
void Car::displayStats()
  {
  cout << "********************" << endl;
  cout << "Type: Car" << endl;
  cout << "MPG: " << mMilesPerGallon << endl;
  cout << "Miles Driven Weekly: " << mMilesDrivenWeekly << endl;
  cout << "Carbon Footprint: " << calculateCarbonFootPrint() << " pounds CO2/year." << endl;
  }
  
  