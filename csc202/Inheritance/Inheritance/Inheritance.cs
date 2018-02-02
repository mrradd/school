using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/******************************************************************************
* Inheritance */
/**
* Conrad Horton
* CSC202 Spring 2018
* 2/2/2018
* 
* Displays properties of a base class and its two sub classes. Allows user to
* manipulate the data of all three classes.
******************************************************************************/
namespace Inheritance
  {
  static class Inheritance
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
