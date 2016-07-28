
#pragma once
#include "Character.h"
#include <cmath>

class Zombie : public Character
  {
  /** DATA MEMBERS **/
  private:
    int mSize;
    int mAttackBonus;

  /** SETTERS/GETTERS **/
  public:
    virtual void setSize       (int size = 1);
    virtual int  getSize       ();
    virtual void setAttackBonus();
    virtual int  getAttackBonus();

  /** CTORS **/
  public:
    Zombie (int hp = 3, int baseAttack = 1, int size = 0, int attackBonus = 0);
    Zombie (const Zombie& obj);
    virtual ~Zombie();

  /** Operators **/
  public:
    Zombie& operator= (const Zombie& rhs);

  /** METHODS **/
  public:
    virtual void printInfo();
            void printInfo(bool printAll);
    virtual void swap     (const Zombie& ref);
  };