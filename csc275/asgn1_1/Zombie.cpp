
#include "Zombie.h"

/*******************************************************************************
* CTOR */
/**
* @param  hp           Hit points. Default 0.
* @param  baseAttack   Base attack. Default 0.
* @param  size         Name. Default = 0.
* @param  attackBonus  Class of the obj. Default = 0.
*******************************************************************************/
Zombie::Zombie(int hp, int baseAttack, int size, int attackBonus)
  {
  setHP        ();
  setBaseAttack();
  setBaseAttack();
  mSize = size;
  }
/**
* Copy CTOR.
* @param  obj  Reference to a Zombie object.
*******************************************************************************/
Zombie::Zombie(const Zombie& obj) : Character(obj)
  {
  mSize        = obj.mSize;
  mAttackBonus = obj.mAttackBonus;
  }

/*******************************************************************************
* DTOR */
/**
*******************************************************************************/
Zombie::~Zombie(){}

/*******************************************************************************
* SETTER/GETTERS
*******************************************************************************/
void Zombie::setSize       (int size) { mSize = size; }
int  Zombie::getSize       ()         { return mSize; }
void Zombie::setAttackBonus()         { mAttackBonus = mSize * (mSize > -1 ? 1 : -1); }
int  Zombie::getAttackBonus()         { return mAttackBonus; }


/*******************************************************************************
* OPERATORS
*******************************************************************************/
Zombie& Zombie::operator= (const Zombie& rhs)
  {
  /** Doing a temp/swap avoids needing to check for self assignment. **/
  Zombie temp(rhs);
  swap (temp);
  return *this;
  }

/*******************************************************************************
* print */
/**
* Prints only properties of this class.
*
* @param  printAll  True=Print this class and parent info. False=Only this class.
*******************************************************************************/
void Zombie::print(bool printAll)
  {
  stringstream ss;
  ss << "Zombie\n" << "Size: " << mSize << "\nAttack Bonus: " << mAttackBonus;
  
  if (printAll)
    Character::printInfo();
  }

/*******************************************************************************
* printInfo */
/**
* Prints all properties of this object.
*******************************************************************************/
void Zombie::printInfo()
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
void Zombie::swap(const Zombie& ref)
  {
  Character::swap(ref);
  mSize  = ref.mSize;
  mAttackBonus = ref.mAttackBonus;
  }
  
  