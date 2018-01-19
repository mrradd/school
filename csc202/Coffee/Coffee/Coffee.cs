using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/******************************************************************************
* Coffee */
/**
* Conrad Horton
* CSC202 Spring 2018
* 1/18/2018
* 
* Emulates purchasing coffee. User chooses a flavor, and quantity, and then a
* total cost is displayed when a check out button is pressed.
******************************************************************************/
namespace Coffee
  {
  static class Coffee
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
