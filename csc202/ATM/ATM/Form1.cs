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
    public Form1()
      {
      InitializeComponent();
      pnlMenu.Visible = false;
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
      }

    /**************************************************************************
    * btnWithdraw_Click */
    /**
    * Withdraws money from the account.
    **************************************************************************/
    private void btnWithdraw_Click(object sender, EventArgs e)
      {

      }
    }
  }
