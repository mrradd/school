/******************************************************************************
* Conrad Horton
* CSC215 May 2016
* 20160529 revised 20160601
* Asgn 3.1 5 Function Calculator.
*******************************************************************************
*
* Pointers, References, and Multiple-file - 5 function Calculator
* The purpose of this project is to give you an opportunity to apply your
* knowledge of functions, pointers, and references in creating a multiple-file
* application.
* 
* 
* Pointers and References
* You must create a basic 5 function calculator similar to the assignment from
* week 2. However, this program will use pointers and references in the functions
* rather than passing by value. The functions which perform the actual
* calculations should have pointers as parameters, while the display function
* should use references as parameters.
* 
* 
* Multiple-file Application
* This program must be done as a multiple file application, with the
* appropriate source and header files. Make sure that your functions are
* properly prototyped, and that the definitions are in the proper location.
* 
* With this program all of the function prototypes will be stored in a separate
* header (.h) file, and all function definitions will be stored in a separate
* source (.cpp) file with the same name as the header (.h) file.
* 
* The primary source (.cpp) file will only contain the necessary pre-processor
* directives, the namespace declaration, and the definition of the "main()"
* function.
* 
* You must ensure that this program works at least the same as the week 2
* version.  Although, additional content may be added to improve the program.
* (just make sure that it at least meets the minimum requirements.
* 
* 
* For this project you must create a C++ project that will:
* $ Include separate functions to perform the following:
*     $ Prompt for user to enter a numeric value.  (this will be used twice.) 
*     $ Prompt for user to enter the type of calculation. ( + - * / )
*     $ perform the calculation. (one each for addition, subtraction, multiplication,
*       and division)
*     $ display the FULL results of the calculation. (see below for sample output.)
* $ This program also needs to include the ability to store, retrieve, and clear
* $ a value in memory.
* $ This program should use all double precision variables.
* $ All variables should be local to the functions they are needed in, and passed
*   appropriately. (NO Globals!)
* $ The program should loop continuously until the user decides they are done.
*     $ Ask the user if they want to do another calculation.
*     $ This can also be done by running the entire program from a menu.
* $ The program should then pause and wait for the user to press a key before
* $ closing.
* 
* 
* The final output should show the complete calculation:
* Example:
* 12.4 + 5.32 = 17.72
* Or:
* 3.0 * 2.5 = 7.5
* 
* 
* Recommendations for extra points:
* $ Create one function which can do any of the four calculations;
* $ Have the function that asks for the type of calculation return a pointer, not
*   an actual character.
******************************************************************************/


#include "functions.h"

using namespace std;

int main()
  {
  
  do 
    {
    double* ptrDouble1 = new double(0);
    double* ptrDouble2 = new double(0);
    string  oper;

    *ptrDouble1 = *getDouble(); //I could have just done return by value, but I wanted to do this because reasons.
    oper        = getOperator();
    *ptrDouble2 = *getDouble();

    doMath(oper, ptrDouble1, ptrDouble2);

    delete ptrDouble1;
    delete ptrDouble2;
    }
  while(!terminateProgram());


  system("pause");
  return 1;
  }

/******************************************************************************
* doMath */
/**
* Checks the operator, performs the operation on the two passed in values, and
* displays the equation with the answer.
*
* @param  strRefOperator  String reference to operation to use.
* @param  ptrDouble1      Pointer to double value entered by user.
* @param  ptrDouble2      Pointer to double value entered by user.
******************************************************************************/
void doMath(const std::string& strRefOperator, const double* ptrDouble1, const double* ptrDouble2)
  {
  double result = 0.0;

  if (strRefOperator == "+")
    result = *ptrDouble1 + *ptrDouble2;
  else if (strRefOperator == "-")
    result = *ptrDouble1 - *ptrDouble2;
  else if (strRefOperator == "*")
    result = *ptrDouble1 * *ptrDouble2;
  else if (strRefOperator == "/")
    result = *ptrDouble1 / *ptrDouble2;

  stringstream ss;
  ss << "\n" << *ptrDouble1 << " " << strRefOperator << " " << *ptrDouble2 << " " << " = " << result;
  cout << ss.str() << endl;
  }

/******************************************************************************
* getDouble */
/**
* Ask user to input a double, validate it is a double, and return the value.
*
* @ returns pointer to a valid double that was enterred by user.
******************************************************************************/
double* getDouble()
  {
  string buffer;
  cout << "\nEnter a number..." << endl;
  
  double d = -1;

  getline(cin, buffer, '\n');

  if (!buffer.empty())
    {
    errno = 0;
    char *garbage = nullptr;

    /** strtod gives val if good, and 0.0 if bad. */
    d = strtod(buffer.c_str(), &garbage);
    d = *garbage == '\0' && errno != ERANGE ? d : 0;
    }

  return &d;
  }

/******************************************************************************
* getOperator */
/**
* Ask user to choose an operator from +-/* . Validates input, and returns
* operatpor. For bad input, returns '+'
*
* @returns an operation character string reference that was enterred by user.
******************************************************************************/
const std::string getOperator()
  {
  string buffer;
  cout << "\nEnter an operator..." << endl;

  getline(cin, buffer, '\n');

  /**
  By applying De Morgan's Laws https://en.wikipedia.org/wiki/De_Morgan%27s_laws
  
  !(buffer == "+" || buffer == "-" || buffer == "*" || buffer == "/")
  is the same as
  buffer != "+" && buffer != "-" && buffer != "*" && buffer != "/"
  **/
  if (buffer.empty() || !(buffer == "+" || buffer == "-" || buffer == "*" || buffer == "/"))
    buffer = "+";

  return buffer;
  }

/******************************************************************************
* terminateProgram */
/**
* Ask user if they wish to terminate the program. 
******************************************************************************/
bool terminateProgram()
  {
  std::string terminalVal = "";
  
  /** See if the user wants to go again. */
  std::cout << "\n[Y] to terminate.\n[N] to go again." << std::endl;
  getline(cin, terminalVal, '\n');
  for(int i = 3; i > 0; i--)
    {
    /** Go again. */
    if (tolower(terminalVal[0]) == 'n')
      return false;

    /** Exit. */
    else if (tolower(terminalVal[0]) == 'y')
      return true;

    /** Incorrect input. */
    else
      {
      std::cout << "\n[Y] to terminate.\n[N] to go again. You have " << i << " more tries until exit." << std::endl;
      getline(cin, terminalVal, '\n');
      }
    }

  /** Terminate program due to invalid inputs from user. */
  return false;
  }