
#pragma once
#include "Character.h"

class Zombie : Character
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
    Zombie (int hp = 0, int baseAttack = 0, int size = 0, int attackBonus = 0);
    Zombie (const Zombie& obj);
    virtual ~Zombie();

  /** Operators **/
  public:
    Zombie& operator= (const Zombie& rhs);

  /** METHODS **/
  public:
            void print    (bool printAll);
    virtual void printInfo();
    virtual void swap     (const Zombie& ref);
  };