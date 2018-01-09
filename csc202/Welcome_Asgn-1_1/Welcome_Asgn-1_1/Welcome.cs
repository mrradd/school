/******************************************************************************
* Welcome */
/**
* Conrad Horton
* CSC202 Spring 2018
* 1/8/2018
* 
* This program prompts the user to enter their name, then displays a welcome
* message using the entered value.
******************************************************************************/
using System;

namespace Welcome_Asgn_1_1
  {
  class Welcome
    {
    static void Main(string[] args)
      {
      string name = null;
      

      /** Check if a valid value was enterred for the name. */
      while(name == null || name.Length <= 0)
        { 
        Console.WriteLine("Please, enter your name.");
        name = Console.ReadLine();
        }

      Console.WriteLine(String.Format("Hello, {0}! Welcome to C#.", name));
      Console.WriteLine("Press any key to exit...");
      Console.ReadKey();
      }
    }
  }
