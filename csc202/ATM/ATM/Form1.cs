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

      lvTestAccounts.View = View.Details;
      
      for (int i = 0; i < mAccounts.Count; i++)
        {
        ListViewItem item = new ListViewItem(mAccounts[i].name,0);
        item.SubItems.Add(mAccounts[i].accountNumber);
        lvTestAccounts.Items.Add(item);
        }
      
	    lvTestAccounts.Columns.Add("Name", -2, HorizontalAlignment.Left);
	    lvTestAccounts.Columns.Add("Number", -2, HorizontalAlignment.Left);
      }

    /**************************************************************************
    * btnDeposit_Click */
    /**
    * Deposits money into the account.
    **************************************************************************/
    private void btnDeposit_Click(object sender, EventArgs e)
      {

      }

    /**************************************************************************
    * btnLogin_Click */
    /**
    * Handles login logic.
    **************************************************************************/
    private void btnLogin_Click(object sender, EventArgs e)
      {
      pnlWelcome.Visible = false;
      pnlMenu.Visible    = true;

      //tbWelcomeName
      //  tbWelcomeAccountNumber
      }

    /**************************************************************************
    * btnWithdraw_Click */
    /**
    * Withdraws money from the account.
    **************************************************************************/
    private void btnWithdraw_Click(object sender, EventArgs e)
      {

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
      }
  }
  }
