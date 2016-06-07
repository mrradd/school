#include "BigInt.h"

/******************************************************************************
* CTOR */
/***
******************************************************************************/
BigInt::BigInt(const string name)
  {
  mName = name;

  /** Init the digit array. */
  for(int i = 0; i < eMaxSize; i++)
    mDigits[i] = 0;
  }

/******************************************************************************
* DTOR */
/***
******************************************************************************/
BigInt::~BigInt(){}

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
      if (this->mDigits[i] != rhs.mDigits[i])
        {
        result = false;
        break;
        }
      }
  else
    result = false;

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
  bool result = false;
  
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
  bool x = isGreaterThan(rhs);
  bool y = isEqualTo(rhs);
  bool result = !x && !y;
    
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
  bool x = isLessThan(rhs);
  bool y = isEqualTo(rhs);
  bool result = x || y;
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
  bool x = isLessThan(rhs);
  bool y = isGreaterThan(rhs);
  bool result = x || y;
  
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
  
  return result;
  }

/******************************************************************************
* Methods
******************************************************************************/
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
    if (*iter > 0)
      {
      for (vector<int>::iterator it = iter; it != vecSum.end(); it++)
        cout << *it;
        
      cout << endl;
      return;
      }

  cout << endl;
  }

/******************************************************************************
* clear */
/***
* Clears the digit array--makes all 0.
******************************************************************************/
void BigInt::clear()
  {
  for(int i = 0; i < eMaxIndex; i++)
    mDigits[i] = 0;
  }

/******************************************************************************
* input */
/***
* User enters up to 40 digits into the array. Checks for bad data.
******************************************************************************/
void BigInt::input ()
  {
  string      buffer;
  vector<int> vecTempDigits;

  cout << "Enter a number up to 40 digits long...";
  
  getline(cin, buffer, '\n');
  
  /** Validate size of number. */
  if(buffer.length()>40)
    {
    cout << "\n" << buffer << " is too large...";
    return;
    }

  /** Add the digits from string to array from back to front. Also validates
      each char of the string to ensure they are all digits. */
  for(int strLen = buffer.length()-1; strLen > -1; strLen--)
    {
    if(!isdigit(buffer.c_str()[strLen]))
      {
      cout << buffer << "contains at least one non-numeric character...";
      return;
      }

    /** Convert to int. */
    char c = buffer.c_str()[strLen];
    int  x = (int)c - '0';
    vecTempDigits.insert(vecTempDigits.begin(), x);
    }

  /** Everything went okay. Clear mDigits, and load it with the values of the temp vector. */
  clear();
  int j = eMaxIndex;
  for(int i = vecTempDigits.size()-1; i > -1; i--)
    {
    mDigits[j] = vecTempDigits[i];
    j--;
    }
  }

/******************************************************************************
* output */
/***
* Prints the contents of the indexes with good values. Prints a list of all
* the indexes with bad values.
******************************************************************************/
void BigInt::output()
  {
  cout << mName << "::output() \t";

  /** Print all the good values. */
  for(int i = getIndexOfLeadingDigit(); i <= eMaxIndex; i++)
    cout << mDigits[i];

  cout << endl;
  return;
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
    int l      = vecLarger[i];
    int s      = vecSmaller[i];
    int result = l - s - borrowVal;
    result     = result < 0 ? result + 10 : result;
    vecDiff.insert(vecDiff.begin(), (result));
    borrowVal  = result < 0 ? 1 : 0;
    }

  cout << "difference = " << negativeSign;

  for (vector<int>::iterator iter = vecDiff.begin(); iter != vecDiff.end(); iter++)
    if (*iter > 0)
      {
      for (vector<int>::iterator it = iter; it != vecDiff.end(); it++)
        cout << negativeSign << *it;
        
      cout << endl;
      return;
      }
  }

