using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/******************************************************************************
* Character */
/**
* Base class for Character types.
******************************************************************************/
namespace Inheritance
  {
  public class Character
    {
    public static readonly string FIGHTER = "FIGHTER";
    public static readonly string MONK    = "MONK";
    public static readonly string WIZARD  = "WIZARD";

    protected bool   mAlive;
    protected string mClass;
    protected string mName;

    /** Returns stringified data. */
    public virtual string display()
      {
      return $"Character:{{mName: {mName}, mClass: {mClass}, mAlive: {mAlive}}}";
      }

    public Character(){ }
    public Character(string name, string clazz, bool alive)
      {
      mName   = name;
      mClass  = clazz;
      mAlive  = alive;
      }
    }
  }
