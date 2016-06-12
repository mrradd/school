#pragma once

/******************************************************************************
* RationalNumber */
/***
* Represents a fraction and its mathematical functionality.
******************************************************************************/
#include <string>
using namespace std;
class RationalNumber
  {
  private:
    int mNumerator;
    int mDenominator;
    
  public:
    RationalNumber();
    RationalNumber(string fraction);
    ~RationalNumber();
  };
