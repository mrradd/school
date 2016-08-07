/*******************************************************************************
* Conrad Horton
* CSC275
* Asgn 3.2 Smart Pointers
* 08/6/2016
* 
* Create a set of structures. There should be at least 2 types and some
* possibilities are structs, classes, vectors, arrays, maps, and lists. Create
* pointers to each of them. You need at least one unique_ptr, one shared_ptr,
* and one weak_ptr. Demonstrate when the pointers go out of scope and therefore
* the values are deleted.
* 
* Hint: create the structures in a function and have them print something to
* show the structure has been created. Call the function in main. When it
* returns from the function, the destructor for the structure will be
* automaticallycalled. 
* 
* You must submit the zipped project folder, including the .exe file.
*******************************************************************************/
#include "Clazz.h"
#include "Strukt.h"
#include <memory>
#include <thread>
#include <chrono>
#include <mutex>

using namespace std;


void makeSharedPtr();
void makeUniquePtr(unique_ptr<Strukt> unqPtr);
void makeWeakPtr  ();
void testWeakPtr  ();
void thred        (shared_ptr<Clazz>  sptr);

/** Global weakpointer for demonstrating scoping. **/
std::weak_ptr<Clazz> wkPtr;
  
/** Demonstrates use of shared_ptr with thread. **/
void makeSharedPtr()
  {
  cout << "Start makeSharedPtr" << endl; 
  std::shared_ptr<Clazz> sptrClazz(new Clazz());
  
  /** Setup 3 threads. */
  std::thread t1(thred, sptrClazz), t2(thred, sptrClazz), t3(thred, sptrClazz);
  
  /** Release ownership from scope. */
  sptrClazz.reset();
  
  /** Join threads so they wait for eachother's execution. */
  t1.join(); t2.join(); t3.join();
  cout << "Threads completed." << endl;
  cout << "End makeSharedPtr" << endl;
  }
  
/** Creates a uniquepointer using the passed in pointer. **/
void makeUniquePtr(unique_ptr<Strukt> unqPtr)
  {
  cout << "Start makeUniquePtr." << endl;
  unique_ptr<Strukt> uptr(move(unqPtr));
  cout << "End makeUniquePtr." << endl;
  }

void makeWeakPtr()
  {
  cout << "Start makeWeakPtr." << endl;
    {
    auto aptr = std::make_shared<Clazz>();
	  wkPtr = aptr;
	  testWeakPtr();
    }
 
  testWeakPtr();
  cout << "End makeWeakPtr." << endl;
  }

/** Used for testing scoping with weakpointers. **/
void testWeakPtr()
  {
  cout << "Start testWeakPtr" << endl;
  
  if (auto apt = wkPtr.lock())
	  cout << "Address of wkPtr " << &apt << "\n";
  else
    cout << "wkPtr expired\n";
    
  cout << "End testWeakPtr" << endl;
  }

/** Thread function demonstrating use of shared_ptr. **/  
void thred(shared_ptr<Clazz> sptr)
  {
  this_thread::sleep_for(std::chrono::seconds(1));
  shared_ptr<Clazz> sp = sptr;

  static mutex io_mutex;
  lock_guard<std::mutex> lk(io_mutex);
  cout << "local pointer in a thread:"
       << " sp.get() = "       << sp.get()
       << " sp.use_count() = " << sp.use_count() << '\n';
  }
 
int main()
  {
  makeUniquePtr(unique_ptr<Strukt>(new Strukt));
  makeSharedPtr();
  makeWeakPtr();
  }