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
  class Transaction
    {
    /** Amount of money depositted or withdrawn always positive. */ decimal  amount;
    /** Withdraw if true; deposit if false. */                      bool     isWithdraw;
    /** Time stamp. */                                              DateTime timeStamp;
    } 
  }
