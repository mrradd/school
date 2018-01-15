using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/******************************************************************************
* GuessTheNumber */
/**
* Conrad Horton
* CSC202 Spring 2018
* 1/15/2018
* 
* The user tries to guess a randomly generated number. The game prompts them
* whether the number is higher, lower, or has been guessed successfully.
******************************************************************************/
namespace GuessTheNumber
  {
  static class GuessTheNumber
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
