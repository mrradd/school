using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/******************************************************************************
* Team */
/**
* Represents a team of players.
******************************************************************************/
namespace TeamScores
  {
  public class Team
    {
    /** List of players. */ protected BindingList<Player> mPlayerList = new BindingList<Player>();

    public BindingList<Player> playerList { get { return mPlayerList; } set { mPlayerList = value; } }

    /** CTOR */
    public Team(){ }

    /**************************************************************************
    /* meanScore */
    /**
    /* Calcualtes the mean score of the team.
    /**************************************************************************/
    public double meanScore()
      {
      int score = 0;

      for(int i = 0; i < mPlayerList.Count; i++)
        score += mPlayerList[i].score;

      return score/mPlayerList.Count;
      }
    }
  }
