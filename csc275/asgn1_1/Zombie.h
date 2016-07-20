
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
    Zombie();
    Zombie(const Zombie& c);
    virtual ~Zombie();

  /** METHODS **/
  public:
    virtual void printInfo();
  };