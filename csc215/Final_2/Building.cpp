
#include "Building.h"
using namespace std;
/******************************************************************************
* CTOR */
/***
******************************************************************************/
Building::Building()
  {
  }
/***
* @param  natGasTherms  Therms of natural gas used.
* @param  kwh           Kilowatt hours used.
* @param  oilGal        Oils
******************************************************************************/
Building(float natGasTherms, float kwh, float oilGal, float propane){}

/******************************************************************************
* calculateCarbonFootPrint */
/***
* Calculate the carbon footprint of a car--per EPA.
******************************************************************************/  
float Building::calculateCarbonFootPrint()
  {
  return 1;//;
  }

/******************************************************************************
* displayStats */
/***
* Display environmental stats.
******************************************************************************/  
void Building::displayStats()
  {
  cout << "********************" << endl;
  cout << "Type: Car" << endl;
  cout << "MPG: " <<  << endl;
  cout << "Miles Driven Weekly: " <<  << endl;
  cout << "Carbon Footprint: " << calculateCarbonFootPrint() << " pounds CO2/year." << endl;
  }