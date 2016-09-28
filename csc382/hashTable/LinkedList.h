
#pragma once;
#include <iostream>
#include <string>
using namespace std;

struct Node
  {
  string key;
  string data;
  Node*  next;
  };

class LinkedList
  {
  protected:
    /** Reference to a list of data nodes. */
    Node* head;
    
    /** Length is the number of data nodes. */
    int length;
      
  public:
    LinkedList();
    ~LinkedList();
    
    Node * getNode  (string key);
    int    getLength();
    
    void insert(Node * newNode);
    void printList ();
    bool removeItem(string key);
  };
