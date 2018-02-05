using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan
  {
  public partial class Form1 : Form
    {
    /** Debug mode flag. */                                           protected bool    mDebugMode    = false;
    /** Game has ended. */                                            protected bool    mGameOver     = false;
    /** All letters incorrectly guessed. */                           protected string  mWrongLetters = "";
    /** Word that is to be guessed. */                                protected string  mWordToGuess  = "";
    /** Word guessed so far with letters in the correct positions. */ protected char[]  mWordProgress;
    
    /** List of all words that can be guessed. */ protected string[] mWordList =
      {"cat",
       "dog",
       "racecar",
       "melon",
       "sound",
       "guitar",
       "crate",
       "football",
       "github",
       "college"};

    public Form1()
      {
      InitializeComponent();

      /** Hide the game at start. */
      pnlGame.Visible        = false;
      cbDebugMode.Checked    = false;
      lblDebugAnswer.Visible = cbDebugMode.Checked;
      }

    /**************************************************************************
    * init */
    /**
    * Initializes the game.
    **************************************************************************/
    private void init()
      {
      Random r = new Random();
      mGameOver           = false;
      lblWinLose.Visible  = false;
      mWordToGuess        = mWordList[r.Next(0, mWordList.Length - 1)];
      lblDebugAnswer.Text = mWordToGuess;
      mWrongLetters       = "";
      tbGuess.Text        = "";
      mWordProgress       = new char[mWordToGuess.Length];
      tbWrongLetters.Text = "";

      /** Load the list with # as place holders for letters. */
      for(int i = 0; i < mWordToGuess.Length; i++)
        {
        mWordProgress[i] = '#';
        }
      
      tbWordToGuess.Text = new string(mWordProgress);
      tbWordLength.Text  = tbWordToGuess.Text.Length.ToString();
      }

    /**************************************************************************
    * Events
    **************************************************************************/
    private void btnGo_Click(object sender, EventArgs e)
      {
      if(!mGameOver)
        {
        /** Verify input. */
        if(tbGuess.Text.Length > 1)
          {
          MessageBox.Show("You can only guess one letter at a time.");
          tbGuess.Text = "";
          return;
          }

        /** Check to see if the letter isn't in the word. */
        if(!mWordToGuess.Contains(tbGuess.Text))
          {
          mWrongLetters += tbGuess.Text;

          tbWrongLetters.Text = mWrongLetters;

          /** Player loses. */
          if(mWrongLetters.Length >= 5)
            {
            lblWinLose.Text    = "You Lose!";
            lblWinLose.Visible = true;
            mGameOver          = true;
            }
          }

        /** The letter is in the word. Reveal it. */
        else
          {
          for(int i = 0; i < mWordProgress.Length; i++)
            {
            if(tbGuess.Text.ToCharArray()[0] == mWordToGuess.ToCharArray()[i])
              {
              mWordProgress[i] = tbGuess.Text.ToCharArray()[0];
              }
            }

          string s           = new string(mWordProgress);
          tbWordToGuess.Text = s;

          /** The word is completely guessed. */
          if(s.Equals(mWordToGuess))
            {
            lblWinLose.Text    = "You Win!";
            lblWinLose.Visible = true;
            mGameOver          = true;
            }
          }

        tbGuess.Text = "";
        }
      }

    private void btnReset_Click(object sender, EventArgs e)
      {
      init();
      }
    
    private void btnStart_Click(object sender, EventArgs e)
      {
      pnlGame.Visible  = true;
      btnStart.Visible = false;
      init();
      }

    private void cbDebugMode_CheckedChanged(object sender, EventArgs e)
      {
      lblDebugAnswer.Visible = cbDebugMode.Checked;
      }
  }
  }
