
#pragma once


#include "DoubleLinkList.h"

using namespace std;
    
/**************************************************************************
* CTOR
**************************************************************************/
template<typename T>
DoubleLinkList<T>::DoubleLinkList(){ rootNode = NULL; }


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

  /** Traverse the list to find the data we want. */
  Node<T>* n     = rootNode;
  while(n->next != NULL)
    {
    if (*(n->data) == *(delNode))
      {
      
      /** Point n's previous node to n's next node. */
      if(n->prev != NULL)
        n->prev->next = n->next;

      /** Point n's next node to n's previous node. */
      if(n->next != NULL)
        n->next->prev = n->prev;

      if(n == rootNode)
        rootNode = n->next;

      free(n);
      return;
      }
    n = n->next;
    }
  }


/**************************************************************************
* doBubbleSort */
/**
* Performs a bubble sort on the list.
**************************************************************************/
template<typename T>
void DoubleLinkList<T>::doBubbleSort()
  {
  bubbleSort(&rootNode);
  }

/**************************************************************************
* doMergeSort */
/**
* Pass through that performs the Merge Sort command from the rootNode of the
* linked list.
**************************************************************************/
template<typename T>
void DoubleLinkList<T>::doMergeSort()
  {
  mergeSort(rootNode);
  }

/**************************************************************************
* getNode */
/**
* Returns Node with passed in key.
* @param  key  Returns Node with that key.
**************************************************************************/
template<typename T>
Node<T>* DoubleLinkList<T>::getNode(long key)
  {
  Node<T>* n1 = rootNode;
  Node<T>* n2 = rootNode;
  while (n2)
    {
    n1 = n2;
    if ((n1 != rootNode) && (n1->key == key))
      return n1;
    n2 = n1->next;
    }
  return NULL;
  }

/**************************************************************************
* insert */
/**
* Inserts a new node at the end of the list with a key equal to newData.
* @param  newData  T object to insert.
* @param  key      Key for this node.
**************************************************************************/
template<typename T>
void DoubleLinkList<T>::insert(long key, T* newData)
  {
  /** Init temp node with data. */
  Node<T>* temp = new Node<T>();
  temp->next    = NULL;
  temp->data    = newData; 
  temp->key     = key;
       
  /** Check to see that the starting node exits.*/
  if(rootNode == NULL)
    {
    //cout << "init rootNode\n" << endl;

    /** Give the starting node data via temp swap. */
    temp->prev = NULL;
    rootNode = temp;
    
    //cout << "data: " << *(rootNode->data) << " prev: " << (rootNode->prev != NULL ? *(rootNode->prev->data) : 0) << "\n" << endl;
    }
  else
    {
    /** Traverse the list to find the end. */
    //cout << "add node" << endl;
    
    Node<T>* n = rootNode;
    while(n->next != NULL)
      n = n->next;
    
    n->next    = temp;
    temp->prev = n;
    
    //cout << "data: " << *(temp->data) << " prev: " << (temp->prev != NULL ? *(temp->prev->data) : 0) << "\n" << endl;
    }
  }
 
/**************************************************************************
* printList */
/**
* Prints the whole Double Linked List.
**************************************************************************/
template<typename T>
void DoubleLinkList<T>::printList()
  {
  cout << "->" <<endl;
  Node<T>* node = rootNode;
  while (node != NULL)
    {
    cout << "Key: " << node->key << " Data: " << *(node->data) <<endl;
    node = node->next;
    }
  }

/**************************************************************************
* mergeSort */
/**
* Sorts the linked list by changing next pointers.
* @param  headRef  Parent Node
**************************************************************************/
template<typename T>
void DoubleLinkList<T>::mergeSort(Node<T>*& parentNode)
  {
  Node<T>* n1;
  Node<T>* n2;

  if ((parentNode == NULL) || (parentNode->next == NULL))
    return;

  split    (parentNode, n1, n2);
  mergeSort(n1);
  mergeSort(n2);
  parentNode = sortedMerge(n1, n2);
  }
  
/**************************************************************************
* sortedMerge */
/**
* Merge the sorted linked lists.
* @param  nodeA  Sorted sublist of whole Linked List.
* @param  nodeB  Sorted sublist of whole Linked List.
* @returns merged sorted list.
**************************************************************************/
template<typename T>
Node<T>* DoubleLinkList<T>::sortedMerge(Node<T>* front,  Node<T>* back)
  {
  Node<T>* result = NULL;
  if (front == NULL)
      return back;
  else if (back==NULL)
      return front;

  if (front->key <= back->key)
    {
    result = front;
    result->next = sortedMerge(front->next, back);
    }
  else
    {
    result = back;
    result->next = sortedMerge(front, back->next);
    }

  return result;
  }
 
/**************************************************************************
* split */
/**
* Splits the main list into two sublists with passed in references.
*
* @param  frontRef  Reference to the front of the source list.
* @param  backRef   Reference to the back half of the source list.
**************************************************************************/
template<typename T>
void DoubleLinkList<T>::split(Node<T>* source, Node<T>*& frontRef, Node<T>*& backRef)
  {
  Node<T>* n1;
  Node<T>* n2;
  
  if (source==NULL || source->next==NULL)
    {
    frontRef = source;
    backRef  = NULL;
    }
  else
    {
    n2 = source;
    n1 = source->next;
    while (n1 != NULL)
      {
      n1 = n1->next;
      if (n1 != NULL)
        {
        n2 = n2->next;
        n1 = n1->next;
        }
      }

    frontRef = source;
    backRef  = n2->next;
    n2->next  = NULL;
    }
  }


/**************************************************************************
* bubbleSort */
/**
* Performs a bubble sort on the passed in list.
*
* @param  node  Reference to the the source list.
**************************************************************************/
template<typename T>
void DoubleLinkList<T>::bubbleSort(Node<T>** node)
  {
  Node<T>* front = *node;
  *node = nullptr;

  while(front)
    {
    Node<T>** lhs = &front;
    Node<T>** rhs = &front->next;
    bool swapped  = false;

    while(*rhs)
      {
      
      /** Swap linked node ptrs, then swap *back* their next ptrs. */
      if ((*rhs)->key < (*lhs)->key)
        {
        swap(*lhs,*rhs);
        swap((*lhs)->next,(*rhs)->next);
        lhs = &(*lhs)->next;
        swapped = true;
        }

      /** No swap, so advance both pointers. */
      else
        {
        lhs = rhs;
        rhs = &(*rhs)->next;
        }
      }

      /** Link last node to sorted part. */
      *rhs = *node;

      /** detach final node and terminate. */
      if(swapped)
        {
        /** take last node off the list and put it into the result. */
        *node = *lhs;
        *lhs  = nullptr;
        }

      /** Finished. */
      else
        {
        *node = front;
        break;
        }
    }
  }

template class DoubleLinkList<int>;
