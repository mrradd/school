
/******************************************************************************
* Building */
/***
* Represents a building.
******************************************************************************/
#pragma once
#include "CarbonFootPrint.h"
#include <iostream>

class Building : public CarbonFootPrint
  {
  private:
    const float mEFactorValue;
    const float mEFNaturalGas;
    const float mEFFuelOilGallon;
    const float mEFPropane;
    
    float mNatGasThermsMonthly;
    float mKWHMonthly;
    float mOilGalMonthly; 
    float mPropaneGalMonthly;

  public:
    Building();
    Building(float natGasTherms, float kwh, float oilGal, float propane);
    virtual ~Building(){};
    virtual float calculateCarbonFootPrint();
    virtual void  displayStats();
  };
