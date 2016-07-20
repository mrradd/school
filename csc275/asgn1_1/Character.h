
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

  /** SETTERS/GETTERS **/
  public:
    virtual void setHP        (int hp = 1);
    virtual int  getHP        ();
    virtual void setBaseAttack(int attack = 1);
    virtual int  getBaseAttack();

  /** CTORS **/
  public:
    Character(int hp = 0, int baseAttack = 0);
    Character(const Character& obj);
    virtual ~Character();

  /** METHODS **/
  public:
    virtual void printInfo();
  };