#pragma once
#include <iostream>

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
    char mChar;

  /** CTOR/DTOR */
  public:
    ASCIITree() { mChar = '*'; };
    ~ASCIITree(){};

  /** Methods */
  public:
    static bool loop();
  
  };

