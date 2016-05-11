#include "BMICalculator.h"
void printLine     (int lineLength = 79);
void printTitleLine(const std::string& msg, const char c = '*', float percent = 0.66f, int lineLength = 79);

/******************************************************************************
* You must create a simple body mass index (BMI) calculator. BMI is a
* measurement of the relative percentages of fat and muscle mass in the human
* body. The BMI is equal to the weight in kilograms, divided by the square of
* the height in meters: BMI = kg / (h^2)
* 
* For this project you must:
*   Create a C++ Project that will prompt the user for two values (a height in
*   inches, and a weight in pounds)
*   
*   Use cout to display prompts and results to the user.
*   
*   Prompt for user to enter height in inches
*    
*   Prompt for user to enter weight in pounds
*   
*   Use cin to store these inputs appropriately.
*   
*   Calculate the BMI from the user inputs.
*   
*   Use cout to display results to the user.
*   
*   Display BMI to user.
*   
*   Thank them for using your program.
*   
*   Program should then pause and wait for the user to press a key before
*   closing.
******************************************************************************/

void BMICalculator::loop()
  {
  BMICalculator bmiCalc;

  std::string title = "|  Body Mass Index Calculator  |";
  std::string prog  = "|  Programmer:  Conrad Horton  |";
  std::string date  = "|  Date      :       20160510  |";

  printLine();
  printTitleLine(title);
  printTitleLine(prog);
  printTitleLine(date);
  printLine();

  std::cout << "\nPlease, enter your height (inches), and press enter.\t";
  std::cin  >> bmiCalc.mHeightInches;

  std::cout << "\nPlease, enter your weight (pounds), and press enter.\t";
  std::cin  >> bmiCalc.mWeight;

  //1"  ~ 0.0254 meters.
  //1lb ~ 0.453592 kg.
  bmiCalc.mBMI = bmiCalc.mHeightInches != 0.0f ? (bmiCalc.mWeight * 0.453592f) / powf((bmiCalc.mHeightInches * 0.0254f), 2.0f) : 0.0f;

  std::ostringstream oss;
  oss << std::left << "| HEIGHT = " << bmiCalc.mHeightInches << """, WEIGHT = " << bmiCalc.mWeight << "lbs" << ", BMI = " << bmiCalc.mBMI << " |";
  std::string s = oss.str();
  
  std::cout << std::endl;
  printLine();
  printTitleLine(oss.str(), '*', 0.77f);
  printLine();
  std::cout << "\nThank you, for using Conrad's BMI calculator\n."     << std::endl;



  //WINDOWS ONLY.
  system("pause");
  }

void printLine(int lineLength)
  {
  std::cout << std::setw(lineLength) << std::right << std::setfill('*') << "" << std::endl;
  }

void printTitleLine(const std::string& msg, const char c, float percent, int lineLength)
  {
  //We want it padded to 66% the intended width.
  int lpad = lineLength * percent;
  int rpad = lineLength - lpad;
  std::cout << std::setw(lpad) << std::right << std::setfill(c) << msg << std::setw(rpad) << std::left << std::setfill(c) << "" << std::endl;
  }