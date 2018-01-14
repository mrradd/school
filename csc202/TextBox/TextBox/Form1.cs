using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox
  {
  public partial class Form1 : Form
    {
    public Form1()
      {
      InitializeComponent();
      }

    private void Form1_Load(object sender, EventArgs e)
      {

      }

    /**************************************************************************
    * btnGo_Click */
    /**
    * Sets the Result text box using the value enterred into the Name text box.
    **************************************************************************/
    private void btnGo_Click(object sender, EventArgs e)
      {
      tbResult.Text = String.Format("Hello, {0}! Welcome to C#!!", tbName.Text);
      }
    }
  }
