using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee
  {
  public partial class Form1 : Form
    {
    protected const decimal PRICE_AMERICANO = 2.75m;
    protected const decimal PRICE_LATTE     = 3.50m;
    protected const decimal PRICE_MOCHA     = 4.00m;

    /** Total amount. */ decimal mTotal;

    /**************************************************************************
    * CTOR
    **************************************************************************/
    public Form1()
      {
      InitializeComponent();
      lblAmericano.Text = PRICE_AMERICANO.ToString("C2");
      lblLatte.Text     = PRICE_LATTE.ToString("C2");
      lblMocha.Text     = PRICE_MOCHA.ToString("C2");
      this.PerformLayout();
      }

    /**************************************************************************
    * btnAmericano_Click */
    /**
    * Updates the total with values from the americano quantity field, and the
    * price of a americano.
    **************************************************************************/
    private void btnAmericano_Click(object sender, EventArgs e)
      {
      updateTotal(PRICE_AMERICANO, validateInt(tbQtyAmericano.Text));
      }

    /**************************************************************************
    * btnExit_Click */
    /**
    * Exits the program.
    **************************************************************************/
    private void btnExit_Click(object sender, EventArgs e)
      {
      Application.Exit();
      }

    /**************************************************************************
    * btnLatte_Click */
    /**
    * Updates the total with values from the latte quantity field, and the
    * price of a latte.
    **************************************************************************/
    private void btnLatte_Click(object sender, EventArgs e)
      {
      updateTotal(PRICE_LATTE, validateInt(tbQtyLatte.Text));
      }

    /**************************************************************************
    * btnMocha_Click */
    /**
    * Updates the total with values from the mocha quantity field, and the
    * price of a mocha.
    **************************************************************************/
    private void btnMocha_Click(object sender, EventArgs e)
      {
      updateTotal(PRICE_MOCHA, validateInt(tbQtyMocha.Text));
      }

    /**************************************************************************
    * updateTotal */
    /**
    * Multiplies the dollar amount and quantity, then adds the result to the
    * total to uypdate the Total label.
    * 
    * @param  dollarAmount  Dollar amount of an item.
    * @param  quantity      Quantity of an item to buy.
    **************************************************************************/
    private void updateTotal(decimal dollarAmount, int quantity)
      {
      mTotal += dollarAmount * quantity;

      lblTotalDollar.Text = mTotal.ToString("C2");
      }

    /**************************************************************************
    * validateInt */
    /**
    * Tries to cast the passed in string to an int.
    * 
    * @param  value  Value to try to cast.
    * @returns  Value cast to int.
    **************************************************************************/
    private int validateInt(string value)
      {
      try
        {
        return int.Parse(value);
        }
      catch(Exception e)
        {
        MessageBox.Show(value + " is not a valid value...");
        }
      return 0;
      }

  }
}
