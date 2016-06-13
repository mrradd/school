
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
* @param  name               Name of object.
* @param  milesDrivenWeekly  Number of miles driven per week.
* @param  mpg                Miles per gallon for car.
******************************************************************************/
Car::Car(string name, float milesDrivenWeekly, float mpg)
  {
  mName              = name;
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
  cout << "*********************************************************************" << endl;
  cout << "Type               : Car" << endl;
  cout << "Name               : "    << mName                      << endl;
  cout << "MPG                : "    << mMilesPerGallon            << endl;
  cout << "Miles Driven Weekly: "    << mMilesDrivenWeekly         << endl;
  cout << "Carbon Footprint   : "    << calculateCarbonFootPrint() << " pounds CO2/year." << endl;
  }
  
/******************************************************************************
* make */
/***
* Asks for data from user, builds a car.
*
* @returns  Car pointer.
******************************************************************************/
Car* Car::make()
  {
  Car * c = new Car();
  string buffer;
  
  cout << "\nName of car?" << endl;
  getline(cin, buffer, '\n');
  c->mName = buffer;
  cin   .clear();
  buffer.clear();

  cout << "\nMiles driven per week?" << endl;
  getline(cin, buffer, '\n');
  c->mMilesDrivenWeekly = getFloat(buffer);
  cin   .clear();
  buffer.clear();
  
  cout << "\nMiles per gallon for car?" << endl;
  getline(cin, buffer, '\n');
  c->mMilesPerGallon = getFloat(buffer);
  cin   .clear();
  buffer.clear();

  return c;
  }  