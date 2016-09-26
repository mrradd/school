/*******************************************************************************
* Template BST*/
/***
* Binary Search Tree template. This is only the interface file. Source can be
* found in BST.cpp where an explicit instantiation is used to allow for
* separation of source and interface for templates.
*******************************************************************************/
#pragma once
#include <string>


/** Node, or leaf, which contains references to child nodes, also contains
    its key and value. */
  template <typename T>
  struct Node
    {
    public:
      Node<T>()
        {
        key   = 0;
        left  = nullptr;
        right = nullptr;
        }
      Node<T>(long long key, T data)
        {
        this->key = key; this->data = data;
        left = right = nullptr;
        }
      unsigned long key;
      T         data;
      Node*     left;
      Node*     right;
    };

template <typename T>
class BST
  {
  protected:
    
    /** First Node in the tree. */
    Node<T>* mRoot;

    void          doDeletion (Node<T>* node);
    void          delNode    (T t, Node<T>* node);
    long unsigned findMax    (Node<T>* node, unsigned long key);
    void          insert     (long long key, T t, Node<T>* node = nullptr);
    void          replaceNode(Node<T>* nReplace, Node<T>* nReplaceWith);

  public:
    BST(){ mRoot = nullptr; }
    void add(long long key, T t);
    void del(T t);
    void max();

  };