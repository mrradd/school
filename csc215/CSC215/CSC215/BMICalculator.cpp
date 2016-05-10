#include "BMICalculator.h"

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

  std::string title = "Body Mass Index Calculator";
  std::string prog  = "Programmer:  Conrad Horton";
  std::string date  = "Date      :       20160510";

  //We want it padded to 66% the intended width.
  int pad  = 80;
  int lpad = pad  - strlen(title.c_str());
  int rpad = lpad - strlen(title.c_str()-1);

  std::cout << std::setw(pad) << std::right << std::setfill('*') << "" << std::endl;
  std::cout << std::setw(lpad) << std::right << title << std::setw(rpad) << std::left << "" << std::endl;
  std::cout << std::setw(lpad) << std::right << prog  << std::endl;
  std::cout << std::setw(lpad) << std::right << date  << std::endl;
  std::cout << "*******************************************************************************" << std::endl;

  std::cout << "\nPlease, enter your height (inches), and press enter.\t";
  std::cin  >> bmiCalc.mHeightInches;

  std::cout << "\nPlease, enter your weight (pounds), and press enter.\t";
  std::cin  >> bmiCalc.mWeight;
  
  //1"  ~ 0.0254 meters.
  //1lb ~ 0.453592 kg.
  bmiCalc.mBMI = bmiCalc.mHeightInches != 0.0f ? (bmiCalc.mWeight * 0.453592f) / powf((bmiCalc.mHeightInches * 0.0254f), 2.0f) : 0.0f;

  if (bmiCalc.mBMI != 0.0f)
    std::cout << "\nYour Body Mass Index is "  << bmiCalc.mBMI << "."  << std::endl;
  else
    std::cout << "\nUnable to calculate BMI."  << std::endl;
  
  std::cout << "\nThank you, for using Conrad's BMI calculator\n."     << std::endl;

  //WINDOWS ONLY.
  system("pause");
  }