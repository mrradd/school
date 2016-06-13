/******************************************************************************
* Conrad Horton
* CSC215 May 2016
* 20160609
* Final Part 2 
* Sources for calculations:
* https://momentummag.com/how-green-is-your-bicycle-manufacturing/
* https://www3.epa.gov/climatechange/Downloads/ghgemissions/GHGCalculator.xls
*******************************************************************************/
#include "CarbonFootPrint.h"
#include "Bike.h"
#include "Car.h"
#include "Building.h"
#include <iostream>
#include <vector>
#include <string>

using namespace std;

void printMenu ();
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
  
  vector<CarbonFootPrint*> emitters;

  bool quit = false;
  
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
      /** Make bike. */
      case 1:
        emitters.push_back(Bike::make());
      break;
      
      /** Make car. */
      case 2:
        emitters.push_back(Car::make());
      break;

      /** Make Building. */
      case 3:
        emitters.push_back(Building::make());
      break;
      
      /** Show emitters. */
      case 4:
        for (vector<CarbonFootPrint*>::iterator it = emitters.begin(); it != emitters.end(); ++it)
          (*it)->displayStats();
      break;

      /** Reset list. */
      case 5:
        for(int i = 0; i < emitters.size(); ++i)
          delete emitters[i];
        
        emitters.clear();
      break;

      /** Quit. */
      case 6:
        for(int i = 0; i < emitters.size(); ++i)
          delete emitters[i];
        emitters.clear();
        quit = true;
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
  cout << "\n**********************Carbon Emitters*********************\n" << endl;
  cout << "[1]Make Bike."              << endl;
  cout << "[2]Make Car."               << endl;
  cout << "[3]Make Building."          << endl;
  cout << "[4]Show all emitter stats." << endl;
  cout << "[5]Reset Emitters."         << endl;
  cout << "[6]Quit."                    << endl;
  }