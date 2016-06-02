#include "HugeInteger.h"

/******************************************************************************
* CTOR */
/***
******************************************************************************/
HugeInteger::HugeInteger()
  {
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
bool isEqualTo             (const HugeInteger& rhs){return true;}
bool isGreaterThan         (const HugeInteger& rhs){return true;}
bool isGreaterThanOrEqualTo(const HugeInteger& rhs){return true;}
bool isLessThan            (const HugeInteger& rhs){return true;}
bool isLessThanOrEqualTo   (const HugeInteger& rhs){return true;}
bool isNotEqualTo          (const HugeInteger& rhs){return true;}
bool isZero                (const HugeInteger& rhs){return true;}