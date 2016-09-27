#include "BST.h"
#include <iostream>

using namespace std;

/** Adds a node to the tree. */
template<typename T>
void BST<T>::add(long long key, T val)
  {
  if (mRoot == nullptr)
    {
    mRoot = new Node<T>(key, val);
    cout << "root set key: " << key << endl;
    }
  /** Try adding it to the root then try adding to each Node after. */
  else
    insert(key, val, mRoot);
  }

/** Try deleting the root node first then traverse the tree. */
template<typename T>
void BST<T>::del(T val)
  {
  delNode(val, mRoot);
  }

/** Find and delete a certain Node. */
template<typename T>
void BST<T>::delNode(T val, Node<T>*& node)
  {
  bool l = node->left  != nullptr;
  bool ld = val < node->data;
  bool r = node->right != nullptr;
  bool rd = val > node->data;
  
  if (l && ld)
    delNode(val, node->left);
  else if (r && rd)
    delNode(val, node->right);
  else
    {
    cout << "DELETE  K: " << node->key << "\n\n";
    doDeletion(node);
    }
  }

/** Deletes the node and reattaches the subtrees. */
template<class T>
void BST<T>::doDeletion(Node<T>*& node)
  {
  Node<T> *tempNode;

  if (node == nullptr)
    cout << "Cannot delete empty Node..." << endl;
  else if(node->right == nullptr)
    {
    tempNode = node;
    node     = node->left;
    delete tempNode;
    }
  else if(node->left == nullptr)
    {
    tempNode = node;
    node     = node->right;
    delete tempNode;
    }
   
  /** Node has two children. */
  else
    {
    /** Move one Node to the right */
    tempNode = node->right;

    /** Go to the end left Node. */
    while(tempNode->left)
      tempNode = tempNode->left;

    /** Attach the left subtree. */
    tempNode->left = node->left;
    tempNode = node;
    
    /** Attach the right subtree. */
    node = node->right;
    delete tempNode;
    }
  }

/** Traverses the tree to find the max Key. */
template<typename T>
long unsigned BST<T>::findMax(Node<T>* node, unsigned long key)
  {
  long unsigned maxKey = key;
  if(node != NULL)
    {
    long unsigned lBig   = 0;
    long unsigned rBig   = 0;
    long unsigned bigKey = 0;
    
    if(node->left != NULL)
      lBig = findMax(node->left, node->left->key);
    
    if(node->right != NULL)
      rBig = findMax(node->right, node->right->key);
    
    bigKey = rBig > lBig ? rBig : lBig;
    maxKey = maxKey > bigKey ? maxKey : bigKey;
    }

  return maxKey;
  }

/** Insert a Node to the tree hidden from the user, because reasons. */
template<typename T>
void BST<T>::insert(long long key, T val, Node<T>*& node)
  {
  /** External Node found, set the Node value. */
  if (node == nullptr)
    {
    node = new Node<T>(key, val);
    cout << "SET  K: " << key << "\n\n";
    }

  /** Insert in left Node. */
  else if (key < node->key)
    {
    cout << "LEFT" << endl;
    insert(key, val, node->left);
    }

  /** Insert in right Node. */
  else if (key > node->key)
    {
    cout << "RIGHT" << endl;
    insert(key, val, node->right);
    }
  /** Key in use. */
  else if (key == node->key)
    {
    cout << "There already exists a Node with Key: " << key << endl;
    }

  /** Node was not added. */
  else
    cout << "Node not added for some reason. Intended Key: " << key << endl;
  }

/** Find the largest key starting from the Root Node. */
template<typename T>
void BST<T>::max()
  {
  cout << "MAX: " << findMax(mRoot, mRoot->key) << endl;
  }


/** The explicit instantiation; see
    http://www.cplusplus.com/forum/articles/14272/ (guestgulkan) */
template class BST<int>;