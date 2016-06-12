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
  
  bool quit = false;
  
  do
    {
    printMenu();
    getline(cin, userEntry, '\n');

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
  