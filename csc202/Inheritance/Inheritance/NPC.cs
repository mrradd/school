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

    public bool   isGood;
    public string emotion;

    /** Returns stringified data. */
    public override string stringify
      {
      get { return $"{base.stringify}-> NPC:{{isGood: {isGood}, emotion: {emotion}}}"; }
      }

    public NPC(){ }
    public NPC(string name, string clazz, bool alive, bool isGood, string emotion) : base(name, clazz, alive)
      {
      this.isGood  = isGood;
      this.emotion = emotion;
      }
    }
  }
