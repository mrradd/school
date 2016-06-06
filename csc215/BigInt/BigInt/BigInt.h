#pragma once

#include <iostream>
#include <cstdlib>
#include <sstream>
#include <string>
#include <vector>

#define MAXSIZE 40
#define BADVALUE 9001

using namespace std;

class BigInt
  {
  private:
    /** Data Members. */
    /** Enums */
    enum { eMaxSize = 40, eMaxIndex = 39, eNullValue = 9001 };

    /** Properties. */
    /** Array where each element is a single digit. */
    int mDigits[eMaxSize];

    /** Name of object. Mainly for testing. */
    string mName;

    /** Position in the array. */
    int mPosition;

    /** Used elements in the array. */
    int mSize;

  public:
    
    /** CTOR/DTOR */
    BigInt(const string name = "");
    virtual ~BigInt();
    
    /** Setters/Getters. */
    const unsigned int getIndexOfLeadingDigit() const;
    unsigned int getSize();

    /** Comparison. */
    bool isEqualTo             (const BigInt& rhs);
    bool isGreaterThan         (const BigInt& rhs);
    bool isGreaterThanOrEqualTo(const BigInt& rhs);
    bool isLessThan            (const BigInt& rhs);
    bool isLessThanOrEqualTo   (const BigInt& rhs);
    bool isNotEqualTo          (const BigInt& rhs);
    bool isZero                ();
    
    /** Methods. */
    void add     (const BigInt& rhs);
    void input   ();
    void output  ();
    void pushInt (const int i);
    void subtract(const BigInt& rhs);
  };

