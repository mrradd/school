#include "HugeInteger.h"

/******************************************************************************
* CTOR */
/***
******************************************************************************/
HugeInteger::HugeInteger()
  {
  /** Init the digit array. */
  for(int i = 0; i < MAXSIZE; i++)
    for(int j = 0; j < MAXSIZE; j++)
      mDigitArr[i][j] = 0;

  mCurrentRow    = MAXSIZE - 1;
  mCurrentColumn = MAXSIZE - 1;
  }

/******************************************************************************
* DTOR */
/***
******************************************************************************/
HugeInteger::~HugeInteger()
  {
  }
  
/******************************************************************************
* Logical Comparison 
******************************************************************************/
bool HugeInteger::isEqualTo             (const HugeInteger& rhs){return true;}
bool HugeInteger::isGreaterThan         (const HugeInteger& rhs){return true;}
bool HugeInteger::isGreaterThanOrEqualTo(const HugeInteger& rhs){return true;}
bool HugeInteger::isLessThan            (const HugeInteger& rhs){return true;}
bool HugeInteger::isLessThanOrEqualTo   (const HugeInteger& rhs){return true;}
bool HugeInteger::isNotEqualTo          (const HugeInteger& rhs){return true;}
bool HugeInteger::isZero                (const HugeInteger& rhs){return true;}

/******************************************************************************
* pushInt */
/***
* Push an int into the the next column element closest to the end of the
* current row.
*
* 
******************************************************************************/
void HugeInteger::pushInt (const int i)
  {
  mDigitArr[mCurrentRow][mCurrentColumn] = i;
  }

void HugeInteger::test()
  {
  
  }