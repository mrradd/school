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
    protected int mExperience;
    protected int mLivesRemaining;

    public override string display()
      {
      return $"{base.display()} -> Player:{{mExperience: {mExperience}, mLivesRemaining: {mLivesRemaining}}}";
      }

    public Player(){ }
    public Player(string name, string clazz, bool alive, int exp, int lives) : base(name, clazz, alive)
      {
      mExperience     = exp;
      mLivesRemaining = lives;
      }
    }
  }
