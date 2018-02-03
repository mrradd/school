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

    public bool   alive;
    public string clazz;
    public string name;

    /** Returns stringified data. */
    public virtual string stringify
      {
      get { return $"Character:{{name: {name}, class: {clazz}, alive: {alive}}}\n"; }
      }

    public Character(){ }
    public Character(string name, string clazz, bool alive)
      {
      this.name   = name;
      this.clazz  = clazz;
      this.alive  = alive;
      }
    }
  }
