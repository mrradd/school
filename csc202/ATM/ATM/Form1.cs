using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
  {
  public partial class Form1 : Form
    {
    /** List of Accounts. */
    protected List<Account> mAccounts = new List<Account>();

    /** Account working with. */
    protected Account mAccount;

    /** CTOR */
    public Form1()
      {
      InitializeComponent();
      pnlMenu.Visible = false;
      pnlWelcome.Visible = true;

      mAccounts.Add(new Account("Ned Flanders", 1000m));
      mAccounts.Add(new Account("Homer Simpson",200m));
      mAccounts.Add(new Account("Bart Simpson", 25m));
      mAccounts.Add(new Account("Montgomery Burns", 25000000m));

      updateAccountListView();
      }

    /**************************************************************************
    * btnDeposit_Click */
    /**
    * Deposits money into the account.
    **************************************************************************/
    private void btnDeposit_Click(object sender, EventArgs e)
      {
      decimal amt = 0m;
      
      if(!decimal.TryParse(tbAmount.Text, out amt))
        {
        MessageBox.Show("Invalid amount enterred");
        return;
        }

      mAccount.makeTransaction(amt, false);
      updateTransactions();
      tbAmount.Clear();
      }

    /**************************************************************************
    * btnLogin_Click */
    /**
    * Handles login logic.
    **************************************************************************/
    private void btnLogin_Click(object sender, EventArgs e)
      {
      bool newLogin = false;
      
      /** Try to find if the account currently exists. */
      bool exists = false;
      for(int i = 0; i < mAccounts.Count; i++)
        {
        if(tbWelcomeName.Text == mAccounts[i].name || tbWelcomeAccountNumber.Text == mAccounts[i].accountNumber)
          {
          mAccount = mAccounts[i];
          exists   = true;
          break;
          }
        }

      /** If it doesn't exist, add a new record. */
      if(!exists)
        {
        /** If a name was given, make a new account. */
        if(tbWelcomeName.Text.Length > 0)
          {
          mAccount = new Account(tbWelcomeName.Text, 100m);
          mAccounts.Add(mAccount);
          MessageBox.Show($"A new account has been created for {mAccount.name}. Account number {mAccount.accountNumber}.");
          newLogin = true;

          updateAccountListView();
          }

        /** A name wasn't given. */
        else
          {
          MessageBox.Show("No account found. Enter a name, press login, and a new account will be created for you.");
          }
        }
      
      /** Login. Change panels, and update info. */
      if(newLogin || exists)
        {
        pnlWelcome.Visible = false;

        lblHeader.Text         = $"Hello, {mAccount.name} - {mAccount.accountNumber}";
        tbCurrentBalance.Text  = mAccount.balance.ToString("C2");
        pnlMenu.Visible        = true;
        }

      tbWelcomeAccountNumber.Clear();
      tbWelcomeName.Clear();
      }
    
    /**************************************************************************
    * btnLogout_Click */
    /**
    * Logs out, hides the menu screen, and displays the welcome screen.
    **************************************************************************/
    private void btnLogout_Click(object sender, EventArgs e)
      {
      pnlWelcome.Visible = true;
      pnlMenu.Visible    = false;
      mAccount           = null;

      tbAmount.Clear();
      tbCurrentBalance.Clear();
      }
    
    /**************************************************************************
    * btnWithdraw_Click */
    /**
    * Withdraws money from the account.
    **************************************************************************/
    private void btnWithdraw_Click(object sender, EventArgs e)
      {
      decimal amt = 0m;
      
      if(!decimal.TryParse(tbAmount.Text, out amt))
        {
        MessageBox.Show("Invalid amount enterred");
        return;
        }

      mAccount.makeTransaction(amt, true);
      updateTransactions();
      tbAmount.Clear();
      }

    /**************************************************************************
    * populateAccountListView */
    /**
    * Populates the Accounts list view with current account list.
    **************************************************************************/
    private void updateAccountListView()
      {
      /** Clear the list to rebuild it. */
      lvTestAccounts.Clear();

      lvTestAccounts.View = View.Details;
      
      for (int i = 0; i < mAccounts.Count; i++)
        {
        ListViewItem item = new ListViewItem(mAccounts[i].name,0);
        item.SubItems.Add(mAccounts[i].accountNumber);
        lvTestAccounts.Items.Add(item);
        }
      
	    lvTestAccounts.Columns.Add("Name", -2, HorizontalAlignment.Left);
	    lvTestAccounts.Columns.Add("Account Number", -2, HorizontalAlignment.Left);
      }

    /**************************************************************************
    * updateTransactions */
    /**
    * Populates the Transactions list view with current info.
    **************************************************************************/
    private void updateTransactions()
      {
      /** Clear the list to rebuild it. */
      lvTransactions.Clear();

      lvTransactions.View = View.Details;
      
      /** Update current balance text box. */
      tbCurrentBalance.Text = mAccount.balance.ToString("C2");

      for (int i = 0; i < mAccount.transactions.Count; i++)
        {
        ListViewItem item = new ListViewItem(mAccount.transactions[i].isWithdraw ? "Withdraw" : "Deposit" ,0);
        item.SubItems.Add(mAccount.transactions[i].amount.ToString("C2"));
        item.SubItems.Add(mAccount.transactions[i].timeStamp.ToString());
        lvTransactions.Items.Add(item);
        }
      
	    lvTransactions.Columns.Add("Type", 70, HorizontalAlignment.Left);
	    lvTransactions.Columns.Add("Amount", 90, HorizontalAlignment.Left);
      lvTransactions.Columns.Add("Time", 145, HorizontalAlignment.Left);
      }
    }
  }
