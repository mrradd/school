/*******************************************************************************
* Conrad Horton
* CSC382 - September 2016
* Binary Search Tree
* 09/24/2016
*
* Implement a templated Binary Search Tree data structure, implementing the
* following functionality:
*   Add (concatenate node, resulting in balanced tree)
*   Delete (delete given node, restructure sub-tree)
*   Maximum(Find Maximum Key)
* To evaluate this data structure, write your program to read from an array of
* unsorted integers. 
*******************************************************************************/
#include <iostream>
#include <string>
#include <random>
#include <ctime>
#include "BST.h"

int main()
  {
  BST<int> bst;

//  int keyArray[100] = {0};
  long long key    = 0;
  long long delKey = 0;
  /** Load array with 100 key value pairs. */
  srand (time(NULL));
  
  for(int i = 0; i < 100; i++)
    {
    key = rand() % 1000 + 1;
    delKey = key < 500 ? key : 0;
    
    bst.add(key, i);
    }

  bst.max();
  bst.del(delKey);
  bst.max();
  //system("pause");
  return 0;
  }
