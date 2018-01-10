/******************************************************************************
* IntegerMath */
/**
* Conrad Horton
* CSC202 Spring 2018
* 1/9/2018
* 
* Form which asks for two integers to be input by the user, then performs
* addition, subtraction, division, multiplication, and modulo on them. Also
* does the same operations with two random integers.
******************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegerMath
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
