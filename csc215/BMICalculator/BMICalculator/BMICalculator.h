#pragma once
#include <iostream>
#include <string>
#include <iomanip>
#include <sstream>
#include <cctype>


/******************************************************************************
* A simple body mass index (BMI) calculator. BMI is a measurement of the
* relative percentages of fat and muscle mass in the human body. The BMI is
* equal to the weight in kilograms, divided by the square of the height in
* meters: BMI = kg / (h^2)
******************************************************************************/
class BMICalculator
  {
  /** Data Members. */
  private:
    float mHeightInches;
    float mWeight;
    float mBMI;

  /** CTOR/DTOR */
  public:
    BMICalculator() { mHeightInches = 0.0f; mWeight = 0.0f;};
    ~BMICalculator(){};

  /** Methods */
  public:
    static void loop();
  
  };

