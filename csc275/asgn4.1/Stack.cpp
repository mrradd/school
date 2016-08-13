#include "Stack.h"

/*******************************************************************************
* CTOR */
/**
*******************************************************************************/
template <class T, int MaxStack>
Stack<T, MaxStack>::Stack()
  {
  mTop = mEmptyVal = -1;
  }

/*******************************************************************************
* DTOR */
/**
*******************************************************************************/
template <class T, int MaxStack>
Stack<T, MaxStack>::~Stack()
  {
  delete[] list;
  }

/*******************************************************************************
* push */
/**
* Increment placeholder, top, and insert T into that position.
*******************************************************************************/
template <class T, int MaxStack>
void Stack<T, MaxStack>::push(T t)
  {
  try
    {
    if (mTop + 1 < MaxStack)
      mList[++mTop] = t;
    else 
      throw std::out_of_range("\nException: stack full.\n\n");
    }
  catch (std::exception e)
    {
    cout << "e.what()\n\n";
    }
  }

/*******************************************************************************
* pop */
/**
*******************************************************************************/
template <class T, int MaxStack>
void Stack<T, MaxStack>::pop()
  {
  if (mTop > 0)
    --mTop;
  }

/*******************************************************************************
* top */
/**
*******************************************************************************/
template <class T, int MaxStack>
T Stack<T, MaxStack>::top(){}

/*******************************************************************************
* empty */
/**
*******************************************************************************/
template <class T, int MaxStack>
bool Stack<T, MaxStack>::empty(){}