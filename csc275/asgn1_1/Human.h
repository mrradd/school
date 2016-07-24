
#pragma once

#include "Character.h"

class Human : Character
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
    Human(int hp = 0, int baseAttack = 0, const string name = "", const string clazz = "");
    Human(const Human& obj);
    virtual ~Human();

  /** Operators **/
  public:
    Human& operator= (const Human& rhs);

  /** METHODS **/
  public:
            void print    (bool printAll);
    virtual void printInfo();
    virtual void swap     (const Human& ref);
  };