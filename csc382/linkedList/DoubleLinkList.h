
#pragma once


#include <iostream>

using namespace std;

/** Node is a single node in the linked list. */
template <typename T>
class Node
  {
  public:
    T      *data;
    Node   *prev;
    Node   *next;
  };

/** List containing Node<T> objects.*/
template <typename T>
class DoubleLinkList
  {
  public:
    Node<T>* start;

    /**************************************************************************
    * CTOR
    **************************************************************************/
    DoubleLinkList(){ start = NULL; }

    /**************************************************************************
    * deleteNode */
    /**
    * Deletes the node that delNode points to from the list.
    *
    * @param  delNode  T object delete;
    * @param  returns  pointer to the data found.
    **************************************************************************/
    void deleteNode(T* delNode)
      {
      cout << "start delete(T* delNode)" << endl;
      cout << "Trying to delete " << *(delNode) << endl;

      /** Traverse the list to find the data we want. */
      Node<T>* n     = start;
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

          if(n == start)
            start = n->next;

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
    **************************************************************************/
    T* find(T* data)
      {
      cout << "start find(T* data)" << endl;
      cout << "Searching for: " << *data << " ..." << endl;
      
      /** Traverse the list to find the data we want. */
      Node<T>* n = start;
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

      /** Nothing found. */
      cout << "No match found." << endl;
      cout << "end find(T* data)\n" << endl;
      return nullptr;
      }

    /**************************************************************************
    * insert */
    /**
    * Inserts a new node at the end of the list with a key equal to newData.
    * @param  newData  T object to insert.
    **************************************************************************/
    void insert(T* newData)
      {
      /** Init temp node with data. */
      Node<T>* temp = new Node<T>();
      temp->next    = NULL;
      temp->data    = newData;
           
      /** Check to see that the starting node exits.*/
      if(start == NULL)
        {
        cout << "init start\n" << endl;
        /** Give the starting node data via temp swap. */
        temp->prev = NULL;
        start = temp;
        cout << "data: " << *(start->data) << " prev: " << (start->prev != NULL ? *(start->prev->data) : 0) << "\n" << endl;
        }
      else
        {
        /** Traverse the list to find the end. */
        cout << "add node" << endl;
        Node<T>* n = start;
        while(n->next != NULL)
          n = n->next;
        
        n->next    = temp;
        temp->prev = n;
        
        cout << "data: " << *(temp->data) << " prev: " << (temp->prev != NULL ? *(temp->prev->data) : 0) << "\n" << endl;
        }
      }
  };