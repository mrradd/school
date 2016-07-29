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
  /** Buffer to hold passage file. **/ std::vector<std::string> vecPassage;

  /** Try to open files. **/
  if (!fileWords)
    {
    std::cout << "word1.txt could not be opened." << std::endl;
    return 1;
    }

  if (!filePassage)
    {
    std::cout << "word2.txt could not be opened." << std::endl;
    return 1;
    }

  /** Load vector with Words objects. **/
  std::string word;
  while (fileWords >> word)
    {
    /** Make lowercase. **/
    std::transform(word.begin(), word.end(), word.begin(), ::tolower);

    /** Add spaces to the string to match exact word. **/
    vecWordsToFind.insert(vecWordsToFind.end(), new Word(word));
    }
  fileWords.close();

  /** Read the passage file into memory. Loading into a vector to get exact
      strings. **/
  while(filePassage >> word)
    {
    /** Make the word lowercase. **/
    std::transform(word.begin(), word.end(), word.begin(), ::tolower);
    vecPassage.push_back(word);
    }
  filePassage.close();

  /** Search for the strings in the passage. **/
  for(std::vector<Word*>::iterator itw = vecWordsToFind.begin(); itw != vecWordsToFind.end(); ++itw)
    {
    /** Iterate over the passage, and search for the Word. Doing it this way,
        because find is too inaccurate since it will return matches when a word
        is in a word. **/
    for(std::vector<std::string>::iterator itp = vecPassage.begin(); itp != vecPassage.end(); ++itp)
      {
      /** Since there will be punctuation, we will match against the passage's
          word by creating a substring of the search param's length. **/
      std::string str = itp->substr(0, (*itw)->getString().length());
      
      if ((*itw)->getString() == str)
        (*itw)->incrementCount();
      }
      

    /** Print the string. **/
    (*itw)->print();
    }

  system("pause");
  }
  