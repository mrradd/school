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
  /** File of words to search for. **/ std::ifstream      fileWords  ("word1.txt",std::ifstream::in);
  /** File to search for words in. **/ std::ifstream      filePassage("word2.txt",std::ifstream::in);
  /** File to search for words in. **/ std::ofstream      fileResults("results.txt");
  /** Vector of words to find. **/     std::vector<Word*> vecWordsToFind;
  /** Buffer to hold passage file. **/ std::string        passage;

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
      /** Make word lowercase for ease of matching later. **/
      std::transform(word.begin(), word.end(), word.begin(), ::tolower);
      vecWordsToFind.insert(vecWordsToFind.end(), new Word(word));
      }

    /** Read the passage file into memory one word at a time, so we can make
        each word lowercase. **/
    while(filePassage >> word)
      {
      /** Make the word lowercase for ease of matching later. **/
      std::transform(word.begin(), word.end(), word.begin(), ::tolower);
      passage += word + " ";
      }

    /** Search for the strings in the passage. **/
    if (fileResults)
      {
      cout << "Writing results to results.txt..." << endl;
      for(std::vector<Word*>::iterator it = vecWordsToFind.begin(); it != vecWordsToFind.end(); ++it)
        {
        /** Iterate over the passage to search for every insance of the target
            word. find() only finds the first instance, so we need to adjust its
            position every iteration. **/
        std::size_t found = passage.find((*it)->getString());
        while(found != std::string::npos)
          {
          (*it)->incrementCount();
          found = passage.find((*it)->getString(), found + 1);
          }
        string s = (*it)->toString();

        /** Write the current Word object to file. **/
        fileResults << s;
        }
      }
    else
      cout << "results.txt not found." << endl;
    }

  fileResults.close();
  fileWords  .close();
  filePassage.close();
  system("pause");
  }
  