
#include "RationalNumber.h"

/******************************************************************************
* CTOR */
/***
******************************************************************************/
RationalNumber::RationalNumber(){}
/***
* Takes a stringified fraction and parses out the numerator and den
*
* @param  fraction  Stringified fraction.
******************************************************************************/
RationalNumber::RationalNumber(string fraction)
  {
  split(fraction);
  }

/******************************************************************************
* split */
/***
* Takes a stringified fraction, parses out and sets the numerator and
* denominator, checks to see if it is a valid fraction. If not a valid fraction
* one is provided for user.
*
* @param  fraction  Stringified fraction.
******************************************************************************/  
void RationalNumber::split(string fraction)
  {
  stringstream        ss(fraction);
  string              item;
  
  getline(ss, item, '/');
  mNumerator   = isdigit(stoi(item)) ? stoi(item) : 0;
  getline(ss, item, '/');
  mDenominator = isdigit(stoi(item)) ? stoi(item) : 0;
  
  if(mNumerator <= 0 || mDenominator <= 0)
    {
    mNumerator   = 2;
    mDenominator = 3;
    cout << "Invalid fraction enterred. I'm setting it to 2/3.";
    }
  }
  
  
  
  