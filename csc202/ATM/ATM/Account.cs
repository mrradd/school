using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/******************************************************************************
* Account */
/**
* Represents an account the user can log into. Has a name, balance, account
* number, and a list of transactions.
******************************************************************************/
namespace ATM
  {
  class Account
    {
    /** Name of account holder. */ string name;
    /** Account's number. */       string accountNumber;
    /** List of transactions. */   List<Transaction> transactions = new List<Transaction>();
    }
  }
