
/******************************************************************************
* Car */
/***
* Represents a car.
******************************************************************************/
#pragma once
#include "CarbonFootPrint.h"
#include <iostream>
#include <string>

class Car : public CarbonFootPrint
  {
  private: 
    /** Emission factors per EPA. */
    const float  mNoCO2EmissionVeihicleRatio = 1.01f;  
    const float  mEFPassengerVehicle         = 19.6f;
    
    float        mMilesDrivenWeekly;
    float        mMilesPerGallon;
    std::string  mName;

  public:
    Car();
    Car(std::string name, float milesDrivenWeekly, float mpg);
    virtual ~Car(){};
    virtual float calculateCarbonFootPrint();
    virtual void  displayStats();
  };
