#include "Strukt.h"

int Strukt::counter = 0;

/*******************************************************************************
* CTOR */
/**
*******************************************************************************/
Strukt::Strukt()
  {
  number = ++counter;
  std::cout << "Strukt::Strukt(" << number << ")" << std::endl;
  }
  
/*******************************************************************************
* ~DTOR */
/**
*******************************************************************************/
Strukt::~Strukt()
  {
  std::cout << "~Strukt::Strukt(" << number << ")" << std::endl;
  }