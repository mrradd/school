using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/******************************************************************************
* Transaction */
/**
* Represents a single transaction the user conducted. Tracks money movement,
* and the time the transaction occurred.
******************************************************************************/
namespace ATM
  {
  public class Transaction
    {
    /** Amount of money depositted or withdrawn always positive. */ protected decimal  mAmount;
    /** Withdraw if true; deposit if false. */                      protected bool     mIsWithdraw;
    /** Time stamp. */                                              protected DateTime mTimeStamp;

    /** CTOR */
    public Transaction(){ }
    public Transaction(decimal amount, bool isWithdraw, DateTime timeStamp)
      {
      this.mAmount     = amount;
      this.mIsWithdraw = isWithdraw;
      this.mTimeStamp  = timeStamp;
      }
    } 
  }
