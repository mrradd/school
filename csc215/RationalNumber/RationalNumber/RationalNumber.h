
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
    int mNumerator;
    int mDenominator;
    
  public:
    RationalNumber();
    RationalNumber(string fraction);
    ~RationalNumber(){};

    int  findCommonDenominator(int val, int remainder);
    void print     ();
    void reduce    ();
    void split     (string fraction);
    
    RationalNumber operator +(const RationalNumber& rhs);
    RationalNumber operator -(const RationalNumber& rhs);
    RationalNumber operator *(const RationalNumber& rhs);
    RationalNumber operator /(const RationalNumber& rhs);
  };
