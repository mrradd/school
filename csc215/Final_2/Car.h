
/******************************************************************************
* Car */
/***
* Represents a car.
******************************************************************************/
#pragma once
#include "CarbonFootPrint.h"
#include <iostream>

class Car : public CarbonFootPrint
  {
  private: 
    const float  mNoCO2EmissionVeihicleRatio = 1.01f;  
    const float  mEFPassengerVehicle         = 19.6f ;
    float        mMilesDrivenWeekly;
    float        mMilesPerGallon;

  public:
    Car();
    Car(float milesDrivenWeekly, float mpg);
    virtual ~Car(){};
    virtual float calculateCarbonFootPrint();
    virtual void  displayStats();
  };
