/*******************************************************************************
* Conrad Horton
* CSC275
* Asgn 4.2 Post-fix
* 08/13/2016
* 
* Write a program that evaluates a postfix expression. You may assume it is a
* valid expression such as 6 2 + 5 * 8 4 / - 
* Note that you must include spaces between each (otherwise you would not know
* if the number was 62 or 6 and 2 in the above example). The program should read
* a postfix expression consisting of digits and operators into a string. Using a
* stack, the program should scan the expression and evaluate it. The algorithm
* is as follows:
* 
* While you have not reached the end of the string, read the expression from
* left to right. If the current character is a digit, push its integer value
* onto the stack. (The integer value of a digit character is its value in the
* computer character set minus the value of '0' in the computer character set).
* Otherwise, if the current character is an operator, pop the two top elements
* of the stack into variables x and y. Calculate y operator x.  Push the result
* of the calculation onto the stack.
* 
* When you reach the end of the string, pop the top value of the stack. This is
* the result of the postfix expression.
* 
* Note: In step 2 above, if the operator is '/', the top of the stack is 2 and
* the next element is 8m, then pop 2 into x, pop 8 into y and evaluate 8/2 and
* push the result 4 back onto the stack.  This note also applies to the operator
* '-'.  Allowable operators are + - * / ^ %.
*******************************************************************************/
#include <iostream>
#include <string>
#include <stack>

using namespace std;
int main()
  {
  string     postfix = "6 2 + 5 * 8 4 / -";
  stack<int> pfStack;
  
  /** Iterate over the expression. */
  for ( std::string::iterator it=postfix.begin(); it!=postfix.end(); ++it)
    {
    /** Check for integer, and add it to the stack. */
    if (isdigit(*it))
      pfStack.push(*it - '0');
    
    /** Check for operator. */
    else if (*it == '+'||*it == '-'||*it == '*'||*it == '/'||*it == '^'||*it == '%')
      {
      /** Convert char to int. */
      int x = (pfStack.top());
      pfStack.pop();
      int y = (pfStack.top());
      pfStack.pop();
      
      /** Check operator, and do math. */
      int result = 0;
      switch (*it)
        {
        case '+': result = y + x; break;
        case '-': result = y - x; break;
        case '*': result = y * x; break;
        case '/': result = y / x; break;
        case '^': result = y ^ x; break;
        case '%': result = y % x; break;
        }
      pfStack.push(result);
      }
    }
  
  /** Display result. */
  cout << "Result = "<< pfStack.top() << "\n";

  system("pause");
  return 0;
  }
  
  
  
  