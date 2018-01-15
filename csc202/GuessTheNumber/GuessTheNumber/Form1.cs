using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
  {
  public partial class Form1 : Form
    {
    
    /** Current game state. */      protected bool   mFirstLoad    = true;
    /** Random number generator. */ protected Random mRand;
    /** Number to guess. */         protected int    mTargetNumber = 0;

    /** CTOR */
    public Form1()
      {
      InitializeComponent();

      /** Only show the Start button on start. */
      tbGuess      .Visible = false;
      lblEnterGuess.Visible = false;
      btnGuess     .Visible = false;
      lblResult    .Visible = false;

      mRand = new Random();
      }

    /**************************************************************************
    * btnGuess_Click */
    /**
    * Validates input, and handles guess logic.
    **************************************************************************/
    private void btnGuess_Click(object sender, EventArgs e)
      {
      string str = tbGuess.Text;
      int guess  = 0;

      if(int.TryParse(str, out guess))
        {
        /** Wrong guess. */
        if(guess != mTargetNumber)
          {
          lblResult.Text = guess < mTargetNumber ? "Too low..." : "Too high...";
          lblResult.ForeColor = System.Drawing.Color.Red;
          
          /** Set focus on the guess text box. */
          tbGuess.Focus();
          }
        /** Right guess. */
        else
          {
          lblResult.Text = "Correct!";
          lblResult.ForeColor = System.Drawing.Color.Green;
          }
        }
      else
        MessageBox.Show("Please, enter an integer.");
      }

    /**************************************************************************
    * btnStart_Click */
    /**
    * Starts the game.
    **************************************************************************/
    private void btnStart_Click(object sender, EventArgs e)
      {
      mTargetNumber = mRand.Next(1,100);

      if(mFirstLoad)
        { 
        /** Show all components, and change text of Start button. */
        tbGuess      .Visible = true;
        lblEnterGuess.Visible = true;
        btnGuess     .Visible = true;
        lblResult    .Visible = true;

        btnStart.Text = "Restart";

        /** Update the Game State. */
        mFirstLoad = false;
        }
      else
        {
        tbGuess.Text        = "";
        lblResult.Text      = "Guess the number...";
        lblResult.ForeColor = System.Drawing.Color.Black;
        }
      }
    }
  }
