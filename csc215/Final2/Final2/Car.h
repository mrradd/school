
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
    Car(std::string name, float milesDrivenWeekly=0.0f, float mpg=0.0f);
    virtual ~Car(){};
    virtual float calculateCarbonFootPrint();
    virtual void  displayStats();
    static  Car*  make();
  };
