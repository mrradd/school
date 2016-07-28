
#pragma once

#include "Character.h"

class Human : public Character
  {
  /** DATA MEMBERS **/
  private:
    string mName;
    string mClass;

  /** SETTERS/GETTERS **/
  public:
    virtual void   setName (string name);
    virtual string getName ();
    virtual void   setClass(string clazz);
    virtual string getClass();

  /** CTORS **/
  public:
    Human(int hp = 20, int baseAttack = 1, string name = "?", string clazz = "??");
    Human(const Human& obj);
    virtual ~Human();

  /** Operators **/
  public:
    Human& operator= (const Human& rhs);

  /** METHODS **/
  public:
            
    virtual void printInfo();
            void printInfo(bool printAll);
    virtual void swap     (const Human& ref);
  };