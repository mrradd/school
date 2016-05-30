/******************************************************************************
* Conrad Horton
* CSC215 May 2016
* 05292016
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

#include <iostream>
#include <sstream>
#include <fstream>
#include <vector>
#include <string>
#include <algorithm>

using namespace std;

vector<string> vecBookCollection;
vector<string> vecDisplayCollection;

void addBook();
void alphabetizeBooks();
void clearStringVectors(vector<vector<string>*> ptrVec);
const string& enterBookName();
void handleMenu();
void printBooks();
void printDisplayCollection();
void printMenu();
void readFromFile();
void removeBook();
void writeToFile();

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
* Adds string to the vector of books.
*
* @param  bookName   Name of book to add.
******************************************************************************/
void addBook()
  {
  string bookName = "";
  cout << "Enter a book title..." << endl;
  getline(cin, bookName, '\n');

  vecBookCollection.push_back(bookName);
  }

/******************************************************************************
* alphabetizeBooks */
/**
* Alphabetize both string vectors.
******************************************************************************/
void alphabetizeBooks()
  {
  stable_sort(vecBookCollection.begin(),    vecBookCollection.end());
  stable_sort(vecDisplayCollection.begin(), vecDisplayCollection.end());
  }

/******************************************************************************
* clearStringVectors */
/**
* Clear the vectors contained in the passed in vector.
*
* @param  ptrVec  Vector of ptrs to string vectors.
******************************************************************************/
void clearStringVectors(vector<vector<string>*> ptrVec)
  {
  vector<vector<string>*>::iterator iter;
  for(iter = ptrVec.begin(); iter != ptrVec.end(); iter++)
    (*iter)->clear();
  }

/******************************************************************************
* enterBookName */
/**
* Ask user if they wish to terminate the program. 
******************************************************************************/
const string& enterBookName()
  {
  return string("derp");
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

  do
    {
    printMenu();
    getline(cin, userEntry, '\n');

    /** Add book. */
    if (tolower(userEntry[0]) == 'a')
      addBook();

    /** Remove book. */
    else if (tolower(userEntry[0]) == 'r')
      removeBook();

    /** Display books. */
    else if (tolower(userEntry[0]) == 'd')
      printBooks();

    /** Export book collection to file. */
    else if (tolower(userEntry[0]) == 'e')
      {
      writeToFile();
      readFromFile();
      printDisplayCollection();
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
******************************************************************************/
void printBooks()
  {
  int i = 1;
  stringstream ss;
  
  cout << "Titles in your collection:" << endl;
  vector<string>::iterator iter;
  for(iter = vecBookCollection.begin(); iter != vecBookCollection.end(); iter++)
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
* Prints out the vecDisplayCollection vector.
******************************************************************************/
void printDisplayCollection()
  {
  cout << "Titles saved:" << endl;
  vector<string>::iterator iter;
  for(iter = vecDisplayCollection.begin(); iter != vecDisplayCollection.end(); iter++)
    {
    cout << *iter << endl;
    }
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
* Reads list of books from file into vector to display books.
******************************************************************************/
void readFromFile()
  {
  fstream myfile;
  myfile.open("books.dat");
  

  /** If the file is open, clear the display list, and loop through the file
      adding each line to the vector. */
  if (myfile.is_open())
    {
    vecDisplayCollection.clear();
    string book;
    vector<string>::iterator iter = vecDisplayCollection.begin();
    while ( getline(myfile,book) )
      {
      vecDisplayCollection.push_back(book);
      }
    }
  else
    cout << "Could not open file to read." << endl;

  myfile.close();
  }

/******************************************************************************
* removeBook */
/**
* Lets the user select whether they  want to choose book by number or title,
* then iterates over the collection and erases the book if the bookname is
* found.
******************************************************************************/
void removeBook()
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
  printBooks();
  getline(cin, find, '\n');
  cin.clear();

  /** If the number was out of range. */
  if(byNumber && stoi(find) > vecBookCollection.size())
    {
    cout << "Value is out of range." << endl;
    return;
    }

  /** Find book. */
  vector<string>::iterator iter = vecBookCollection.begin();
  while(iter != vecBookCollection.end())
    {
    if (!found && ((!byNumber && *iter == find) || (byNumber && counter == stoi(find))))
      {
      iter  = vecBookCollection.erase(iter);
      cout << *(iter) << " removed" << endl;
      found = true;
      }
    else
      {
      counter++;
      ++iter;
      }
    }

  message.clear();
  printBooks();
  }

/******************************************************************************
* writeToFile */
/**
* Write book collection to file.
******************************************************************************/
void writeToFile()
  {
  fstream file;
  file.open ("books.dat");

  cout << "Attempting to write to file books.dat...." << endl; 
  if (file.is_open())
    {
    alphabetizeBooks();
    vector<string>::iterator iter;
    for(iter = vecBookCollection.begin(); iter != vecBookCollection.end(); iter++)
      file << (*iter) << endl;

    file.close();
    }
  else
    {
    cout << "There was an error writing to file books.dat!" << endl; 
    }

  file.close();
  }
