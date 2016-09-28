
#pragma once;
#include "LinkedList.h"

class HashTable
  {
  protected:

    /** Array of LinkedList pointers. */
    LinkedList* array;

    /** Size of LinkedList array. */
    int length;

    /** Returns an array location for a given node key. */
    int hash(string key);

  public:
    HashTable( int tableLength = 13 );
    ~HashTable();
    
    Node * retrieve        (string key);
    int    getLength       ();
    int    getNumberOfNodes();
    
    void insert(Node * newNode);
    bool removeNode(string key);
    void printHistogram();
    void printTable();
  };