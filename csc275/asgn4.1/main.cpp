/*******************************************************************************
* Conrad Horton
* CSC275
* Asgn 4.1 Data Structures
* 08/13/2016
* 
* Part 1 - Without using the STL, create a stack and queue.  Input the same set
* of data in both.  Output the contents of both. 
* 
* Part 2 – Using the STL, implement a stack and a queue and complete the same
* tasks as part 1.
*******************************************************************************/
#include <iostream>
#include <string>
#include <queue>
#include <stack>
#include "Stack.h"
#include "Queue.h"

using namespace std;

/** Test the STL Queue. */
void testSTLQueue()
  {
  cout << "start testSTLQueue\n";
  queue<int> stlQ;
  cout << "Pushing in..." << endl;
  for(int i = 0; i < 10; i++)
    {
    cout << i << endl;
    stlQ.push(i);
    }

  cout << "Popping off..." << endl;
  while(!stlQ.empty())
    {
    cout << stlQ.front() << endl;
    stlQ.pop();
    }
  
  cout << "end testSTLQueue\n\n";
  }

/** Test the non STL template for Queue. */
void testQueueTemplate()
  {
  cout << "start testQueueTemplate\n";
  Queue<int, 10> queue;
  cout << "Pushing in..." << endl;
  for(int i = 0; i < 10; i++)
    {
    cout << i << endl;
    queue.push(i);
    }

  cout << "Popping off..." << endl;
  while(!queue.empty())
    {
    cout << queue.front() << endl;
    queue.pop();
    }
  
  cout << "end testQueueTemplate\n\n";
  }

/** Test the STL Stack. */
void testSTLStack()
  {
  cout << "start testSTLStack\n";
  
  stack<int> stlStack;
  cout << "Pushing in..." << endl;
  for(int i = 0; i < 10; i++)
    {
    cout << i << endl;
    stlStack.push(i);
    }

  cout << "Popping off..." << endl;
  while(!stlStack.empty())
    {
    cout << stlStack.top() << endl;
    stlStack.pop();
    }
    
  cout << "end testSTLStack\n\n";
  }

/** Test the non STL template for Stack. */
void testStackTemplate()
  {
  cout << "start testStackTemplate\n";
  
  Stack<int, 10> stack;
  cout << "Pushing in..." << endl;
  for(int i = 0; i < 10; i++)
    {
    cout << i << endl;
    stack.push(i);
    }

  cout << "Popping off..." << endl;
  while(!stack.empty())
    {
    cout << stack.top() << endl;
    stack.pop();
    }
    
  cout << "end testStackTemplate\n\n";
  }

int main()
  {
  try
    {
    testSTLQueue();
    testQueueTemplate();
    testSTLStack();
    testStackTemplate();
    }
  catch (exception e)
    {
    cout << e.what() << "\n\n";
    }

  system("pause");
  return 0;
  }
  