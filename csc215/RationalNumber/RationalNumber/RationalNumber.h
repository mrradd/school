
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
    void print () { cout << mNumerator << "/" << mDenominator << endl; }
    void reduce();
    void split (string fraction);
  };
