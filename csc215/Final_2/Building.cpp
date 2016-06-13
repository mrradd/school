
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
* @param  name          Name of object.
* @param  natGasTherms  Therms of natural gas used.
* @param  kwh           Kilowatt hours used.
* @param  oilGal        Oil used.
* @param  propaan       Propane used.
******************************************************************************/
Building::Building(string name, float natGasTherms, float kwh, float oilGal, float propane)
  {
  mName                = name;
  mNatGasThermsMonthly = natGasTherms;
  mKWHMonthly          = kwh;
  mOilGalMonthly       = oilGal;
  mPropaneGalMonthly   = propane;
  }

/******************************************************************************
* calculateCarbonFootPrint */
/***
* Calculate the carbon footprint of a car--per EPA.
******************************************************************************/  
float Building::calculateCarbonFootPrint()
  {
  float gas     = mNatGasThermsMonthly * mEFNaturalGasTherm * 12;
  float elec    = mKWHMonthly          * mEFactorValueInCA  * 12;
  float oil     = mOilGalMonthly       * mEFFuelOilGallon   * 12;
  float propane = mPropaneGalMonthly   * mEFPropane         * 12;
  return gas + elec + oil + propane;
  }

/******************************************************************************
* displayStats */
/***
* Display environmental stats.
******************************************************************************/
void Building::displayStats()
  {
  cout << "*********************************************************************" << endl;
  cout << "Type                    : Building" << endl;
  cout << "Name                    : "         << mName                      << endl;
  cout << "Natural Gas Therms/Month: "         << mNatGasThermsMonthly       << endl;
  cout << "Kilowatt Hours/Month    : "         << mKWHMonthly                << endl;
  cout << "Gallons of Oil/Month    : "         << mOilGalMonthly             << endl;
  cout << "Gallons Propane/Month   : "         << mPropaneGalMonthly         << endl;
  cout << "Carbon Footprint        : "         << calculateCarbonFootPrint() << " pounds CO2/year." << endl;
  }