#include "stdio.h"
#include "stdlib.h"
#include <string>
#include <sstream>
#include <iostream>
#include <ctime>

using namespace std;

bool isDouble  (double& destination, string& source);
void print     (const char* s = "");
void printArray(double arr[], const string& arrName = "arr");
void printC    (const char* s);
void printD    (double d);
void sumArrays (double add1[], double add2[], double sum3[]);
void takeInput (double arr[], const string& arrName = "arr");
bool term      ();

/*******************************************************************************
* Conrad Horton
* CSC215 (May 2016)
* 20160514
* Assignment 2.1 - Arrays
* You must create a program that will contain three arrays.  The first two will
* be populated via user input, the third will be populated by adding the
* associated elements from array 1 and 2 together, and placing the answer in
* array 3. For this project you must create a C++ project that will:
* 
* $Create three arrays (4 elements each, data type will be double precision
*   floats)
* $Ask the user for the values to place in two of the arrays.
*   You will need for loops to accomplish much of this code...
* $Use cout to display the prompt to the user.
* $Prompt for user to enter each array value
*   Use cin to store the input.
* $Using a loop to cycle through, use cout to display each addition statement
*   with it's answer.
* $Using a loop to cycle through, use cout to display the contents of the third
*   array.
* $Program should then pause and wait for the user to press a key before
*   closing.
* 
* ADDITIONAL OPPORTUNITIES (optional modifications to provide more of a
* challenge)
* $Use random number generation to populate the first two arrays
* $After the final output is displayed, ask the user if they would like to run
*   the program again.
*     if they answer 'Y' for yes, the program should run again.
*     if they answer 'N' for no, the program should exit.
*******************************************************************************/
int main(int argc, char* argv[])
  {
  srand (time(NULL));

  
  /** Enter values until user quits. */
  while (!term())
    {
    double arrayOfDoubles1[]   = {0,0,0,0};
    double arrayOfDoubles2[]   = {0,0,0,0};
    double arrayOfDoubles3[]   = {0,0,0,0};

    print("You will now be asked to enter 8 floating point numbers.\n");

    /** Ask user for number if they want to generate random numbers for
        arrays 1 and 2. */
    std::string q;
    std::cout << "[Y] to generate random values." << std::endl;
    std::cin  >> q;

    if (tolower(q[0]) == 'y')
      {
      for (int n = 0; n < 4; n++)
        {
        arrayOfDoubles1[n] = rand() % 100 + 1;
        arrayOfDoubles2[n] = rand() % 100 + 1;
        printArray(arrayOfDoubles1, "arrayOfDoubles1");
        printArray(arrayOfDoubles2, "arrayOfDoubles2");
        }
      }
    else
      {
      /** Enter the values, then sum all values from arrayOfDoubles1 and arrayOfDoubles2, and put them in arrayOfDoubles3. */
      takeInput(arrayOfDoubles1, "arrayOfDoubles1");
      takeInput(arrayOfDoubles2, "arrayOfDoubles2");
      }
    
    sumArrays(arrayOfDoubles1, arrayOfDoubles2, arrayOfDoubles3);

    print("\nPrinting final arrays");
    printArray(arr1, "arrayOfDoubles1");
    printArray(arr2, "arrayOfDoubles2");
    printArray(arr3, "arrayOfDoubles3");

    }

  system("pause");

  return 0;
  }

/** Verifies if string is double, and assigns value if good. */
bool isDouble(double& destination, string& source)
  {
  bool pass = false;

  if (!source.empty())
    {
    errno = 0;
    char *garbage = nullptr;

    /** strtod gives val if good, and 0.0 if bad. */
    destination = strtod(source.c_str(), &garbage);

    pass = *garbage == '\0' && errno != ERANGE;
    }

  return pass;
  }

/** Print a line of text with line feed carriage return. */
void print(const char* s)
  {
  printC(s);
  cout << endl;
  }

/** Print a line of text. */
void printC(const char* s)
  {
  cout << s;
  }

/** Print a double. */
void printD(double d)
  {
  if (d != 0.0)
    cout << d;
  else
    printC("null");
  }

/** Prints the contents of an array, in array element format
    arrName[1.0, 2.0, 3.0, 4.0]. */
void printArray(double arr[], const string& arrName)
  {
  string name = arrName;
  printC((name+"[ ").c_str());
  
  for(int i = 0; i < 4; i++)
    {
    printD(arr[i]);
    if ((i+1) < 4)
      printC(",\t");
    }
  print(" ]");
  }

/** Sum of matching indices in add1 and add2 are placed into matching index in
    sum3. */
void sumArrays (double add1[], double add2[], double sum3[])
  {
  print("\n\nADDING UP ARRAYS");

  /** Hard coded to four, because that is all we need to deal with. */
  for (int i = 0; i < 4; i++)
    {
    stringstream ss;
    sum3[i] = add1[i] + add2[i];
    ss << add1[i] << "\t+\t" << add2[i] << "\t=\t" << sum3[i];
    print(ss.str().c_str());
    }
  }

/** Keeps looping until user enters enough valid values to fill the passed in
    array. Prints the array with each pass. */
void takeInput(double arr[], const string& arrName)
  {
  /** Enter values into first array. */
  print(("Input values into " + arrName).c_str());
  print("Enter a number:");
  for(int i = 0; i < 4; i++)
    {
    string buffer;
    getline(cin, buffer, '\n');
    while(!isDouble(arr[i], buffer))
      {
      print("Enter a VALID number:");
      getline(cin, buffer, '\n');
      }

    printArray(arr, arrName);
    print();
    }
  }

bool term(void)
  {
  std::string terminalVal = "";
  bool validInput         = false;
  bool terminateProgram   = false;
  
  /** See if the user wants to go again. */
  std::cout << "\n[Y] to go again.\n[N] to quit." << std::endl;
  std::cin  >> terminalVal;
  
  /** When we receive valid input (y or n) the method will return to the caller, otherwise valid input will be false. */
  while(!validInput)
    {
    validInput = true;
    
    /** Quit the program. */
    if (tolower(terminalVal[0]) == 'n')
      terminateProgram = true;

    /** Make more arrays. */
    else if (tolower(terminalVal[0]) == 'y')
      terminateProgram = false;

    /** Incorrect input. */
    else
      {
      validInput = false;
      std::cout << "[Y] to go again.\n[N] to quit." << std::endl;
      std::cin  >> terminalVal;
      }
    }
  return validInput;
  }