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
  public class Account
    {
    /** Account number counter. */ protected static int mAccountNumberTracker = 0;

    /** Account's number. */       protected string            mAccountNumber;
    /** Balance. */                protected decimal           mBalance;
    /** Name of account holder. */ protected string            mName;
    /** List of transactions. */   protected List<Transaction> mTransactions = new List<Transaction>();

    /**************************************************************************
    * ACCESSORS
    **************************************************************************/
    /** Returns mAccountNumber. */
    public string accountNumber { get {return mAccountNumber; } }

    /** Returns/sets mBalance. */
    public decimal balance
      {
      set { mBalance = value; }
      get { return mBalance; }
      }

    /** Returns mName. */
    public string name { get { return mName; } }

    /** Increments the number tracker and returns a string of the new number. */
    public static string newAccountNumber { get { return (++mAccountNumberTracker).ToString(); } }

    /** Returns mTransactions. */
    public List<Transaction> transactions { get {return mTransactions; } }

    /** CTOR */
    public Account(){ }
    public Account(string name, decimal balance, List<Transaction> transactions = null)
      {
      this.mName          = name;
      this.mAccountNumber = Account.newAccountNumber;
      this.mBalance       = balance;
      this.mTransactions  = transactions != null ? transactions : new List<Transaction>();
      }

    /**************************************************************************
    * makeTransaction */
    /**
    * Makes a Transaction record.
    * 
    * @param  amount      Amount the Transaction is for.
    * @param  isWithdraw  Withdraw = true, Deposit = false.
    **************************************************************************/
    public void makeTransaction(decimal amount, bool isWithdraw)
      {
      mBalance += isWithdraw ? -amount : amount;
      mTransactions.Add(new Transaction(amount, isWithdraw, DateTime.Now));
      }
    }
  }
