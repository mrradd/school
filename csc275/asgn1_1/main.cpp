/******************************************************************************
* Conrad Horton
* CSC275 July2016
* Asgn 1.1
* 20160724
*
* Create a base class of a character.  You need 2 attributes, methods to access
* and update these attributes, 2 constructors, and a printInfo() method that
* prints the attributes.  For the update of the attributes, one must have
* verification (for example, health cannot be a negative number).
* 
* Next, create 2 classes that inherit from the character class.  (for example,
* zombie and goblin).  Each class must have 2 additional attributes, methods to
* access and update these attributes, 2 constructors, and a printInfo() method
* that prints the attributes. The print method should use the character base
* method.  One of the constructors should use the base class constructor to
* set these values as well.
* 
* Next, you need to have an additional print method using polymorphism.  The
* second print method would only print a subset of the attributes.  Use a
* boolean value as the parameter that determines which printInfo() method is
* called.
* 
* Finally, write a Main() program that creates instances of all 3 classes and
* calls both print methods.
* NOTE:  The executable file is REQUIRED.  See the file VS - generate an
* executable file in Doc Sharing.
* 
* Extra credit (5 points)  - allow the user to enter all the values and give
* them responses if the values are not valid
******************************************************************************/
#include "Character.h"
#include "Human.h"
#include "Zombie.h"

int main()
  {
  Character* c = new Character(5, 5);

  int    hp;
  int    baseAttack;
  string humanName;
  string humanClass;
  int    zombieSize;

  cout << "Setting up Human character... " << endl;
  cout << "Enter Name for Human: ";
  cin  >> humanName;
  cout << "\nEnter Class for Human (e.g. Rogue, warrior): ";
  cin  >> humanClass;
  cout << "\nEnter HP for Human: ";
  cin  >> hp;
  cout << "\nEnter Base Attack for Human: ";
  cin  >> baseAttack;
  Character* h = new Human(hp, baseAttack, humanName, humanClass);

  cout << "\nSetting up Zombie character... " << endl;
  cout << "\nEnter size of Zombie > 0: ";
  cin  >> zombieSize;
  cout << "\nEnter HP for Zombie: ";
  cin  >> hp;
  cout << "\nEnter Base Attack for zombie: ";
  cin  >> baseAttack;
  Character* z = new Zombie(hp, baseAttack, zombieSize);

  cout << "\nPrinting default info for Base Class Character." << endl;
  c->printInfo();

  cout << "\nUsing virtual printInfo() to print child+parent info." << endl;
  h->printInfo();
  z->printInfo();

  cout << "\nUsing non-virtual printInfo(false) to print child info only." << endl;
  Human* human   = dynamic_cast<Human*>(h);
  Zombie* zombie = dynamic_cast<Zombie*>(z);
  
  human ->printInfo(false);
  zombie->printInfo(false);
  
  delete c;
  delete h;
  delete z;

  system("pause");
  }
  