#pragma once
#include <iostream>
#include <cstdlib>
#include <ctime>
#include <string>
#include <cctype>
#include <iomanip>

/******************************************************************************
This class will make a tree of user specified characters and of random height.
* 
* E.g.
*          *
*         ***
*        *****
*       *******
*      *********
*     ***********
*    *************
*   ***************
*  *****************
* *******************
* 
******************************************************************************/
class ASCIITree
  {
  /** Data Members. */
  private:
    std::string mSymbol;

  /** CTOR/DTOR */
  public:
    ASCIITree() { mSymbol = "*"; };
    ~ASCIITree(){};

  /** Methods */
  public:
    static void loop();
  
  };

