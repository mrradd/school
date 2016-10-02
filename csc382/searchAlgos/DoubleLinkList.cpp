
#pragma once


#include "DoubleLinkList.h"

using namespace std;
    
/**************************************************************************
* CTOR
**************************************************************************/
template<typename T>
DoubleLinkList<T>::DoubleLinkList(){ head = NULL; }

/**************************************************************************
* insert */
/**
* Inserts a new node at the end of the list with a key equal to newData.
* @param  newData  T object to insert.
**************************************************************************/
template<typename T>
Node<T>* DoubleLinkList<T>::getNode(long key)
  {
  Node<T>* n1 = head;
  Node<T>* n2 = head;
  while (n2)
    {
    n1 = n2;
    if ((n1 != head) && (n1->key == key))
      return n1;
    n2 = n1->next;
    }
  return NULL;
  }

/**************************************************************************
* deleteNode */
/**
* Deletes the node that delNode points to from the list.
*
* @param  delNode  T object delete;
* @param  returns  pointer to the data found.
**************************************************************************/
template<typename T>
void DoubleLinkList<T>::deleteNode(T* delNode)
  {
  cout << "start delete(T* delNode)" << endl;
  cout << "Trying to delete " << *(delNode) << endl;

  /** Traverse the list to find the data we want. */
  Node<T>* n     = head;
  while(n->next != NULL)
    {
    if (*(n->data) == *(delNode))
      {
      cout << "Changing prev and next pointers." << endl;
      
      /** Point n's previous node to n's next node. */
      if(n->prev != NULL)
        n->prev->next = n->next;

      /** Point n's next node to n's previous node. */
      if(n->next != NULL)
        n->next->prev = n->prev;

      if(n == head)
        head = n->next;

      cout << "Deleting Node." << endl;
      free(n);
      cout << "Node deleted.\n" << endl;
      return;
      }
    n = n->next;
    }

  cout << "Nothing deleted." << endl;
  cout << "end delete(T* delNode)\n" << endl;
  }

/**************************************************************************
* insert */
/**
* Inserts a new node at the end of the list with a key equal to newData.
* @param  newData  T object to insert.
**************************************************************************/
template<typename T>
void DoubleLinkList<T>::insert(T* newData)
  {
  /** Init temp node with data. */
  Node<T>* temp = new Node<T>();
  temp->next    = NULL;
  temp->data    = newData;
       
  /** Check to see that the starting node exits.*/
  if(head == NULL)
    {
    cout << "init head\n" << endl;
    /** Give the starting node data via temp swap. */
    temp->prev = NULL;
    head = temp;
    cout << "data: " << *(head->data) << " prev: " << (head->prev != NULL ? *(head->prev->data) : 0) << "\n" << endl;
    }
  else
    {
    /** Traverse the list to find the end. */
    cout << "add node" << endl;
    Node<T>* n = head;
    while(n->next != NULL)
      n = n->next;
    
    n->next    = temp;
    temp->prev = n;
    
    cout << "data: " << *(temp->data) << " prev: " << (temp->prev != NULL ? *(temp->prev->data) : 0) << "\n" << endl;
    }
  }
 
/* sorts the linked list by changing next pointers. */
template<typename T>
void DoubleLinkList<T>::mergeSort(Node<T>** headRef)
  {
  Node<T>* h = *headRef;
  Node<T>* a;
  Node<T>* b;
  if ((head == NULL) || (head->next == NULL))
    {
    return;
    }
  split    (h, &a, &b);
  mergeSort(&a);
  mergeSort(&b);
  
  *headRef = sortedMerge(a, b);
  }
  
/* merge the sorted linked lists */
template<typename T>
Node<T>* DoubleLinkList<T>::sortedMerge(Node<T>* nodeA,  Node<T>* nodeB)
  {
    Node<T>* result = NULL;
    if (nodeA == NULL)
        return nodeB;
    else if (nodeB==NULL)
        return nodeA;
    if (nodeA->key <= nodeB->key)
      {
      result = nodeA;
      result->next = sortedMerge(nodeA->next, nodeB);
      }
    else
      {
      result = nodeB;
      result->next = sortedMerge(nodeA, nodeB->next);
      }
    return result;
  }
 
/* Split the nodes of the given list into front and back halves*/
template<typename T>
void DoubleLinkList<T>::split(Node<T>* source, Node<T>** front, Node<T>** back)
  {
  Node<T>* fast;
  Node<T>* slow;
  
  if (source==NULL || source->next==NULL)
    {
    *front = source;
    *back  = NULL;
    }
  else
    {
    slow = source;
    fast = source->next;
    while (fast != NULL)
      {
      fast = fast->next;
      if (fast != NULL)
        {
        slow = slow->next;
        fast = fast->next;
        }
      }
    *front = source;
    *back  = slow->next;
    slow->next = NULL;
    }
  }
    
template class DoubleLinkList<int>;
