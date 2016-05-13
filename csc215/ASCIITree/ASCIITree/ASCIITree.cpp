#include "ASCIITree.h"

/******************************************************************************
* You must create a program that will display a christmas tree shape using the
* asterisk character. This program will prompt the user for a number of lines
* in the tree, then based on the user's input, it will use the asterisk
* character to display a christmas tree shape with that number of lines.
* Each line will contain an odd number of asterisks (1, 3, 5, 7, etc...)
* You will have to play with the number of spaces displayed on each line, to
* make the display correct.
* 
* For this project you must create a C++ project that will:
* $Ask the user for the number of lines in their christmas tree. 
* $Use cout to display the prompt to the user.
* $Prompt for user to enter number of lines
* $Use cin to store the input.
* $Using loops to cycle through, use cout to display the tree image to the screen.
* $Thank them for using your program.
* $Program should then pause and wait for the user to press a key before closing.
* 
* ADDITIONAL OPTIONS
* $Use different characters by asking the user to choose a character.
* $Use random number generation to generate a tree with a random number of lines. (Stay between 10 and 20)
* $Have the character chosen at random from all of the letters of the alphabet.
* $After the tree is displayed, ask the user if they would like to draw another tree.
*   if they answer 'Y' for yes the program will run again.
*   if they answer 'N' for no the program will exit.
******************************************************************************/

void ASCIITree::loop()
  {
  /** Seed random using current system time. */
  srand (time(NULL));
  ASCIITree tree;

  while(true)
    {
    std::string terminalVal = "";

    /** Number rows user wants to print. */
    int userRows = -1;

    /** Get a single char from user input. */
    std::cout << "Enter a single alphanumeric, or special, character." << std::endl;
    std::cin  >> tree.mSymbol;
    std::cout << std::endl;

    /** Ask user for number of rows to print. */
    std::string litmus;
    std::cout << "Enter a number of rows to print." << std::endl;
    std::cin  >> litmus;
    std::cout << std::endl;
    userRows = isdigit(litmus.c_str()[0]) > 0 ? atoi(litmus.c_str()) : -1;

    if (userRows <= 0)
      {
      std::cout << "Random it is then." << std::endl;
      /** Generate a random number between 10 and 20. */
      userRows = rand() % 20 + 10;
      }

    /** Draw the tree. */
    int i = 1;
    for(int row = userRows; row > 0; row--)
      {
      std::cout << std::setw(row) << std::left << std::setfill(' ') << "" << std::setw(i) << std::right << std::setfill(tree.mSymbol[0]) << "" << std::endl;
      i += 2;
      }

    /** See if the user wants to go again. */
    std::cout << "\n[Y] to make another tree.\n[N] to quit." << std::endl;
    std::cin  >> terminalVal;
    for(;;)
      {
      /** Quit the program. */
      if (tolower(terminalVal[0]) == 'n')
        return;

      /** Make another tree. */
      else if (tolower(terminalVal[0]) == 'y')
        break;

      /** Incorrect input. */
      else
        {
        std::cout << "[Y] to make another tree.\n[N] to quit." << std::endl;
        std::cin  >> terminalVal;
        }
      }
    }
  }
