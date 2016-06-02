#pragma once

#include <string>

class HugeInteger
  {
  private:
    /** Data memebers. */
    std::string hugeIntList[40];

  public:
    /** CTOR/DTOR */
    HugeInteger();
    virtual ~HugeInteger();
    
    /** Methods. */
    bool isEqualTo             (const HugeInteger& rhs);
    bool isGreaterThan         (const HugeInteger& rhs);
    bool isGreaterThanOrEqualTo(const HugeInteger& rhs);
    bool isLessThan            (const HugeInteger& rhs);
    bool isLessThanOrEqualTo   (const HugeInteger& rhs);
    bool isNotEqualTo          (const HugeInteger& rhs);
    bool isZero                (const HugeInteger& rhs);
  };

