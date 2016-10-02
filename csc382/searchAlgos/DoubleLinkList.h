
#pragma once


#include <iostream>

using namespace std;

/** Node is a single node in the linked list. */
template <typename T>
class Node
  {
  public:
    long  key;
    T*    data;
    Node* prev;
    Node* next;
  };

/** List containing Node<T> objects.*/
template <typename T>
class DoubleLinkList
  {
  public:
    Node<T>* head;
    DoubleLinkList      ();
    Node<T>* getNode    (long key);
    void     deleteNode (T* delNode);
    void     insert     (T* newData);
    void     mergeSort  (Node<T>** headRef);
    void     split      (Node<T>* source, Node<T>** front, Node<T>** back);
    Node<T>* sortedMerge(Node<T>* listA,  Node<T>* listB);
  };
  
  
