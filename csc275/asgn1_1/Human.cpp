
#include "Human.h"

/******************************************************************************
* CTOR */
/**
* Inits basic properties.
******************************************************************************/
Human::Human(int hp, int baseAttack, const string name, const string clazz) : Character(hp, baseAttack)
  {
  mName  = name;
  mClass = clazz;
  }

/**
* Copy CTOR.
* @param  obj  Reference to a Human object.
******************************************************************************/
Human::Human(const Human& obj) : Character(obj)
  {
  mName  = obj.mName;
  mClass = obj.mClass;
  }

/******************************************************************************
* DTOR */
/**
******************************************************************************/
Human::~Human(){}

/******************************************************************************
* SETTER/GETTERS
******************************************************************************/
void   Human::setName (string name)  { mName = name;   }
string Human::getName ()             { return mName;   }
void   Human::setClass(string clazz) { mClass = clazz; }
string Human::getClass()             { return mClass;  }

/******************************************************************************
* printInfo */
/**
* Prints the properties of the object.
******************************************************************************/
void Human::printInfo()
  {

  }