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
  
  int* i  = new int(2);
  int* i2 = new int(3);
  int* i3 = new int(5);
  int* i4 = new int(8);
  int* i5 = new int(13);

  dbll->insert(i);
  dbll->insert(i2);
  dbll->insert(i5);

  dbll->find(i);
  dbll->find(i2);
  dbll->find(i4);

  dbll->deleteNode(i);
  
  dbll->find(i);

  delete i, i2, i3, i4, i5;
  delete dbll;

  system("pause");
  return 1;
  }