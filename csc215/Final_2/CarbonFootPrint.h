
/******************************************************************************
* CarbonFootPrint */
/***
* Represents an objects Carbon Foot Print.
******************************************************************************/
#pragma once
#include <string>
#include <iostream>

class CarbonFootPrint
  {
  public:
    CarbonFootPrint(){};
    virtual ~CarbonFootPrint(){};
    
    virtual float calculateCarbonFootPrint()=0;
    virtual void  displayStats()=0;

    static  float getFloat(std::string floatStr)
      {
      if (!floatStr.empty())
        {
        errno = 0;
        char *garbage = nullptr;

        /** strtod gives val if good, and 0.0 if bad. */
        float destination = std::strtod(floatStr.c_str(), &garbage);

        if(*garbage == '\0' && errno != ERANGE)
          return destination;
        }

      std::cout << "Bad value. Setting to 0." << std::endl;
      return 0.0f;
      };
  };
