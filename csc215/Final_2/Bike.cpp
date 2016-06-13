
#include "Bike.h"
using namespace std;
/******************************************************************************
* CTOR */
/***
******************************************************************************/
Bike::Bike()
  {
  }
/***
* @param  name         Name of object.
* @param  milesRidden  Miles ridden per week.
******************************************************************************/
Bike::Bike(string name, float milesRidden)
  {
  mName              = name;
  mMilesRiddenWeekly = milesRidden;
  }

/******************************************************************************
* calculateCarbonFootPrint */
/***
* Calculate the carbon footprint of a car--per momentummag.com.
******************************************************************************/  
float Bike::calculateCarbonFootPrint()
  {
  return mMilesRiddenWeekly * mEFPerMile * 52;
  }

/******************************************************************************
* displayStats */
/***
* Display environmental stats.
******************************************************************************/
void Bike::displayStats()
  {
  cout << "*********************************************************************" << endl;
  cout << "Type                 : Bike" << endl;
  cout << "Name                 : "     << mName                      << endl;
  cout << "Miles ridden per week: "     << mMilesRiddenWeekly         << endl;
  cout << "Carbon Footprint     : "     << calculateCarbonFootPrint() << " grams CO2/year." << endl;
  }