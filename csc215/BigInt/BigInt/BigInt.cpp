#include "BigInt.h"

/******************************************************************************
* CTOR */
/***
******************************************************************************/
BigInt::BigInt()
  {
  /** Init the digit array. */
  for(int i = 0; i < MAXSIZE; i++)
    /** -1 denotes that the position is not in use. */
    mDigits[i] = -1;

  mPosition = MAXSIZE - 1;
  }

/******************************************************************************
* DTOR */
/***
******************************************************************************/
BigInt::~BigInt()
  {
  }
  
/******************************************************************************
* Logical Comparison 
******************************************************************************/
bool BigInt::isEqualTo             (const BigInt& rhs){return true;}
bool BigInt::isGreaterThan         (const BigInt& rhs){return true;}
bool BigInt::isGreaterThanOrEqualTo(const BigInt& rhs){return true;}
bool BigInt::isLessThan            (const BigInt& rhs){return true;}
bool BigInt::isLessThanOrEqualTo   (const BigInt& rhs){return true;}
bool BigInt::isNotEqualTo          (const BigInt& rhs){return true;}
bool BigInt::isZero                (const BigInt& rhs){return true;}

/******************************************************************************
* Add */
/***
******************************************************************************/
void add (const BigInt& rhs)
  {
  std::vector<int> result;
  
  }

/******************************************************************************
* pushInt */
/***
* Push an int onto the next available element from the back and increments
* size.
*
* @param  i  Integer to push onto the array.  
******************************************************************************/
void BigInt::pushInt (const int i)
  {
  mDigits[MAXSIZE - mSize] = i;
  mSize++;
  }

void BigInt::test()
  {
  
  }