#include "LinkedList.h"

LinkedList::LinkedList()
  {
  head = new Node();
  head->next = NULL;
  length = 0;
  }

LinkedList::~LinkedList()
  {
  Node * n1 = head;
  Node * n2 = head;
  while (n2)
    {
    n1 = n2;
    n2 = n1->next;
    if (n2) delete n1;
    }
  }
  
/** Searches for a node by its key. Returns a reference to first match or
    NULL if no match. */
Node * LinkedList::getNode(string key)
  {
  Node* n1 = head;
  Node* n2 = head;
  while (n2)
    {
    n1 = n2;
    if ((n1 != head) && (n1->key == key))
        return n1;
    n2 = n1->next;
    }
  return NULL;
  }
  
/** Returns the length of the list. */
int LinkedList::getLength()
  {
  return length;
  }
  
/** Inserts a node at the end of the list. */
void LinkedList::insertNode(Node* node)
  {
  if (!head->next)
    {
    head->next = node;
    length++;
    return;
    }
    
  Node* n1 = head;
  Node* n2 = head;
  while (n2)
    {
    n1 = n2;
    n2 = n1->next;
    }

  n1->next    = node;
  node->next = NULL;
  length++;
  }
  
/** Prints list to console. */
void LinkedList::printList()
  {
  if (length == 0)
    {
    cout << "\n{ }\n";
    return;
    }
  Node* n1 = head;
  Node* n2 = head;
  cout << "\n{ ";
  while (n2)
    {
    n1 = n2;
    if (n1 != head)
      {
      cout << n1->key;
      if (n1->next) cout << ", ";
      else cout << " ";
      }
    n2 = n1->next;
    }
    
  cout << "}\n";
  }

/** Removes a node from the list by node key. Returns true if is successful. */
bool LinkedList::removeItem(string itemKey)
  {
  if (!head->next) return false;
  Node* n1 = head;
  Node* n2 = head;
  while (n2)
    {
    if (n2->key == itemKey)
      {
      n1->next = n2->next;
      delete n2;
      length--;
      return true;
      }
    n1 = n2;
    n2 = n1->next;
    }
  return false;
  }

