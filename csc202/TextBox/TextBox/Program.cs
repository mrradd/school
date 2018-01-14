using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/******************************************************************************
* TextBox */
/**
* Conrad Horton
* CSC202 Spring 2018
* 1/14/2018
* 
* Form which asks for the users name, and displays a string using the value
* enterred.
******************************************************************************/
namespace TextBox
  {
  static class Program
    {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
      {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Form1());
      }
    }
  }
