/******************************************************************************
* Queue */
/**
* Emulates the functionality of an STL Queue.
*******************************************************************************/
#include <iostream>
#include <stdexcept>

template <typename T, int MaxSize>
class Queue
  {
  /*****************************************************************************
  * Datamembers
  *****************************************************************************/
  private:
    T   mList[MaxSize];
    int mSize;

  /*****************************************************************************
  * CTORS/DTORS
  *****************************************************************************/    
  public:
    Queue() { mSize = 0; };
    ~Queue(){};
    
  /*****************************************************************************
  * Methods
  *****************************************************************************/
  public:
    /***************************************************************************
    * back */
    /**
    * Returns the top object in the stack. 
    ***************************************************************************/      
    T back()
      {
      if (empty())
        throw std::out_of_range("Stack Empty.");
      
      return mList[mSize];
      }
    
    /***************************************************************************
    * empty */
    /**
    * Returns if the list is empty.
    ***************************************************************************/
    bool empty(){ return mSize <= 0; }
    
    /***************************************************************************
    * front */
    /**
    * Returns the top object in the stack. 
    ***************************************************************************/      
    T front()
      {
      if (empty())
        throw std::out_of_range("Stack Empty.");
      
      return mList[0];
      }
    
    /***************************************************************************
    * push */
    /**
    * Push an object onto the back of the stack. 
    ***************************************************************************/
    void push(T t)
      {
      if(mSize < MaxSize)
        mList[mSize++] = t;
      else throw std::out_of_range("Stack full.");
      }

    /***************************************************************************
    * pop */
    /**
    * Returns the front object, and decrements the size counter, then reorders
    * the list by shifting items to the front.
    ***************************************************************************/      
    void pop()
      {
      if(empty())
        throw std::out_of_range("Stack Empty.");
      
      /** Shift all elements down one. */
      if(mSize > 1)
        for(int i = 1; i < mSize; i++)
          {
          mList[i-1] = mList[i];
          mList[i]   = NULL;
          }
      --mSize;
      }
    
    /***************************************************************************
    * size */
    /**
    * Returns the size of the stack.
    ***************************************************************************/
    int size(){ return mSize <= 0 ? 0 : mSize + 1; }
  };
  
  