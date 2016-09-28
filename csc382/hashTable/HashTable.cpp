#include "HashTable.h"

/** Array length is set to 13 by default. */
HashTable::HashTable(int tableLength)
  {
  if (tableLength <= 0) tableLength = 13;
  array  = new LinkedList[ tableLength ];
  length = tableLength;
  }

/** De-allocates all memory. */
HashTable::~HashTable()
  {
  delete [] array;
  }

/** Returns a node from the Hash Table by key. If the node isn't found, a null
    pointer is returned. */
Node * HashTable::getNodeByKey(string itemKey)
  {
  int index = hash(itemKey);
  return array[index].getNode(itemKey);
  }
  
/** Returns the number of locations in the Hash Table. */
int HashTable::getLength()
  {
  return length;
  }

/**  Returns the number of Items in the Hash Table. */
int HashTable::getNumberOfNodes()
  {
  int count = 0;
  for (int i = 0; i < length; i++)
    count += array[i].getLength();

  return count;
  }
  
/** Returns an array location for a given node key. */
int HashTable::hash(string key)
  {
  int value = 0;
  for (int i = 0; i < key.length(); i++)
    value += key[i];

  return (value * key.length()) % length;
  }

/**  Adds a node to the Hash Table. */
void HashTable::insertNode(Node * newNode)
  {
  int index = hash(newNode->key);
  array[index].insertNode(newNode);
  }

/**  Prints a histogram illustrating the Item distribution. */
void HashTable::printHistogram()
  {
  cout << "\n\nHash Table Contains ";
  cout << getNumberOfNodes() << " Items total\n";
  for (int i = 0; i < length; i++)
    {
    cout << i + 1 << ":\t";
    for (int j = 0; j < array[i].getLength(); j++)
      cout << " X";
    cout << "\n";
    }
  }

/**  Prints Hash Table to console window. */
void HashTable::printTable()
  {
  cout << "\n\nHash Table:\n";
  for (int i = 0; i < length; i++)
    {
    cout << "Bucket " << i + 1 << ": ";
    array[i].printList();
    }
  }

/** Deletes an Item by key from the Hash Table. Returns true if the operation
    is successful. */
bool HashTable::removeNode(string key)
  {
  int index = hash(key);
  return array[index].removeItem(key);
  }


