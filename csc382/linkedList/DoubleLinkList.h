
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
    * find */
    /**
    * Finds the Node with data equal to passed in data.
    *
    * @param  data  T object to insert.
    * @param returns pointer to the data found.
    **************************************************************************/
    T* find(T* data)
      {
      /** Traverse the list to find the data we want. */
      Node<T>* n = start;
      do 
        {
        if (*(n->data) == *(data))
          {
          cout << "ok" << endl;
          return n->data;
          }

        n = n->next;
        }
      while(n->next != NULL);

      /** Nothing found. */
      cout << "shit" << endl;
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
        /** Give the starting node data via temp swap. */
        temp->prev = NULL;
        start = temp;
        }
      else
        {
        /** Traverse the list to find the end. */
        Node<T>* n = start;
        while(n->next != NULL)
          n = n->next;
        
        temp->prev = n;
        }
      }
  };