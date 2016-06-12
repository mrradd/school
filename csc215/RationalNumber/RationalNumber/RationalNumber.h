
/******************************************************************************
* RationalNumber */
/***
* Represents a fraction and its mathematical functionality.
******************************************************************************/
#pragma once
#include <string>
#include <vector>
#include <sstream>
#include <iostream>
using namespace std;
class RationalNumber
  {
  private:
    long mNumerator;
    long mDenominator;
    
  public:
    RationalNumber();
    RationalNumber(string fraction);
    ~RationalNumber(){};

    long   findCommonDenominator(long val, long remainder);
    string toString();
    void   reduce  ();
    void   split   (string fraction);
    
    RationalNumber operator+ (const RationalNumber& rhs);
    RationalNumber operator- (const RationalNumber& rhs);
    RationalNumber operator* (const RationalNumber& rhs);
    RationalNumber operator/ (const RationalNumber& rhs);
    bool           operator==(const RationalNumber& rhs);
    bool           operator!=(const RationalNumber& rhs);
    bool           operator> (const RationalNumber& rhs);
    bool           operator< (const RationalNumber& rhs);
    bool           operator>=(const RationalNumber& rhs);
    bool           operator<=(const RationalNumber& rhs);
  };
