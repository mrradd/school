
#pragma once
#include <iostream>

using namespace std;

/** Node is a single node in the linked list. */
template <typename T>
class Node
  {
  public:
    Node<T>(){ key = -1; data = NULL; prev = NULL; next = NULL; }
    long  key;
    T*    data;
    Node* prev;
    Node* next;
  };

/** List containing Node<T> objects.*/
template <typename T>
class DoubleLinkList
  {
  protected:
    void     mergeSort  (Node<T>*& headRef);
    Node<T>* sortedMerge(Node<T>* listA,  Node<T>* listB);
    void     split      (Node<T>* source, Node<T>*& front, Node<T>*& back);
    void     bubbleSort (Node<T>** node);

  public:
    Node<T>* rootNode;
    DoubleLinkList      ();
    
    void     deleteNode  (T* delNode);
    void     doMergeSort ();
    void     doBubbleSort();
    Node<T>* getNode     (long key);
    void     insert      (long key, T* newData);
    void     printList   ();
  };
  
  
