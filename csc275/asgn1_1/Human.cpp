
#include "Human.h"

/*******************************************************************************
* CTOR */
/**
* Inits basic properties.
*
* @param  hp          Hit points. Default 0.
* @param  baseAttack  Base attack. Default 0.
* @param  name        Name. Default = "".
* @param  clazz       Class of the obj. Default = "".
*******************************************************************************/
Human::Human(int hp, int baseAttack, const string name, const string clazz)
  : Character(hp, baseAttack)
  {
  mName  = name;
  mClass = clazz;
  }

/**
* Copy CTOR.
* @param  obj  Reference to a Human object.
*******************************************************************************/
Human::Human(const Human& obj) : Character(obj)
  {
  mName  = obj.mName;
  mClass = obj.mClass;
  }

/*******************************************************************************
* DTOR */
/**
*******************************************************************************/
Human::~Human(){}

/*******************************************************************************
* SETTER/GETTERS
*******************************************************************************/
void   Human::setName (string name)  { mName = name;   }
string Human::getName ()             { return mName;   }
void   Human::setClass(string clazz) { mClass = clazz; }
string Human::getClass()             { return mClass;  }

/*******************************************************************************
* OPERATORS
*******************************************************************************/
Human& Human::operator= (const Human& rhs)
  {
  /** Doing a temp/swap avoids needing to check for self assignment. **/
  Human temp(rhs);
  swap (temp);
  return *this;
  }

/*******************************************************************************
* print */
/**
* Prints only the properties of this class.
*
* @param  printAll  True=Print this class and parent info. False=Only this class.
*******************************************************************************/
void Human::print(bool printAll)
  {
  stringstream ss;
  ss << "Human\n" << "Name: " << mName << "\nClass: " << mClass;
  
  if (printAll)
    Character::printInfo();
  }

/*******************************************************************************
* printInfo */
/**
* Prints all properties of this object.
*******************************************************************************/
void Human::printInfo()
  {
  print(true);
  }
  
/*******************************************************************************
* swap */
/**
* Deep copies data.
*
* @param  ref  Character reference.
*******************************************************************************/
void Human::swap(const Human& ref)
  {
  Character::swap(ref);
  mName  = ref.mName;
  mClass = ref.mClass;
  }
  
  