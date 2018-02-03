using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/******************************************************************************
* Player */
/**
* Represents a player on the team.
******************************************************************************/
namespace TeamScores
  {
  public class Player
    {
    /** Player's name. */ protected string mName;
    /** Player's score.*/ protected int    mScore;

    public string name  { get { return mName; }  set { mName = value; } }

    public int    score { get { return mScore; } set { mScore = value; } }

    /** CTOR */
    public Player(){ }
    public Player(string name, int score = 0)
      {
      mName = name;
      mScore = score;
      }
    }
  }
