/******************************************************************************
* Conrad Horton
* CSC215 May 2016
* 20160607
* Final Part 1
*******************************************************************************
* The purpose of this project is to familiarize you with the C++ concepts and
* implementation of classes and Inheritance.
* 
* You must create a program which demonstrates the concepts of Parent and
* Child classes. The program should include a basic "parent" class with data
* members and methods which are consistent across all object types. Then there
* need to be at least three "child" classes which contain object specific
* members and methods. Use some imagination on this one.  Think about
* situations like; the animal kingdom, different characters in a game (both
* player and/or non-player), 3D geometric shapes, furniture, etc... The main
* program should create objects of each type, then allow the user to set
* certain properties of these objects. DON'T FORGET TO ADD COMMENTS TO ALL
* OF YOUR FILES CORRECTLY!!!!
* 
* For this project you must ensure that:
*   Each class has all appropriate accessor functions (set/get).
*   Each class should have a "display" function to show the properties of each
*   object.
*   There should be a menu which provides options to the user.
*   Each class should follow the following concepts
*     $All data members should be privately scoped.
*     $All methods (member functions) should be publicly scoped.
*     $Each class needs a Static data member (public) to track the number of
*      objects.(including parent)
*     $Ensure that there is at least a default constructor for Every class.
*      (including Parent)
*       $Ensure that each constructor has a "cout" to show that it is running
*       $Use the constructor to add to the appropriate static data member
*     $Create a default destructor for each class.
*       $Add code for any necessary "delete" commands
*       $Use the destructor to subtract from the appropriate static data
*        member.
*   $Ensure that the program consists of at least 2 files; Primary .cpp file
*    and a .h (header) file for the classes.
*     $You may use a 3 file system.  -Primary .cpp file / -header file for
*      class definitions / matching cpp file for method definitions
*
*   - REMEMBER to use some creativity with this.
*   - Write the main program to appropriately use the different classes based
*     on what type they are.
******************************************************************************/

#include <iostream>

using namespace std;
int main()
  {
  system("pause");
  return 1;
  }