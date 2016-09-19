/*******************************************************************************
* Conrad Horton
* CSC275
* Asgn 4.3 Multi Threading
* 08/14/2016
*
* Implement a templated doubly-linked list in C++.  Your linked list class
* should implement the following functionality:
* 
* Find(dataToFind) – returns a pointer to the node whose key matches dataToFind.
* Insert(newData)  – inserts a new node at the end of the list with a key equal
*                    to newData.
* Delete(delNode)  - deletes the node that delNode points to from the list.
* 
* For extra credit, implement a function that finds the Minimum and Maximum
* values in your linked list.
* Minimum() – returns the minimum key in the list
* Maximum() – returns the maximum key in the list
* 
* Your main program should instantiate, initialize and correctly demonstrate
* the functionality of the linked list.
*******************************************************************************/

#include "DoubleLinkList.h"

int main()
  {
  DoubleLinkList<int>* dbll = new DoubleLinkList<int>;
  
  int* i = new int(1);
  cout << i << endl;

  dbll->insert(i);
  cout << dbll->find(i) << endl;


  delete i;
  delete dbll;

  system("pause");
  return 1;
  }