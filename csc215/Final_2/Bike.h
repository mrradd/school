
/******************************************************************************
* Bike */
/***
* Represents a bicycle.
******************************************************************************/
#pragma once
#include "CarbonFootPrint.h"
#include <iostream>

class Bike : public CarbonFootPrint
  {
  public:
    Bike();
    virtual ~Bike(){};
    virtual float calculateCarbonFootPrint();
    virtual void  displayStats();
  };
