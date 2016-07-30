/*******************************************************************************
* Conrad Horton
* CSC275
* Asgn 2.1 Word Search
* 07/26/2016
*
* Read in a file that contains a list of 10 words. 
* 
* Then, scan another file that contains at least 3 paragraphs from your favorite
* book.  Count the number of the words from the first file that are contained in
* the second. 
*******************************************************************************/

#include <fstream>
#include <string>
#include <iostream>
#include <vector>
#include <algorithm>
#include "Word.h"

int main()
  {
  /** File of words to search for. **/ std::ifstream            fileWords  ("word1.txt", std::ifstream::in);
  /** File of words to search in. **/  std::ifstream            filePassage("word2.txt", std::ifstream::in);
  /** Vector of words to find. **/     std::vector<Word*>       vecWordsToFind;
  /** Buffer to hold passage file. **/ std::string              passage;

  /** Try to open files. **/
  if (!fileWords)
    std::cout << "word1.txt could not be opened." << std::endl;

  if (!filePassage)
    std::cout << "word2.txt could not be opened." << std::endl;

  if (fileWords && filePassage)
    {
    /** Load vector with Word objects. **/
    std::string word;
    while (fileWords >> word)
      {
      /** Make lowercase. **/
      std::transform(word.begin(), word.end(), word.begin(), ::tolower);
      vecWordsToFind.insert(vecWordsToFind.end(), new Word(word));
      }
    fileWords.close();

    /** Read the passage file into memory one word at a time, so we can make it
        lowercase. **/
    while(filePassage >> word)
      {
      /** Make the word lowercase for ease of searching. **/
      std::transform(word.begin(), word.end(), word.begin(), ::tolower);
      passage += word + " ";
      }
    filePassage.close();

    /** Search for the strings in the passage. **/
    for(std::vector<Word*>::iterator it = vecWordsToFind.begin(); it != vecWordsToFind.end(); ++it)
      {
      /** Iterate over the passage to search for every insance of the target
          word. Find only finds the next instance, so we need to adjust its
          position every iteration. **/
      std::size_t found = passage.find((*it)->getString());
      while(found != std::string::npos)
        {
        (*it)->incrementCount();
        found = passage.find((*it)->getString(), found + 1);
        }
      
      /** Print the string. **/
      (*it)->print();
      }
    }

  system("pause");
  }
  