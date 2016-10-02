
#pragma once


#include <iostream>

using namespace std;

/** Node is a single node in the linked list. */
template <typename T>
class Node
  {
  public:
    long key;
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
    DoubleLinkList     ();
    Node<T>* getNode   (long key);
    void     deleteNode(T* delNode);
    //T*       find      (T* data);
    void     insert    (T* newData);
    void     sort      ();
  };
