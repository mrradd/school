/*******************************************************************************
* Conrad Horton
* CSC275
* Asgn 3.3 Libraries
* 08/6/2016
* 
* Implement a minimum of 5 Boost functions in a C++ program. Document which
* functions you utilized and why in a short document.
* 
* You must submit the zipped project folder, including the .exe file.
* 
* Extra Credit:
* Import and implement another external library and demonstrate its
* functionality in your code. This does not include the STL. This is worth 10
* extra credit points.
*******************************************************************************/

#include <iostream>
#include <vector>
#include <string>
#include <ctime>
#include <boost\log\trivial.hpp>
#include <boost\math\common_factor.hpp>
#include <boost\foreach.hpp>
#include <boost\random.hpp>
#include <boost\regex.hpp>

using namespace std;

void doBoostCommonFactor();
void doBoostForEach     ();
void doBoostLogTrivial  ();
void doBoostRandom      ();
void doBoostRegex       ();

int main()
  {
  doBoostCommonFactor();
  doBoostForEach     ();
  doBoostLogTrivial  ();
  doBoostRandom      ();
  doBoostRegex       ();

  system("pause");
  }

/** Calculate the Greatest common factor using boost gcd.**/
void doBoostCommonFactor()
  {
  cout << "start doBoostCommonFactor()\n";
  cout << "The GCD of 215 and 10040 is " << boost::math::gcd(215, 10040) << endl;
  cout << "end doBoostCommonFactor()\n\n";
  }

/** Performs boost's BOOST_FOREACH to iterate over a vector. **/
void doBoostForEach()
  {
  cout << "start doBoostForEach()\n";
  vector<string> vecLoremIpsum;
  vecLoremIpsum.push_back("Lorem");
  vecLoremIpsum.push_back("ipsum");
  vecLoremIpsum.push_back("dolor");
  vecLoremIpsum.push_back("imet."); 

  /** Write lorem ipsum. **/
  BOOST_FOREACH(string str, vecLoremIpsum)
    cout << str << " ";
  cout << "\n";

  cout << "end doBoostForEach()\n\n";
  }

/** Performs boost's BOOST_LOG_TRIVIAL to print a log to console. **/
void doBoostLogTrivial()
  {
  cout << "start doBoostLogTrivial()\n";
  BOOST_LOG_TRIVIAL(debug) << "A debug severity message";
  cout << "end doBoostLogTrivial()\n\n";
  }

/** Uses boost to generate random numbers.  **/
void doBoostRandom()
  {
  /** Needed to define Preprocessor directive _SCL_SECURE_NO_WARNINGS in properties/c++/preprocessor **/
  cout << "start doBoostRandom()\n";

  /** Produces the randomness. **/
  boost::random::mt19937 rng;

  /** Maps values 1-30 for number distribution. **/
  boost::random::uniform_int_distribution<> thirty(1,30);

  /** Gets the random numbers. **/
  for(int i = 0; i < 10; i++)
    cout << thirty(rng) << ", ";

  cout << "\nend doBoostRandom()\n\n";
  }

void doBoostRegex()
  {
  cout << "start doBoostRegex() -- validate credit card number 0001 989 4561 4563" << endl;

  const string str("0001 989 4561 4563");
  static const boost::regex pattern("(\\d{4}[- ]){3}\\d{4}");
  
  if (regex_match(str, pattern))
    cout << "card number valid." << endl;
  else
    cout << "card number invalid." << endl;

  cout << "end doBoostRegex()\n\n";
  }



