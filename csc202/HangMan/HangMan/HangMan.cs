using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/******************************************************************************
* HangMan */
/**
* Conrad Horton
* CSC202 Spring 2018
* 2/5/2018
* 
* Loads an array with 10 words. The user guesses a letter until they guess
* incorrectly 5 times, or guess all the letters correctly. User can restart
* the game.
******************************************************************************/
namespace HangMan
  {
  static class HangMan
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
