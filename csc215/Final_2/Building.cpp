
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
  
/******************************************************************************
* make */
/***
* Asks for data from user, builds a Building.
*
* @returns  Building pointer.
******************************************************************************/
Building* Building::make()
  {
  Building * b = new Building();
  string buffer;
  
  cout << "\nName of Building?" << endl;
  getline(cin, buffer, '\n');
  b->mName = buffer;
  cin   .clear();
  buffer.clear();

  cout << "\nNatural Gas used per month in Therms?" << endl;
  getline(cin, buffer, '\n');
  b->mNatGasThermsMonthly = getFloat(buffer);
  cin   .clear();
  buffer.clear();

  cout << "\nKilowatt hours used per month?" << endl;
  getline(cin, buffer, '\n');
  b->mKWHMonthly = getFloat(buffer);
  cin   .clear();
  buffer.clear();

  cout << "\nOil gallons used per month?" << endl;
  getline(cin, buffer, '\n');
  b->mOilGalMonthly = getFloat(buffer);
  cin   .clear();
  buffer.clear();

  cout << "\nPropane gallons used per month?" << endl;
  getline(cin, buffer, '\n');
  b->mPropaneGalMonthly = getFloat(buffer);
  cin   .clear();
  buffer.clear();

  return b;
  }