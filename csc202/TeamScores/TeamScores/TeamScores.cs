using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/******************************************************************************
* TeamScores */
/**
* Conrad Horton
* CSC202 Spring 2018
* 1/26/2018
* 
* Emulates filling a score sheet out for a team. Fills an array with 11
* players. Prompts the user to enter a score for each player. Displays the
* scores, and calculates mean score.
******************************************************************************/
namespace TeamScores
  {
  static class TeamScores
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
