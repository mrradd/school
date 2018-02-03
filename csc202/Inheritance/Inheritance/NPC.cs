using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/******************************************************************************
* NPC */
/**
* Represents an NPC in a game.
******************************************************************************/
namespace Inheritance
  {
  public class NPC : Character
    {
    public static readonly string ANGRY = "ANGRY";
    public static readonly string HAPPY = "HAPPY";
    public static readonly string SAD   = "SAD";

    protected bool   mIsGood;
    protected string mEmotion;

    /** Returns stringified data. */
    public override string display()
      {
      return $"{base.display()} -> NPC:{{mIsGood: {mIsGood}, mEmotion: {mEmotion}}}";
      }

    public NPC(){ }
    public NPC(string name, string clazz, bool alive, bool isGood, string emotion) : base(name, clazz, alive)
      {
      mIsGood  = isGood;
      mEmotion = emotion;
      }
    }
  }
