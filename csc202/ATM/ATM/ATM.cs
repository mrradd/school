using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/******************************************************************************
* ATM */
/**
* Conrad Horton
* CSC202 Spring 2018
* 1/22/2018
* 
* Emulates an ATM. Consists of two screens; the first has input for the name
* and account number; the second allows for withdraws from and deposits into
* the "logged in" account.
******************************************************************************/
namespace ATM
  {
  static class ATM
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
