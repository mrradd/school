
#include "Word.h"

/*******************************************************************************
* CTOR */
/**
*******************************************************************************/
Word::Word(std::string word)
  {
  mString = word;
  mCount  = 0;
  }

/*******************************************************************************
* DTOR */
/**
*******************************************************************************/
Word::~Word(){}

/*******************************************************************************
* SETTER/GETTERS
*******************************************************************************/  
void         Word::setString(std::string str) { mString = str;  }
std::string& Word::getString()                { return mString; }
int          Word::getCount ()                { return mCount;  }

/*******************************************************************************
* incrementCount */
/**
* Increments the counter.
*******************************************************************************/
void Word::incrementCount() { mCount++; }

/*******************************************************************************
* toString */
/**
* Stringifies and formats class properties.
*
* @returns  Formatted string of properties.
*******************************************************************************/
string Word::toString()
  {
  std::stringstream ss;
  int w = 20 - mString.length();
  ss << mString << std::setw(w) << mCount << " ocurrences" << std::endl;
  return ss.str();
  }