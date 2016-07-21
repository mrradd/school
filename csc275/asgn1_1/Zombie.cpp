
#include "Zombie.h"

/******************************************************************************
* CTOR */
/**
* Inits basic properties.
******************************************************************************/
Zombie::Zombie()
  {
  setHP        ();
  setBaseAttack();
  }
/**
* Copy CTOR.
* @param  obj  Reference to a Zombie object.
******************************************************************************/
Zombie::Zombie(const Zombie& obj) : Character(obj)
  {
  mSize        = obj.mSize;
  mAttackBonus = obj.mAttackBonus;
  }

/******************************************************************************
* DTOR */
/**
******************************************************************************/
Zombie::~Zombie(){}

/******************************************************************************
* SETTER/GETTERS
******************************************************************************/
void Zombie::setSize       (int size) { mSize = size; }
int  Zombie::getSize       ()         { return mSize; }
void Zombie::setAttackBonus()         { mAttackBonus = mSize * (mSize > -1 ? 1 : -1); }
int  Zombie::getAttackBonus()         { return mAttackBonus; }


/******************************************************************************
* printInfo */
/**
* Prints the properties of the object.
******************************************************************************/
void Zombie::printInfo()
  {

  }