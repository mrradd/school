using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/******************************************************************************
* Player */
/**
* Represents the Player in a game.
******************************************************************************/
namespace Inheritance
  {
  public class Player : Character
    {
    public int experience;
    public int livesRemaining;

    /** Returns stringified data. */
    public override string stringify
      {
      get { return $"{base.stringify}-> Player:{{experience: {experience}, livesRemaining: {livesRemaining}}}"; }
      }

    public Player(){ }
    public Player(string name, string clazz, bool alive, int exp, int lives) : base(name, clazz, alive)
      {
      experience     = exp;
      livesRemaining = lives;
      }
    }
  }
