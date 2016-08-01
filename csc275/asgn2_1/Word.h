
#pragma once

#include <iostream>
#include <iomanip>
#include <sstream>
#include <string>

using namespace std;
class Word
  {
  /** DATA MEMBERS **/
  private:
    std::string mString;
    int         mCount; 

  /** SETTERS/GETTERS **/
  public:
    void         setString(std::string str);
    std::string& getString();
    int          getCount ();
    
  /** CTORS **/
  public:
    Word(std::string word);
    virtual ~Word();

  /** Operators **/
  public:

  /** METHODS **/
  public:
    void   incrementCount();
    string toString();
  };