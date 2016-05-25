#include <iostream>
#include <sstream>
#include <string>
#include <cstdlib>

using namespace std;

/******************************************************************************
* Conrad Horton
* CSC215 May 2016
* 05192016
* Asgn 2.2 5 Function Calculator.
*******************************************************************************
*
* The purpose of this project is to give you an opportunity to apply your
* knowledge of functions in C++.
* 
* You must create a program that will act as a basic 5 function calculator.
* This program will ask the user which type of operation they would like to do
* (Addition, Subtraction, Multiplication, or Division or Quit).  If not Quit,
* enter a loop.  the program will then prompt for 2 values.
* The program will then do the appropriate calculation and display the answer.
* The program will then again ask which function they want to do. This will be
* the last line of the loop.  In other words, while the user does not choose
* Quit, the program will process another type and the 2 entered numbers.
* The program will use functions to gather the information from the user, and
* also use functions to perform the calculations and display the answer.
* 
* For this project you must create a C++ project that will:
* $Include separate functions to perform the following:
* $Prompt for user to enter a numeric value.  (this will be used twice.) 
* $Prompt for user to enter the type of calculation. ( + - * / )
* $perform the calculation. (one each for addition, subtraction, multiplication,
*   and division)
* $display the full results of the calculation. (see below for sample output.)
* $This program will use all double precision variables.
* $All variables should be local to the functions they are needed in, and passed
*   appropriately. (NO Globals!)
* $The program should loop continuously until the user decides they are done.
* $The program should then pause and wait for the user to press a key before
*   closing.
* $The final output should show the complete calculation:
* 
* Example:
* 12.4 + 5.32 = 17.72
* Or:
* 3.0 * 2.5 = 7.5
* Recommendations for function names:
* 
* double getUserValue();
* char getCalculationType();
* double performAddition(double valueOne, double valueTwo);
* double performSubtraction(double valueOne, double valueTwo);
* double performMultiplication(double valueOne, double valueTwo);
* double performDivision(double valueOne, double valueTwo);
* void displayResults(double valueOne, double valueTwo, char calculationSymbol,
* double answerValue);
******************************************************************************/

bool          term();
const double  getDouble();
char          getOperator();
void          doMath(const char operation = '+', const double d1 = 1.0, const double d2 = 2.0);

int main()
  {
  while(true)
    {
    /** NOTE: It's odd that the methods are called from right to left. */
    doMath(getOperator(), getDouble(), getDouble());
    if (term()) break;
    }

  system("pause");
  return 1;
  }

/******************************************************************************
* doMath */
/**
* Checks the operator, performs the operation on the two passed in values, and
* displays the equation with the answer.
*
* @param  d1         Double value entered by user.
* @param  d2         Double value entered by user.
* @param  operation  Operator character to invoke on the two values. Using a
*                    string for this is overkill, but string are easier.
******************************************************************************/
void doMath(const char operation, const double d1, const double d2)
  {
  double result = 0.0;

  if (operation == '+')
    result = d2 + d1;
  else if (operation == '-')
    result = d2 - d1;
  else if (operation == '*')
    result = d2 * d1;
  else if (operation == '/')
    result = d2 / d1;

  stringstream ss;
  ss << "\n" << d2 << " " << operation << " " << d1 << " " << " = " << result;
  cout << ss.str() << endl;
  }

/******************************************************************************
* getDouble */
/**
* Ask user to input a double, validate it is a double, and return the value.
*
* @ returns a valid double that was enterred by user.
******************************************************************************/
const double getDouble()
  {
  string buffer;
  cout << "\nEnter a number..." << endl;

  getline(cin, buffer, '\n');

  if (!buffer.empty())
    {
    errno = 0;
    char *garbage = nullptr;

    /** strtod gives val if good, and 0.0 if bad. */
    double destination = strtod(buffer.c_str(), &garbage);

    if(*garbage == '\0' && errno != ERANGE)
      return destination;
    }

  return 0.0;
  }

/******************************************************************************
* getOperator */
/**
* Ask user to choose an operator from +-/* . Validates input, and returns
* operatpor. For bad input, returns '+'
*
* @ returns an operation character that was enterred by user.
******************************************************************************/
char getOperator()
  {
  string buffer;
  cout << "\nEnter an operator..." << endl;

  getline(cin, buffer, '\n');

  if (buffer.empty() || (!buffer.empty() && !(buffer == "+" || buffer == "-" || buffer == "*" || buffer == "/")))
    buffer = "+";

  return *buffer.c_str();
  }

/******************************************************************************
* term */
/**
* Ask user if they wish to terminate the program. 
******************************************************************************/
bool term()
  {
  std::string terminalVal = "";
  
  /** See if the user wants to go again. */
  std::cout << "\n[Y] to go again.\n[N] to quit." << std::endl;
  getline(cin, terminalVal, '\n');
  for(;;)
    {
    /** Quit the program. */
    if (tolower(terminalVal[0]) == 'n')
      return true;

    /** Make another tree. */
    else if (tolower(terminalVal[0]) == 'y')
      return false;

    /** Incorrect input. */
    else
      {
      std::cout << "[Y] to go again.\n[N] to quit." << std::endl;
      std::cin  >> terminalVal;
      }
    }

  }