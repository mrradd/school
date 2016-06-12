/******************************************************************************
* Conrad Horton
* CSC215 May 2016
* 06082016
* Asgn 4.2 Rational Number
******************************************************************************/

#include <iostream>
#include "RationalNumber.h"

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
  int  i      = 0;
  bool quit   = false;
  
  RationalNumber fraction1;
  RationalNumber fraction2;
  
  do
    {
    printMenu();
    getline(cin, userEntry, '\n');
    
    char* garbage = nullptr;
    long i        = strtol(userEntry.c_str(), &garbage, 10);
    
    cin.clear();
    userEntry.clear();
    
    switch(i)
      {
      /** Make fraction1 */
      case 1:
        cout << "Enter a fraction (e.g. 2/3)." << endl;
        getline(cin, userEntry, '\n');
        fraction1 = RationalNumber(userEntry);
      break;

      /** Make fraction2 */
      case 2:
        cout << "Enter a fraction (e.g. 4/6)." << endl;
        getline(cin, userEntry, '\n');
        fraction2 = RationalNumber(userEntry);
      break;
      
      /** Print fractions. */
      case 3:
        cout << "fraction1 = " << fraction1.toString() << endl;
        cout << "fraction2 = " << fraction2.toString() << endl;
      break;
      
      /** Compare fractions. */
      case 4:
        cout << fraction1.toString() << " == " << fraction2.toString() << " = " << (fraction1 == fraction2) << endl;
        cout << fraction1.toString() << " >  " << fraction2.toString() << " = " << (fraction1 >  fraction2) << endl;
        cout << fraction1.toString() << " >= " << fraction2.toString() << " = " << (fraction1 >= fraction2) << endl;
        cout << fraction1.toString() << " <  " << fraction2.toString() << " = " << (fraction1 <  fraction2) << endl;
        cout << fraction1.toString() << " <= " << fraction2.toString() << " = " << (fraction1 <= fraction2) << endl;
        cout << fraction1.toString() << " != " << fraction2.toString() << " = " << (fraction1 != fraction2) << endl;

        cout << fraction2.toString() << " == " << fraction1.toString() << " = " << (fraction2 == fraction1) << endl;
        cout << fraction2.toString() << " >  " << fraction1.toString() << " = " << (fraction2 >  fraction1) << endl;
        cout << fraction2.toString() << " >= " << fraction1.toString() << " = " << (fraction2 >= fraction1) << endl;
        cout << fraction2.toString() << " <  " << fraction1.toString() << " = " << (fraction2 <  fraction1) << endl;
        cout << fraction2.toString() << " <= " << fraction1.toString() << " = " << (fraction2 <= fraction1) << endl;
        cout << fraction2.toString() << " != " << fraction1.toString() << " = " << (fraction2 != fraction1) << endl;
      break;
      
      /** Sum of fractions. */
      case 5:
        cout << fraction1.toString() << " + " << fraction2.toString() << " = " << (fraction1 + fraction2).toString() << endl;
      break;
      
      /** Difference of fractions. */
      case 6:
        cout << fraction1.toString() << " - " << fraction2.toString() << " = " << (fraction1 - fraction2).toString() << endl;
        cout << fraction2.toString() << " - " << fraction1.toString() << " = " << (fraction2 - fraction1).toString() << endl;
      break;

      /** Product of fractions. */      
      case 7:
        cout << fraction1.toString() << " * " << fraction2.toString() << " = " << (fraction1 * fraction2).toString() << endl;
      break;

      /** Dividend of fractions. */      
      case 8:
        cout << fraction1.toString() << " / " << fraction2.toString() << " = " << (fraction1 / fraction2).toString() << endl;
      break;

      /** Reset fractions. */      
      case 9:
        fraction1 = RationalNumber();
        fraction2 = RationalNumber();
      break;
      
      /** Quit. */      
      case 10:
        quit = true;
      break;
      
      /** Bad input. */
      default:
      break;
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
  cout << "[1]Enter fraction1." << endl;
  cout << "[2]Enter fraction2." << endl;
  cout << "[3]Print fractions." << endl;
  cout << "[4]Compare fractions." << endl;
  cout << "[5]Sum of fractions." << endl;
  cout << "[6]Difference of fractions." << endl;
  cout << "[7]Product of fractions." << endl;
  cout << "[8]Dividend of fractions." << endl;
  cout << "[9]Reset fractions." << endl;
  cout << "[10]Quit." << endl;
  }
  