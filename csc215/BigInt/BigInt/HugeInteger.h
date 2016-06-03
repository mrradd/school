#pragma once

#define MAXSIZE 40

#include <string>

class HugeInteger
  {
  private:
    /** Data memebers. */
    /** Array where each element is an array of up to 40 single digits each. */
    unsigned int mDigitArr[MAXSIZE][MAXSIZE];
    unsigned int mCurrentRow;
    unsigned int mCurrentColumn;

  public:
    /** CTOR/DTOR */
    HugeInteger();
    virtual ~HugeInteger();
    
    /** Methods. */
    /** Comparison. */
    bool isEqualTo             (const HugeInteger& rhs);
    bool isGreaterThan         (const HugeInteger& rhs);
    bool isGreaterThanOrEqualTo(const HugeInteger& rhs);
    bool isLessThan            (const HugeInteger& rhs);
    bool isLessThanOrEqualTo   (const HugeInteger& rhs);
    bool isNotEqualTo          (const HugeInteger& rhs);
    bool isZero                (const HugeInteger& rhs);

    void pushInt               (const int i);

    void test();
  };

