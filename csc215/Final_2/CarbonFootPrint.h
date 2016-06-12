
/******************************************************************************
* CarbonFootPrint */
/***
* Represents an objects Carbon Foot Print.
******************************************************************************/
#pragma once
class CarbonFootPrint
  {
  public:
    CarbonFootPrint();
    virtual ~CarbonFootPrint(){};
  
    virtual float calculateCarbonFootPrint()=0;
    virtual void  displayStats()=0;
  };
