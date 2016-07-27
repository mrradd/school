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
#include "Word.h"

int main()
  {
  std::ifstream fileWords  ("word1.txt", std::ifstream::in);
  std::ifstream filePassage("word2.txt", std::ifstream::in);
  
  if (!fileWords)
    std::cout << "word1.txt could not be opened." << std::endl;

  if (!filePassage)
    std::cout << "word2.txt could not be opened." << std::endl;
  
  std::vector<Word*> searchWords;
  
  std::string str;
  while (fileWords >> str)
    {
    searchWords.insert(searchWords.end(), new Word(str));
    std::cout << str << std::endl;
    }
  }
  