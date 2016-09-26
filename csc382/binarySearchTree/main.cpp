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
#include "BST.h"
int main()
  {
  BST<int> bst;

  bst.add(20, 30);
  bst.add(1,  89);
  bst.add(21, 40);
  bst.add(80, 66);

  system("pause");
  }