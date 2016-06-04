#pragma once

#include <string>
#include <vector>
#define MAXSIZE 40

class BigInt
  {
  private:
    /** Data memebers. */
    /** Array where each element is a single digit. */
    unsigned int mDigits[MAXSIZE];

    /** Position in the array. */
    unsigned int mPosition;

    /** Used elements in the array. */
    unsigned int mSize;    

  public:
    /** CTOR/DTOR */
    BigInt();
    virtual ~BigInt();
    
    /** Methods. */
    /** Comparison. */
    bool isEqualTo             (const BigInt& rhs);
    bool isGreaterThan         (const BigInt& rhs);
    bool isGreaterThanOrEqualTo(const BigInt& rhs);
    bool isLessThan            (const BigInt& rhs);
    bool isLessThanOrEqualTo   (const BigInt& rhs);
    bool isNotEqualTo          (const BigInt& rhs);
    bool isZero                (const BigInt& rhs);

    void add     (const BigInt& rhs);
    void pushInt (const int i);
    void test();
  };

