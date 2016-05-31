
#include <iostream>
#include <sstream>
#include <fstream>
#include <vector>
#include <string>
#include <algorithm>

using namespace std;

void addBook               (vector<string>* ptrVec);
void alphabetizeBooks      (vector<string>* ptrVec);
void alphabetizeBooks      (vector<vector<string>*> ptrVec);
void clearStringVectors    (vector<vector<string>*> ptrVec);
void handleMenu            ();
void printBooks            (vector<string>* ptrVec);
void printDisplayCollection(vector<string>* ptrVec);
void printMenu             ();
void readFromFile          (vector<string>* ptrVec);
void removeBook            (vector<string>* ptrVec);
void writeToFile           (vector<string>* ptrVec);