
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
    const float mEFactorValueInCA  = 1.2389f;
    const float mEFNaturalGasTherm = 11.7f;
    const float mEFFuelOilGallon   = 22.61f;
    const float mEFPropane         = 12.43f;
    
    float       mNatGasThermsMonthly;
    float       mKWHMonthly;
    float       mOilGalMonthly; 
    float       mPropaneGalMonthly;
    std::string mName;

  public:
    Building();
    Building(std::string name, float natGasTherms=0.0f, float kwh=0.0f,
             float oilGal=0.0f, float propane=0.0f);
    virtual ~Building(){};
    virtual float calculateCarbonFootPrint();
    virtual void  displayStats();
    static Building* make();
  };
