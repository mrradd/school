/*******************************************************************************
* Conrad Horton
* CSC382
* Sorting
* 10/2/2016
*
* Using ordering a double linked list useing merge sort and bubble sort during
* which I will be calculating efficiency.
*******************************************************************************/

#include "DoubleLinkList.h"
#include <exception>
#include <ctime>
using namespace std;
int main()
  {
  DoubleLinkList<int>* dbll = new DoubleLinkList<int>;
  srand (time(NULL));
  for (int i = 0; i < 10; i++)
    dbll->insert(rand() % 10000 + 1, new int(i));

  dbll->printList();
  
  try
    {
    dbll->doBubbleSort(&(dbll->rootNode));
    dbll->doMergeSort();
    }
  catch(exception e)
    {
    cout << e.what() << endl;
    }

  cout << endl;
  dbll->printList();

  system("pause");
  return 1;
  }
