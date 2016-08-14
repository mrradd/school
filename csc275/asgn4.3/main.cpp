/*******************************************************************************
* Conrad Horton
* CSC275
* Asgn 4.3 Multi Threading
* 08/14/2016
* 
* For this assignment, your task will be to write a program to start, manage,
* and execute 10 threads. Each thread will write (append) some thread specific
* information ("Thread #insert_thread_number_here") to a shared resource, in
* this case a std::string. A mutex will need to be added to manage the
* execution of the threads and prevent them from interleaving (two threads
* using/writing to the shared resource at the same time).
*******************************************************************************/
#include <iostream>
#include <string>
#include <thread>
#include <vector>
#include <mutex>
#include <sstream>

using namespace std;

static mutex mutEx;

/** Do work. */
void doWork(string& str, int threadNumber)
  {
  mutEx.lock();
  string temp = "Thread " + to_string(threadNumber) + "\n";
  str += temp;
  mutEx.unlock();
  }

int main()
  {
  /** String that will hold final result. */ string result;
  /** Vector of threads to use. */           vector<thread> vecThreads;
  
  /** Make ten threads. */
  for(int i = 0; i < 10; i++)
    {
    vecThreads.push_back(thread(doWork, std::ref(result), i+1));
    }

  /** Join the threads. */
  for(int i = 0; i < 10; i++)
    vecThreads[i].join();

  cout << result;

  system("pause");
  return 0;
  }
  
  
  
  