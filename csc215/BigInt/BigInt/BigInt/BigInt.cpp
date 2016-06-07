#include "BigInt.h"

/******************************************************************************
* CTOR */
/***
******************************************************************************/
BigInt::BigInt(const string name)
  {
  mSize = 0;
  mName = name;

  /** Init the digit array. */
  for(int i = 0; i < eMaxSize; i++)
    mDigits[i] = 0;

  mPosition = eMaxIndex;
  }

/******************************************************************************
* DTOR */
/***
******************************************************************************/
BigInt::~BigInt()
  {
  }

/******************************************************************************
* Setters/Getters
******************************************************************************/
/******************************************************************************
* getIndexOfLeadingDigit */
/***
* @returns  Lowest index, with a non 0 or eNullValue integer.
******************************************************************************/
const unsigned int BigInt::getIndexOfLeadingDigit() const
  {
  unsigned int iMaxIndex = eMaxIndex;
  for(unsigned int i = 0; i <= eMaxIndex; i++)
    if (mDigits[i] != 0)
      return i;

  return iMaxIndex;
  }

/******************************************************************************
* getSize */
/***
* @returns  Number of good indexes.
******************************************************************************/
unsigned int BigInt::getSize()
  {
  return mSize;
  }

/******************************************************************************
* Logical Comparisons
******************************************************************************/
/******************************************************************************
* isEqualTo */
/***
* Checks if all valid digits are of equal value, and that the array size is
* the same.
*
* @param  rhs  BigInt to check if queal to.
* @returns  Equal=true. !Equal=false.
******************************************************************************/
bool BigInt::isEqualTo(const BigInt& rhs)
  {
  bool result = true;
  
  /** If leading non 0 digit is the same index, potential for equality. */
  if(getIndexOfLeadingDigit() == rhs.getIndexOfLeadingDigit())
    for(int i = eMaxIndex; i >= 0; i--)
      {
      /** Check both valid values, and digits aren't equal. */
      if (this->mDigits[i] != eNullValue && rhs.mDigits[i] != eNullValue &&
          this->mDigits[i] != rhs.mDigits[i])
        result = false;
      }
  else
    result = false;

  //cout << mName << " == " << rhs.mName << " = " << result << endl;

  /** Passed verification. */
  return result;
  }

/******************************************************************************
* isGreaterThan */
/***
* Checks if this is greater than passed BigInt.
*
* @param  rhs  BigInt to check if greater than.
* @returns  Greater=true. Lesser=false.
******************************************************************************/
bool BigInt::isGreaterThan(const BigInt& rhs)
  {
  bool result = true;
  
  /** If leading non 0 digit is higher index, this is bigger. */
  if(getIndexOfLeadingDigit() < rhs.getIndexOfLeadingDigit())
    result = true;

  /** This has higher leading int index. */
  else if(getIndexOfLeadingDigit() > rhs.getIndexOfLeadingDigit())
    result = false;

  /** Leading integer has the same index, so length is equal. */
  for(int i = getIndexOfLeadingDigit(); i <= eMaxIndex; i++)
    {
    /** Two digits are not the same value. */
    if (this->mDigits[i] != rhs.mDigits[i])
      {
      /** Greater than. */
      if (this->mDigits[i] > rhs.mDigits[i])
        {
        result = true;
        break;
        }
        
      /** Less than. */
      else if (this->mDigits[i] < rhs.mDigits[i])
        {
        result = false;
        break;
        }
      }
    }
    
  //cout << mName << " > " << rhs.mName << " = " << result << endl;
  return result;
  }

/******************************************************************************
* isGreaterThanOrEqualTo */
/***
* @param  rhs  BigInt to check if greater than or equal to.
* @returns  Value of isGreaterThan or isEqualTo.
******************************************************************************/
bool BigInt::isGreaterThanOrEqualTo(const BigInt& rhs)
  {
  bool result = isGreaterThan(rhs) || isEqualTo(rhs);
  
  //cout << mName << " >= " << rhs.mName << " = " << result << endl;  
  
  return result;
  }

/******************************************************************************
* isLessThan */
/***
* @param  rhs  BigInt to check if less than.
* @returns  Opposite of isGreaterThan. 
******************************************************************************/
bool BigInt::isLessThan(const BigInt& rhs)
  {
  bool result = !isGreaterThan(rhs);
  
  //cout << mName << " < " << rhs.mName << " = " << result << endl;  
  
  return result;
  }

/******************************************************************************
* isLessThanOrEqualTo */
/***
* @param  rhs  BigInt to check if less than or equal to.
* @returns  isLessThan || isEqualTo
******************************************************************************/
bool BigInt::isLessThanOrEqualTo(const BigInt& rhs)
  {
  bool result = isLessThan(rhs) || isEqualTo(rhs);
  
  //cout << mName << " <= " << rhs.mName << " = " << result << endl;
  
  return result;
  }

/******************************************************************************
* isNotEqualTo */
/***
* @param  rhs  BigInt to check if not equal to.
* @returns  Opposite of isEqualTo. 
******************************************************************************/
bool BigInt::isNotEqualTo(const BigInt& rhs)
  {
  bool result = !isEqualTo(rhs);
  
  //cout << mName << " != " << rhs.mName << " = " << result << endl;
  
  return result;
  }

/******************************************************************************
* isZero */
/***
* @returns  If this array is 0.
******************************************************************************/
bool BigInt::isZero()
  {
  bool result = mDigits[getIndexOfLeadingDigit()] == 0;
  
  //cout << mName << " == 0 = " << result << endl;
  
  return result;
  }

/******************************************************************************
* Add */
/***
* Adds this to the passed in BigInt.
*
* @param  rhs  BigInt as addend.
******************************************************************************/
void BigInt::add(const BigInt& rhs)
  {
  
  /** Vector for sum of legit values. */
  vector<int> vecSum;
  int carryVal = 0;

  for(int i = eMaxIndex; i > -1; i--)
    {
    int  x1      = rhs.mDigits[i];
    int  x2      = mDigits[i];
    bool validX1 = x1 > -1 && x1 < 10;
    bool validX2 = x2 > -1 && x2 < 10;
    int  sum     = (validX1 ? x1 : 0) + (validX2 ? x2 : 0) + carryVal;
    carryVal     = sum > 9 ? 1 : 0;
    
    /** Adjust the sum if it goes into tens place. */
    sum = sum > 9 ? sum - 10 : sum;

    vecSum.insert(vecSum.begin(), sum);
    }

  cout << "Sum = ";

  for (vector<int>::iterator iter = vecSum.begin(); iter != vecSum.end(); iter++)
    cout << *iter;

  cout << endl;
  }

/******************************************************************************
* input */
/***
******************************************************************************/
void BigInt::input ()
  {
  string buffer;
  int i = 9001;
  cout << "Enter a # between 0 and 9 inclusive...";
  
  getline(cin, buffer, '\n');
  if (!buffer.empty())
    {
    errno = 0;
    char *garbage = nullptr;

    /** strtol gives val if good, and 0.0 if bad. */
    i = strtol(buffer.c_str(), &garbage, 10);

    if(i <= 9 && i >= 0)
      pushInt(i);
    else
      {
      cout << "1? Okay, 1 it is..." << endl;
      pushInt(1);
      }
    
    }
  else if(buffer.empty())
    {
    cout << "0? Okay, 0 it is..." << endl;
    pushInt(0);
    }
  }

/******************************************************************************
* output */
/***
* Prints the contents of the indexes with good values. Prints a list of all
* the indexes with bad values.
******************************************************************************/
void BigInt::output ()
  {
  cout << mName << "::output() \t";

  /** Print all the good values. */
  for(int i = getIndexOfLeadingDigit(); i <= eMaxIndex; i++)
    cout << mDigits[i];

  cout << endl;
  return;
  }

/******************************************************************************
* pushInt */
/***
* Pushes an int onto the next available element from the back and increments
* size.
*
* @param  i  Integer to push onto the array.  
******************************************************************************/
void BigInt::pushInt (const int i)
  {
  /** Passed in value is 0-9, array size is in parameters, and the current
      location is a bad value (able to be written to). */
  if (i >= 0 && i <= 9 && mSize < eMaxSize)
    {
    mDigits[eMaxIndex - mSize] = i;
    mSize++;
    }
  else
    cout << mName << "::pushInt()\tDidn't insert "<< i << " to [" << eMaxIndex - mSize << "]." << endl;
  }

/******************************************************************************
* subtract */
/***
* Subtract this from the passed in BigInt. We will subtract the larger from the
* smaller and flip the signs to make it negative.
*
* @param  rhs  BigInt as addend.
******************************************************************************/
void BigInt::subtract(const BigInt& rhs)
  {
  /** Vector for difference values. */
  vector<int> vecDiff;
  vector<int> vecLarger;
  vector<int> vecSmaller;
  int borrowVal       = 0;
  string negativeSign = "";

  /** We want to find the larger array, so we subtract the smaller one from it. */
  if (isLessThan(rhs))
    {
    vecSmaller = vector<int>(mDigits, mDigits + sizeof mDigits / sizeof mDigits[0]);
    vecLarger  = vector<int>(rhs.mDigits, rhs.mDigits + sizeof rhs.mDigits / sizeof rhs.mDigits[0]);
    negativeSign = "-";
    }
  else
    {
    vecLarger  = vector<int>(mDigits, mDigits + sizeof mDigits / sizeof mDigits[0]);
    vecSmaller = vector<int>(rhs.mDigits, rhs.mDigits + sizeof rhs.mDigits / sizeof rhs.mDigits[0]);    
    }
    
  int rhsLeadIndex = rhs.getIndexOfLeadingDigit();
  for(int i = vecLarger.size() - 1; i > -1; i--)
    {
    int result = vecLarger[i] - vecSmaller[i] - borrowVal;
    vecDiff.insert(vecDiff.begin(), (result < 0 ? result + 10 : result));
    borrowVal  = result < 0 ? 1 : 0;
    }

  cout << "difference = " << negativeSign;

  for (vector<int>::iterator iter = vecDiff.begin(); iter != vecDiff.end(); iter++)
    if (*iter > 0)
      {
      for (vector<int>::iterator it = iter; it != vecDiff.end(); it++)
        cout << *it;
        
      cout << endl;
      return;
      }
  }

