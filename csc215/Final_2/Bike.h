
/******************************************************************************
* Bike */
/***
* Represents a bicycle.
******************************************************************************/
#pragma once
#include "CarbonFootPrint.h"
#include <iostream>
#include <string>

class Bike : public CarbonFootPrint
  {
  private:
    /** Emission factor momentummag.com. */
    const float mEFPerMile = 20.0f;

    float       mMilesRiddenWeekly;
    std::string mName;

  public:
    Bike();
    Bike(std::string name, float milesRidden);
    virtual ~Bike(){};
    virtual float calculateCarbonFootPrint();
    virtual void  displayStats();
  };
