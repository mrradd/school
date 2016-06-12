
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
* findCommonDenominator */
/***
* Recursively finds the Greatest Common Denominator by using taking the passed
* in value and modding it by the remainder.
*
* @param  val        Int to check against
* @param  remainder  Remainder of the modulus.
******************************************************************************/  
int RationalNumber::findCommonDenominator(int val, int remainder)
  {
	if(remainder == 0)
		return(val);
	else 
    return(findCommonDenominator(remainder,val%remainder));
  }

/******************************************************************************
* print */
/***
* Prints the fractoin.
******************************************************************************/
void RationalNumber::print()
  {
  cout << mNumerator << "/" << mDenominator << endl;
  }

/******************************************************************************
* reduce */
/***
* Reduce the fraction.
******************************************************************************/
void RationalNumber::reduce()
  {
	int multiple = 0;
  
	if(mDenominator > mNumerator)
		multiple = findCommonDenominator(mDenominator,mNumerator);
	else
		multiple = findCommonDenominator(mNumerator,  mDenominator);

	mNumerator   /= multiple;
	mDenominator /= multiple;
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

/******************************************************************************
* OPERATOR OVERLOADS
******************************************************************************/  
RationalNumber RationalNumber::operator +(const RationalNumber& rhs)
  {
  RationalNumber tempRN;
  tempRN = *this;
  tempRN.mNumerator   = (tempRN.mNumerator * rhs.mDenominator) + (rhs.mNumerator * tempRN.mDenominator);
  tempRN.mDenominator = rhs.mDenominator * tempRN.mDenominator;
  tempRN.reduce();
  return tempRN;
  }
  
RationalNumber RationalNumber::operator -(const RationalNumber& rhs)
  {
  RationalNumber tempRN;
  tempRN = *this;
  
  tempRN.mNumerator = (tempRN.mNumerator * rhs.mDenominator) - (rhs.mNumerator * tempRN.mDenominator);
  tempRN.mDenominator = rhs.mDenominator * tempRN.mDenominator;
    
  tempRN.reduce();
  return tempRN;
  }

RationalNumber RationalNumber::operator *(const RationalNumber& rhs)
  {
  RationalNumber tempRN;
  tempRN = *this;
  
  tempRN.mNumerator   = tempRN.mNumerator   * rhs.mNumerator;
  tempRN.mDenominator = tempRN.mDenominator * rhs.mDenominator;
  
  tempRN.reduce();
  return tempRN;
  }

RationalNumber RationalNumber::operator /(const RationalNumber& rhs)
  {
  RationalNumber tempRN;
  tempRN = *this;

  tempRN.mDenominator = tempRN.mDenominator * rhs.mNumerator;
  tempRN.mNumerator   = tempRN.mNumerator   * rhs.mDenominator;
    
  tempRN.reduce();
  return tempRN;
  } 
  
  
  
  
  
  