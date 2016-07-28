
#include "Character.h"

/*******************************************************************************
* CTOR */
/**
* Inits basic properties.
*
* @param  hp          Hit points.
* @param  baseAttack  Base attack value.
*******************************************************************************/
Character::Character(int hp, int baseAttack)
  {
  setHP        (hp);
  setBaseAttack(baseAttack);
  }
/**
* Copy CTOR.
* @param  rhs  Reference to a Character object.
*******************************************************************************/
Character::Character(const Character& ref)
  {
  this->setHP        (ref.mHP);
  this->setBaseAttack(ref.mBaseAttack);
  }

/*******************************************************************************
* DTOR */
/**
*******************************************************************************/
Character::~Character(){}

/*******************************************************************************
* SETTER/GETTERS
*******************************************************************************/
void Character::setHP (int hp)
  {
  if (hp < 0)
    cout << "\nvoid Character::setHP(): " << hp <<
      " is an invalid value. Setting to 0." << endl;

  mHP = hp < 0 ? 0 : hp;
  }

int  Character::getHP(){ return mHP; }

void Character::setBaseAttack(int attack)
  {
  if (attack < 1)
    cout << "\nCharacter::setBaseAttack(): " << attack <<
      " is an invalid value. Setting to 1." << endl;

  mBaseAttack = attack < 1 ? 1 : attack;
  }

int Character::getBaseAttack() { return mBaseAttack; }

/*******************************************************************************
* OPERATORS
*******************************************************************************/
Character& Character::operator= (const Character& rhs)
  {
  /** Doing a temp/swap avoids needing to check for self assignment. **/
  Character temp(rhs);
  swap (temp);
  return *this;
  }

/*******************************************************************************
* swap */
/**
* Deep copies data.
*
* @param  ref  Character reference.
*******************************************************************************/
void Character::swap(const Character& ref)
  {
  mHP         = ref.mHP;
  mBaseAttack = ref.mBaseAttack;
  }

/*******************************************************************************
* printInfo */
/**
* Prints the properties of the object.
*******************************************************************************/
void Character::printInfo()
  {
  ostringstream os;
  os << "HP: " << mHP << "\nBase Attack: " << mBaseAttack;
  cout << os.str() << "\n";
  }
  
  
  