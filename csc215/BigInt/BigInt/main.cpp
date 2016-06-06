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
    if (tolower(userEntry[0]) == 'a')
      { bigInt1.input(); }

    /** Add to BigInt2. */
    else if (tolower(userEntry[0]) == 'd')
      { bigInt2.input(); }

    /** Print BigInts. */
    else if (tolower(userEntry[0]) == 'p')
      {
      bigInt1.output();
      bigInt2.output();
      }

    /** BigInt1 is 0. */
    else if (tolower(userEntry[0]) == 'i')
      { bigInt1.isZero(); }
      
    /** BigInt2 is 0. */
    else if (tolower(userEntry[0]) == 'n')
      { bigInt2.isZero(); }
      
    /** Compare BigInt1 to BigInt2. */
    else if (tolower(userEntry[0]) == 'c')
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
    else if (tolower(userEntry[0]) == 'o')
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
    else if (tolower(userEntry[0]) == 's')
      { bigInt1.add(bigInt2); }
      
    /** Subtract of BigInt1 from BigInt2. */
    else if (tolower(userEntry[0]) == 'u')
      { bigInt2.subtract(bigInt1); }
      
    /** Subtract of BigInt2 from BigInt1. */
    else if (tolower(userEntry[0]) == 'b')
      { bigInt1.subtract(bigInt2); }
      
    /** Reset BigInts. */
    else if (tolower(userEntry[0]) == 'r')
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
      printMenu();
      getline(cin, userEntry, '\n');
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
  cout << "[A]dd numbers to BigInt1." << endl;
  cout << "A[D]d numbers to BigInt2." << endl;
  cout << "[P]rint BigInts." << endl;
  cout << "Big[I]nt2 is 0?" << endl;
  cout << "BigI[N]t2 is 0?" << endl;
  cout << "[C]ompare BigInt1 to BigInt2." << endl;
  cout << "C[O]mpare BigInt2 to BigInt1." << endl;
  cout << "[S]um of BigInt1 and BigInt2." << endl;
  cout << "S[U]btract BigInt1 from BigInt2." << endl;
  cout << "Su[B]tract BigInt2 from BigInt1." << endl;
  cout << "[R]eset BigInts." << endl;
  cout << "[Q]uit." << endl;
  }
  