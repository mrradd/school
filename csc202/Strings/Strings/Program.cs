using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/******************************************************************************
* Program */
/**
* Conrad Horton
* CSC202 Spring 2018
* 2/3/2018
* 
* Takes in a String and displays it in reverse order. Determines if the string
* is a palindrome. Prints a substring of the first three characters.
* Concatenates the string with another user enterred string and displays it.
* Searches the original string with another user enterred string.
******************************************************************************/
namespace Strings
  {
  static class Program
    {
    /**************************************************************************
    * Main */
    /**
    * Main entry point for program.
    **************************************************************************/
    [STAThread]
    static void Main()
      {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Form1());
     }
    }
  }
