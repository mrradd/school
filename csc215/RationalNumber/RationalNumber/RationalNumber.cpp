
#include "RationalNumber.h"

/******************************************************************************
* CTOR */
/***
******************************************************************************/
RationalNumber::RationalNumber()
  {
  mNumerator   = 0;
  mDenominator = 0;
  }
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
long RationalNumber::findCommonDenominator(long val, long remainder)
  {
	if(remainder == 0)
		return(val);
	else 
    return(findCommonDenominator(remainder,val%remainder));
  }

/******************************************************************************
* toString */
/***
* Stringifies the fraction.
******************************************************************************/
string RationalNumber::toString()
  {
  ostringstream oss;
  oss << mNumerator << "/" << mDenominator;
  return oss.str();
  }

/******************************************************************************
* reduce */
/***
* Reduce the fraction.
******************************************************************************/
void RationalNumber::reduce()
  {
	long multiple = 0;
  
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
  stringstream ss(fraction);
  string       item;
  vector<long>  vecElems;

  /** Parse out the numbers from the fraction and verify they are good. */
  for(long i = 0; i < 2; i++)
    {
    char* garbage = nullptr;

    getline(ss, item, '/');
    long x = strtol(item.c_str(), &garbage, 10);
    
    if(*garbage == '\0' && errno != ERANGE)
      vecElems.push_back(x);
    else
      vecElems.push_back(0);
    }
  
  /** Bad fraction values. Set to a good value. */
  if(vecElems[0] <= 0 || vecElems[1] <= 0)
    {
    mNumerator   = 2;
    mDenominator = 3;
    cout << fraction << " is not acceptable. I'm setting it to 2/3." << endl;
    }
  /** Fraction values okay. */
  else
    {
    mNumerator   = vecElems[0];
    mDenominator = vecElems[1];
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
  tempRN.mNumerator   = (tempRN.mNumerator * rhs.mDenominator) - (rhs.mNumerator * tempRN.mDenominator);
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
  
bool RationalNumber::operator ==(const RationalNumber& rhs)
  {
  return mDenominator == rhs.mDenominator && mNumerator == rhs.mDenominator;
  }
  
bool RationalNumber::operator !=(const RationalNumber& rhs)
  {
  return !(*this == rhs);
  }
  
bool RationalNumber::operator >(const RationalNumber& rhs)
  {
  return *this != rhs && (mDenominator < rhs.mDenominator || (mDenominator == rhs.mDenominator && mNumerator > rhs.mNumerator));
  }

bool RationalNumber::operator <(const RationalNumber& rhs)
  {
  return *this != rhs && (mDenominator > rhs.mDenominator || (mDenominator == rhs.mDenominator && mNumerator < rhs.mNumerator));
  }

bool RationalNumber::operator >=(const RationalNumber& rhs)
  {
  return *this > rhs || *this == rhs;
  }

bool RationalNumber::operator <=(const RationalNumber& rhs)
  {
  return *this < rhs || *this == rhs;
  }

