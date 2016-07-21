
#pragma once

#include <cstdlib>
#include <iostream>
#include <sstream>
#include <string>

using namespace std;

class Character
  {
  /** DATA MEMBERS **/
  private:
    int mHP;
    int mBaseAttack;

    /** This will be used for Pimpl exception safety. **/
    auto_ptr<Character> mPimpl;

  /** SETTERS/GETTERS **/
  public:
    virtual void setHP        (int hp = 1);
    virtual int  getHP        ();
    virtual void setBaseAttack(int attack = 1);
    virtual int  getBaseAttack();

  /** CTORS **/
  public:
    Character(int hp = 0, int baseAttack = 0);
    Character(const Character& ref);
    virtual ~Character();

  /** Operators **/
  public:
    Character& operator= (const Character& rhs);

  /** METHODS **/
  public:
    virtual void swap     (Character& ref);
    virtual void printInfo();
  };