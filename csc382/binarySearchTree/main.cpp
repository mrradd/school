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
  
  /** Load array with 100 key value pairs. */
  srand (time(NULL));
  for(int i = 0; i < 100; i++)
    {
    int key = rand() % 10000 + 1;
    bool exists = false;
    
//    /** Make sure the key does not exist. */
//    for(int j = 0; j < 100; j++)
//      if(keyArray[j] == key)
//        {
//        exists = true;
//        break;
//        }
//        
//    /** Add the key and value to their proper array. */
//    if(!exists)
//      keyArray[i] = key;

    bst.add(key, i);
    }

  bst.max();
  bst.del(99);
  bst.max();
  //system("pause");
  return 0;
  }