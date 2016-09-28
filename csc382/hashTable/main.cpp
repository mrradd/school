/*******************************************************************************
* Conrad Horton
* CSC382 - September 2016
* Hash Table
* 09/24/2016
* 
* Implement a templated Hash Table data structure, implementing the following
* functionality:
*   Insert (Key, Value)
*   Retrieve(Key), returning value associated with Key
* Your program should implement a simple phone book, where names and telephone
* numbers are stored. Your hash table should use a string, or name as the key,
* and implement a hash function for the string type. Your hash table should
* handle collisions using chaining (linked lists). You could also use open
* addressing to avoid collisions. 
*******************************************************************************/
#include <iostream>
#include "HashTable.h"

int main()
  {
  Node* A = new Node {"Abe Lincoln",             "555-856-5555", NULL};
  Node* B = new Node {"Barry White",             "555-954-5568", NULL};
  Node* C = new Node {"Charles Manson",          "555-887-9956", NULL};
  Node* D = new Node {"Doc Brown",               "555-654-1234", NULL};
  Node* E = new Node {"Eli Manning",             "555-987-4567", NULL};
  Node* F = new Node {"Frank Zappa",             "555-888-7898", NULL};
  Node* G = new Node {"Gregg Ory",               "555-474-4747", NULL};
  Node* H = new Node {"House Brick",             "555-654-1234", NULL};
  Node* I = new Node {"Inny Outy",               "555-898-1251", NULL};
  Node* J = new Node {"Jay Sahn",                "555-639-9636", NULL};
  Node* K = new Node {"Killer Tofu",             "555-147-1478", NULL};
  Node* L = new Node {"Lemmi Kilmister",         "555-258-2589", NULL};
  Node* M = new Node {"Mac N. Cheese",           "555-852-8520", NULL};
  Node* N = new Node {"Noodle Hut",              "555-848-8484", NULL};
  Node* O = new Node {"Open Says Me",            "555-484-4848", NULL};
  Node* P = new Node {"Pottery Shed",            "555-656-4564", NULL};
  Node* Q = new Node {"Q",                       "555-654-1234", NULL};
  Node* R = new Node {"Ringo Starr",             "555-987-9878", NULL};
  Node* S = new Node {"Snakes and More",         "555-000-0000", NULL};
  Node* T = new Node {"Tiny Tim's Crutch Hutch", "555-000-0001", NULL};
  Node* U = new Node {"Und",                     "555-000-0002", NULL};
  Node* V = new Node {"Volcano Tom's",           "555-000-0003", NULL};
  Node* W = new Node {"Why",                     "555-000-1010", NULL};
  Node* X = new Node {"XXX",                     "555-101-1100", NULL};
  Node* Y = new Node {"Yellow Submarine",        "555-111-1011", NULL};
  Node* Z = new Node {"Zed Zed Top",             "555-111-2135", NULL};
    
  HashTable table;
    
  table.insertNode(A);
  table.insertNode(B);
  table.insertNode(C);
  table.insertNode(D);
  table.insertNode(E);
  table.insertNode(F);
  table.insertNode(G);
  table.insertNode(H);
  table.insertNode(I);
  table.insertNode(J);
  table.insertNode(K);
  table.insertNode(L);
  table.insertNode(M);
  table.insertNode(N);
  table.insertNode(O);
  table.insertNode(P);
  table.insertNode(Q);
  table.insertNode(R);
  table.insertNode(S);
  table.insertNode(T);
  table.insertNode(U);
  table.insertNode(V);
  table.insertNode(W);
  table.insertNode(X);
  table.insertNode(Y);
  table.insertNode(Z);
  table.printTable();
  table.printHistogram();
    
  Node* result = table.getNodeByKey("Zed Zed Top");
  cout << "Node key retrieved: " << result->data << endl;

  system("pause");
  return 0;
  }