
/******************************************************************************
* Building */
/***
* Represents a building.
******************************************************************************/
#pragma once
#include "CarbonFootPrint.h"
#include <iostream>
#include <string>

class Building : public CarbonFootPrint
  {
  private:
    /** Emission factors per EPA. */
    const float mEFactorValueInCA  = 613.285;
    const float mEFNaturalGasTherm = 11.7;
    const float mEFFuelOilGallon   = 22.61;
    const float mEFPropane         = 12.43;
    
    float       mNatGasThermsMonthly;
    float       mKWHMonthly;
    float       mOilGalMonthly; 
    float       mPropaneGalMonthly;
    std::string mName;

  public:
    Building();
    Building(std::string name, float natGasTherms, float kwh, float oilGal, float propane);
    virtual ~Building(){};
    virtual float calculateCarbonFootPrint();
    virtual void  displayStats();
  };
