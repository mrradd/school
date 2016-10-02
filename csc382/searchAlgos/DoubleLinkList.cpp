
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
* find */
/**
* Finds the Node with data equal to passed in data.
*
* @param  data  T object to insert.
* @returns pointer to the data found.
*************************************************************************
template<typename T>
T* DoubleLinkList<T>::find(T* data)
  {
  cout << "start find(T* data)" << endl;
  cout << "Searching for: " << *data << " ..." << endl;
  
  /** Traverse the list to find the data we want. 
  Node<T>* n = head;
  try
    {
    while (n->next != NULL)
      {
      if (*(n->data) == *data)
        {
        cout << "Match found: " << *(n->data) << "\n" << endl;
        return n->data;
        }

      if (n->data != NULL)
        n = n->next;
      }
    }
  catch(...)
    {
    cout << "derp" << endl;
    }

  /** Nothing found.
  cout << "No match found." << endl;
  cout << "end find(T* data)\n" << endl;
  return nullptr;
  }*/

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
  
template class DoubleLinkList<int>;
