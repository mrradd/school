/******************************************************************************
* Conrad Horton
* CSC215 May 2016
* 06022016
* Asgn 4.1 Huge Integer
*******************************************************************************
* Create a class HugeInteger that uses a 40-element array of digits to store
* integers as large as 40 digits each. Provide member functions input, output,
* add and subtract. For comparing HugeInteger objects, provide functions
* isEqualTo, isNotEqualTo, isGreaterThan, isLessThan, isCreaterThanOrEqualTo
* and isLessThanOrEqualTo - each of these is a "predicate" function that simply
* returns true if the relationship holds between the two HugeIntegers and
* returns false if the relationship does not hold. Also, provided predicate
* function isZero.
* 
* Recommendations for extra points:
* $Provide member functions multiply, divide, and modulus.
******************************************************************************/

#include <iostream>

#include "BigInt.h"
using namespace std;

void printMenu();
void handleMenu();

int main()
  {
  handleMenu();
  system("pause");
  return 1;
  }
  
/******************************************************************************
* handleMenu */
/**
* Prints the menu and handles user interaction.
******************************************************************************/
void handleMenu()
  {
  string userEntry = "";
  
  BigInt bigInt1 ("BigInt1");
  BigInt bigInt2 ("BigInt2");
  
  bool quit = false;
  
  do
    {
    printMenu();
    getline(cin, userEntry, '\n');

    /** Add to BigInt1. */
    if (userEntry == "1")
      { bigInt1.input(); }

    /** Add to BigInt2. */
    else if (userEntry == "2")
      { bigInt2.input(); }

    /** Print BigInts. */
    else if (userEntry == "3")
      {
      bigInt1.output();
      bigInt2.output();
      }

    /** BigInt1 is 0. */
    else if (userEntry == "4")
      {
      cout << "BigInt1 == 0 = " << bigInt1.isZero() << endl;
      }
      
    /** BigInt2 is 0. */
    else if (userEntry == "5")
      {
      cout << "BigInt2 == 0 = " << bigInt2.isZero() << endl;
      }
      
    /** Compare BigInt1 to BigInt2. */
    else if (userEntry == "6")
      {
      cout << "BigInt1 == BigInt2 = " << bigInt1.isEqualTo(bigInt2)              << endl;
      cout << "BigInt1 >  BigInt2 = " << bigInt1.isGreaterThan(bigInt2)          << endl;
      cout << "BigInt1 >= BigInt2 = " << bigInt1.isGreaterThanOrEqualTo(bigInt2) << endl;
      cout << "BigInt1 <  BigInt2 = " << bigInt1.isLessThan(bigInt2)             << endl;
      cout << "BigInt1 <= BigInt2 = " << bigInt1.isLessThanOrEqualTo(bigInt2)    << endl;
      cout << "BigInt1 != BigInt2 = " << bigInt1.isNotEqualTo(bigInt2)           << endl;
      cout.flush();
      }

    /** Compare BigInt2 to BigInt1. */
    else if (userEntry == "7")
      {
      cout << "BigInt2 == BigInt1 = " << bigInt2.isEqualTo(bigInt1)              << endl;
      cout << "BigInt2 >  BigInt1 = " << bigInt2.isGreaterThan(bigInt1)          << endl;
      cout << "BigInt2 >= BigInt1 = " << bigInt2.isGreaterThanOrEqualTo(bigInt1) << endl;
      cout << "BigInt2 <  BigInt1 = " << bigInt2.isLessThan(bigInt1)             << endl;
      cout << "BigInt2 <= BigInt1 = " << bigInt2.isLessThanOrEqualTo(bigInt1)    << endl;
      cout << "BigInt2 != BigInt1 = " << bigInt2.isNotEqualTo(bigInt1)           << endl;
      cout.flush();
      }
      
    /** Sum of BigInt1 to BigInt2. */
    else if (userEntry == "8")
      { bigInt1.add(bigInt2); }
      
    /** Subtract of BigInt1 from BigInt2. */
    else if (userEntry == "9")
      { bigInt2.subtract(bigInt1); }
      
    /** Subtract of BigInt2 from BigInt1. */
    else if (userEntry == "10")
      { bigInt1.subtract(bigInt2); }
      
    /** Reset BigInts. */
    else if (userEntry == "11")
      {
      bigInt1 = BigInt("BigInt1");
      bigInt2 = BigInt("BigInt2");
      }
      
    /** Quitting. */
    else if (tolower(userEntry[0]) == 'q')
      { quit = true; }
      
    /** Incorrect input. */
    else
      {
      userEntry.clear();
      std::cout << "\nInvalid entry\n" << std::endl;
      }

    cin.clear();
    userEntry.clear();
    }
  while(!quit);
  }
  
/******************************************************************************
* printMenu */
/**
* Prints out the menu options. 
******************************************************************************/
void printMenu()
  {
  cout << "\n**********************************************************\n" << endl;
  cout << "[1]Enter numbers into BigInt1." << endl;
  cout << "[2]Enter numbers into BigInt2." << endl;
  cout << "[3]Print BigInts." << endl;
  cout << "[4]BigInt2 is 0?" << endl;
  cout << "[5]BigInt2 is 0?" << endl;
  cout << "[6]Compare BigInt1 to BigInt2." << endl;
  cout << "[7]Compare BigInt2 to BigInt1." << endl;
  cout << "[8]Sum of BigInt1 and BigInt2." << endl;
  cout << "[9]Subtract BigInt1 from BigInt2." << endl;
  cout << "[10]Subtract BigInt2 from BigInt1." << endl;
  cout << "[11]Reset BigInts." << endl;
  cout << "[Q]uit." << endl;
  }
  