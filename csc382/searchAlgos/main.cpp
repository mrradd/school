/*******************************************************************************
* Conrad Horton
* CSC382
* Sorting
* 10/2/2016
*
* Using ordering a double linked list using merge sort and bubble sort during
* which I will be calculating efficiency.
*******************************************************************************/

#include "DoubleLinkList.h"
#include <exception>
#include <ctime>

#define QTY 1000

using namespace std;

int main()
  {
  srand (time(NULL));
  long keyArray[QTY];

  /** Clocks for the different sized lists. */
  float bubbleClock1000 = 0.0f;
  float bubbleClock100  = 0.0f;
  float bubbleClock10   = 0.0f;
  float mergeClock1000  = 0.0f;
  float mergeClock100   = 0.0f;
  float mergeClock10    = 0.0f;

  /** Different sized lists. */
  DoubleLinkList<int>* dbllBubble1000 = new DoubleLinkList<int>;
  DoubleLinkList<int>* dbllBubble100  = new DoubleLinkList<int>;
  DoubleLinkList<int>* dbllBubble10   = new DoubleLinkList<int>;
  DoubleLinkList<int>* dbllMerge1000  = new DoubleLinkList<int>;
  DoubleLinkList<int>* dbllMerge100   = new DoubleLinkList<int>;
  DoubleLinkList<int>* dbllMerge10    = new DoubleLinkList<int>;

  /** Load the key array with random unordered keys. */
  int k = 0;
  while(k < QTY)
    {
    /** Check to see if the key exists. This is slow since it is iterating over
        N elements. */
    bool keyExists = false;
    long key = rand() % 10000 + 1;
    for (int i = 0; i < QTY; i++)
      {
      if(keyArray[i] == key)
        keyExists = true;
      }

    /** Key does not exist. Add it and go to the next element. */
    if(!keyExists)
      {
      keyArray[k] = key;
      k++;
      }
    }
  
  /** Fill all lists with the same data. */
  for (int j = 0; j < QTY; j++)
    {
    /** Fill the 10 Node lists. */
    if(j < 10)
      {
      dbllBubble10->insert(keyArray[j], new int(j));
      dbllMerge10 ->insert(keyArray[j], new int(j));
      }
    
    /** Fill the 100 Node lists. */
    if(j < 100)
      {
      dbllBubble100->insert(keyArray[j], new int(j));
      dbllMerge100 ->insert(keyArray[j], new int(j));
      }

    /** Load data into the linked 1000 Node lists. */
    dbllBubble1000->insert(keyArray[j], new int(j));
    dbllMerge1000 ->insert(keyArray[j], new int(j));
    }

  /** Perform sorting algorithms, and calculate execution times. */
  try
    {
    /** Do Bubble sorts. */
    cout << "Do Bubble sort" << endl;
    bubbleClock10   = clock();
    dbllBubble10 ->doBubbleSort();
    bubbleClock10   = clock() - bubbleClock10;
    cout << "Data of 10 Node list: " << endl;
    dbllBubble10->printList();
    
    bubbleClock100  = clock();
    dbllBubble100 ->doBubbleSort();
    bubbleClock100  = clock() - bubbleClock100;
    
    bubbleClock1000 = clock();
    dbllBubble1000->doBubbleSort();
    bubbleClock1000 = clock() - bubbleClock1000;
  
    cout << "Bubble time @10 elements   = " << bubbleClock10   << endl;
    cout << "Bubble time @100 elements  = " << bubbleClock100  << endl;
    cout << "Bubble time @1000 elements = " << bubbleClock1000 << endl << endl;


    /** Do Merge sorts. */
    cout << "Do Merge sort" << endl;
    mergeClock10   = clock();
    dbllMerge10  ->doMergeSort();
    mergeClock10   = clock() - mergeClock10;
    cout << "Data of 10 Node list: " << endl;
    dbllBubble10->printList();
    
    mergeClock100  = clock();
    dbllMerge100 ->doMergeSort();
    mergeClock100  = clock() - mergeClock100;
    
    mergeClock1000 = clock();
    dbllMerge1000->doMergeSort();
    mergeClock1000 = clock() - mergeClock1000;
  
    cout << "Merge  time @10 elements   = " << mergeClock10    << endl;
    cout << "Merge  time @100 elements  = " << mergeClock100   << endl;
    cout << "Merge  time @1000 elements = " << mergeClock1000  << endl;
    }
  catch(exception e)
    {
    cout << e.what() << endl;
    }
 
    
  system("pause");
  return 1;
  }
