/******************************************************************************
* Conrad Horton
* CSC215 May 2016
* 20160529 revised 20160601
* Asgn 3.2 Vector Bookcase
*******************************************************************************
* Book Collection and File
* The purpose of this project is to give you an opportunity to apply your
* knowledge of vectors and File I-O in C++.
* 
* You must create a program that will use a vector to store a collection of
* books. This can be a collection of fiction books, or text books, etc… as long
* as all the books are related in some way.  The vector will also write the
* data out to a file that will be stored locally on your computer.
* 
* Make sure that any functions are properly prototyped, and that the prototypes
* and definitions are in the proper files and locations.
* 
* For this project you must create a C++ project that will:
* $ Create a vector called vecBookCollection
*   $ Should be a vector of string objects
*   $ Users will be prompted to type in the titles of the books
* $ Use the getLine() function rather than just "cin" to get the user input
* $ Provide a menu for the user to:
*   $ Add a book to the collection
*   $ Display the books currently in the collection
*   $ Remove a book from the collection
*   $ Stop adding books and store the data in an external file
* $ Use the “push_back()” function appropriately to add the books to the
*   collection
* $ Correctly use an iterator to move through and display the collection
* $ Correctly use an iterator for removing a specific book when necessary.
* $ Put the collection in alphabetic order before storing to the external file,
*   $ only after all titles are added and any desired titles have been removed
*   $ Should happen immediately before the file is written
* $ Ensure that the external file is open for writing
* $ Name the file appropriately within the programming
*   $ Do not have the user enter a file name
* $ After the collection has been written to the file, make sure the file is
*   correctly closed.
* $ Next, open the file for reading, and read the data into a new vector called
*   "vecDisplayCollection"
* $ Use this vector to display the list of books to the user
* $ Lastly the program should ask if the user would like to run the program
*   again
*   $ If they choose yes, ensure that both vectors are cleared out, and the
*     program starts over again
*   $ If they choose no, the program should then end
* $ Make sure that you use functions for each of the different menu options
*   $ Creating and displaying the menu itself
*   $ Adding a book to the list
*   $ Displaying the current list (Also used at the end of the program)
*   $ Removing a book from the list
*     $ This function will call the display function to show the list
*     $ Then it will ask the user which book they want to remove
* $ Also create functions for the following:
*   $ Writing the collection to the file
*   $ Clearing out the two vectors at the end of the program
*    (use a pointer for this)
* 
* Recommendations for extra points:
* $ Allow the user to remove a book from the list by typing a title.
* $ If it finds it, it will be removed
* $ If not, it will display "Sorry, Title not found."
******************************************************************************/

#include "funcs.h"

int main()
  {
  handleMenu();
  remove("books.dat");
  system("pause");
  return 1;
  }

/******************************************************************************
* addBook */
/**
* Adds string to the passed in vector.
*
* @param  ptrVec  Pointer to vector of strings
******************************************************************************/
void addBook(vector<string>* ptrVec)
  {
  string bookName = "";
  cout << "Enter a book title..." << endl;
  getline(cin, bookName, '\n');

  ptrVec->push_back(bookName);
  }

/******************************************************************************
* alphabetizeBooks */
/**
* Alphabetize a single vector.
*
* @param  vecPtrVec  Vector of ptrs to string vectors.
******************************************************************************/
void alphabetizeBooks(vector<string>* ptrVec)
  {
  stable_sort(ptrVec->begin(),ptrVec->end());
  }
/**
* Alphabetize each vector contained in the passed in vector.
*
* @param  vecPtrVec  Vector of ptrs to string vectors.
******************************************************************************/
void alphabetizeBooks(vector<vector<string>*> vecPtrVec)
  {
  vector<vector<string>*>::iterator iter;
  for(iter = vecPtrVec.begin(); iter != vecPtrVec.end(); iter++)
    alphabetizeBooks(*iter);
  }

/******************************************************************************
* clearStringVectors */
/**
* Clear the vectors contained in the passed in vector.
*
* @param  vecPtrVec  Vector of ptrs to string vectors.
******************************************************************************/
void clearStringVectors(vector<vector<string>*> vecPtrVec)
  {
  vector<vector<string>*>::iterator iter;
  for(iter = vecPtrVec.begin(); iter != vecPtrVec.end(); iter++)
    (*iter)->clear();
  }

/******************************************************************************
* handleMenu */
/**
* Prints the menu and handles user interaction.
******************************************************************************/
void handleMenu()
  {
  string userEntry = "";

  bool quit = false;
  
  vector<string> vecBookCollection;
  vector<string> vecDisplayCollection;

  do
    {
    printMenu();
    getline(cin, userEntry, '\n');

    /** Add book. */
    if (tolower(userEntry[0]) == 'a')
      addBook(&vecBookCollection);

    /** Remove book. */
    else if (tolower(userEntry[0]) == 'r')
      removeBook(&vecBookCollection);

    /** Display books. */
    else if (tolower(userEntry[0]) == 'd')
      printBooks(&vecBookCollection);

    /** Export book collection to file. */
    else if (tolower(userEntry[0]) == 'e')
      {
      writeToFile(&vecBookCollection);
      readFromFile(&vecDisplayCollection);
      printDisplayCollection(&vecDisplayCollection);
      userEntry.clear();
      
      /** Check if Quit. */
      cout << "[Q] to quit program or any other key to continue." << endl;
      getline(cin, userEntry, '\n');
      if (tolower(userEntry[0]) == 'q')
        quit = true;

      /** Not quitting. Clear out contents of both vectors. */
      else
        {
        vector<vector<string>*> ptrVec;
        ptrVec.push_back(&vecDisplayCollection);
        ptrVec.push_back(&vecBookCollection);
        clearStringVectors(ptrVec);
        }
      }

    /** Incorrect input. */
    else
      {
      userEntry.clear();
      std::cout << "\nInvalid entry\n" << std::endl;
      printMenu();
      getline(cin, userEntry, '\n');
      }

    cin.clear();
    userEntry.clear();
    }
  while(!quit);
  }

/******************************************************************************
* printBooks */
/**
* Prints out the vector vecBookCollection vector.
*
* @param  ptrVec  Pointer to a vector.
******************************************************************************/
void printBooks(vector<string>* ptrVec)
  {
  int i = 1;
  stringstream ss;
  
  cout << "Titles in your collection:" << endl;
  vector<string>::iterator iter;
  for(iter = ptrVec->begin(); iter != ptrVec->end(); iter++)
    {
    ss << "[" << i << "] " << *iter;

    cout << ss.str() << endl;

    ss.str("");
    i++;
    }
  }

/******************************************************************************
* printDisplayCollection */
/**
* Prints out the passed in vector.
*
* @param  ptrVec  Pointer to a vector.
******************************************************************************/
void printDisplayCollection(vector<string>* ptrVec)
  {
  cout << "Titles saved:" << endl;
  vector<string>::iterator iter;
  for(iter = ptrVec->begin(); iter != ptrVec->end(); iter++)
    cout << *iter << endl;
  }

/******************************************************************************
* printMenu */
/**
* Prints out the menu options. 
******************************************************************************/
void printMenu()
  {
  cout << "\n**********************************************************\n" << endl;
  cout << "[A]dd book to collection." << endl;
  cout << "[R]emove book from collection." << endl;
  cout << "[D]isplay books in collection." << endl;
  cout << "[E]xport book list to file." << endl;
  }

/******************************************************************************
* readFromFile */
/**
* Reads list of books from file into the passed in vector.
*
* @param  ptrVec  Pointer to a vector to use for display book names.
******************************************************************************/
void readFromFile(vector<string>* ptrVec)
  {
  ifstream myfile;
  myfile.open("./books.dat");

  cout << "Attempting to read from file books.dat...." << endl; 
  
  /** If the file is open, clear the display list, and loop through the file
      adding each line to the vector. */
  if (myfile.is_open())
    {
    ptrVec->clear();
    string book;
    vector<string>::iterator iter = ptrVec->begin();
    while (getline(myfile,book))
      ptrVec->push_back(book);
    }
  else
    cout << "Could not open file to read." << endl;

  myfile.close();
  }

/******************************************************************************
* removeBook */
/**
* Lets the user select whether they  want to choose book by number or title,
* then iterates over the passed in vector and erases the book if the bookname
* is found, or if its number is found.
*
* @param  ptrVec  Pointer to a vector whose books should be removed.
******************************************************************************/
void removeBook(vector<string>* ptrVec)
  {
  bool   byNumber   = false;
  int    counter    = 1;
  bool   found      = false;
  string find;
  string message;
  string userEntry;

  /** Ask if enter by number or name. */
  cout << "[X] to remove book by number, or any key to remove by name..." << endl;
  getline(cin, userEntry, '\n');
  byNumber = tolower(userEntry[0]) == 'x';
  cin.clear();

  /** Ask to enter name/number. */  
  message = byNumber ? "Enter a book number..." : "Enter a book name...";
  cout << message << endl;
  printBooks(ptrVec);
  getline(cin, find, '\n');
  cin.clear();

  /** If the number was out of range. */
  if(byNumber && stoi(find) > ptrVec->size())
    {
    cout << "Value is out of range." << endl;
    return;
    }

  /** Find book. */
  vector<string>::iterator iter = ptrVec->begin();
  while(iter != ptrVec->end())
    {
    if (!found && ((!byNumber && *iter == find) || (byNumber && counter == stoi(find))))
      {
      iter  = ptrVec->erase(iter);
      cout << *(iter) << " removed" << endl;
      found = true;
      }
    else
      {
      counter++;
      ++iter;
      }
    }

  if (!found)
    cout << "Nothing removed." << endl;

  message.clear();
  printBooks(ptrVec);
  }

/******************************************************************************
* writeToFile */
/**
* Write passed in vector to file.
*
* @param  ptrVec  Pointer to a vector whose constents we should save.
******************************************************************************/
void writeToFile(vector<string>* ptrVec)
  {
  ofstream file;
  file.open ("./books.dat");

  cout << "Attempting to write to file books.dat...." << endl; 
  if (file.is_open())
    {
    alphabetizeBooks(ptrVec);

    vector<string>::iterator iter;
    for(iter = ptrVec->begin(); iter != ptrVec->end(); iter++)
      file << (*iter) << endl;

    file.close();
    }
  else
    cout << "There was an error writing to file books.dat!" << endl; 

  file.close();
  }
