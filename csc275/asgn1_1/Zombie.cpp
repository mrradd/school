
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
  : Character(hp, baseAttack)
  {
  mSize = size;
  setAttackBonus();
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
void Zombie::setSize(int size)
  {
  if (size < 0)
    {
    cout << "\nvoid Zombie::setSize(): " << size <<
      " is an invalid value. Setting to 0." << endl;
    mSize = 0;
    }

  mSize = size;
  }
int  Zombie::getSize       () { return mSize; }
void Zombie::setAttackBonus() { mAttackBonus = mSize * (mSize > -1 ? mHP/6 : -1); }
int  Zombie::getAttackBonus() { return mAttackBonus; }

/*******************************************************************************
* OPERATORS
*******************************************************************************/
Zombie& Zombie::operator= (const Zombie& rhs)
  {
  /** Doing a temp/swap avoids needing to check for self assignment. **/
  Zombie temp(rhs);
  swap(temp);
  return *this;
  }

/*******************************************************************************
* print */
/**
* Prints Zombie props if false, and Zombie+Character props if true.
*
* @param  printAll  True=Print Zombie and parent info. False=Only Zombie.
*******************************************************************************/
void Zombie::printInfo(bool printAll)
  {
  stringstream ss;
  ss << "\nZombie\n" << "Size: " << mSize << "\nAttack Bonus: " << mAttackBonus;
  
  cout << ss.str()<<"\n";
    
  if (printAll)
    Character::printInfo();
  }

/*******************************************************************************
* printInfo */
/**
* Prints Zombie+Character properties.
*******************************************************************************/
void Zombie::printInfo()
  {
  printInfo(true);
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
  
  