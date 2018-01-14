using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegerMath
  {
  public partial class Form1 : Form
    {
    /** Height of Label. */     private const int LABEL_HEIGHT = 13;
    /** Width of Label. */      private const int LABEL_WIDTH  = 100;
    /** X positoin of Label. */ private const int LABEL_X      = 50;
    
    /** First integer. */            private int    mInt1 = 1;
    /** Second integer. */           private int    mInt2 = 2;
    /** Random number generator. */  private Random mRand = new Random();

    /** List of dynamically generated labels. */
    private List<Label> mLabelList = new List<Label>();

    public Form1()
      {
      InitializeComponent();
      }

    /**************************************************************************
    * btnGo_Click */
    /**
    * Performs math operations on two integer inputs, as well as two random
    * integers, and prints their results in equation form.
    **************************************************************************/
    private void btnGo_Click(object sender, EventArgs e)
      {

      /** Validate and set first number. */
      if (!Int32.TryParse(tbInt1.Text, out mInt1))
        {
        tbInt1.Clear();
        MessageBox.Show("First Number is not a valid integer");
        return;
        }
      
      /** Validate and set set number. */
      if (!Int32.TryParse(tbInt2.Text, out mInt2))
        {
        tbInt2.Clear();
        MessageBox.Show("Second Number is not a valid integer");
        return;
        }

            /** Random numbers. */
      int r1 = mRand.Next(1,100);
      int r2 = mRand.Next(1,100);
      
      /** Load the list with Label data if it does not already have any. */
      if(mLabelList.Count < 1)
        {
        /** Calculate Y position based on previous element's position. */

        /** Do math on user entered data. */
        mLabelList.Add(createLabel(LABEL_X, 100,                            LABEL_WIDTH, LABEL_HEIGHT, Maths.add     (mInt1, mInt2)));
        mLabelList.Add(createLabel(LABEL_X, calculateLabelY(mLabelList[0]), LABEL_WIDTH, LABEL_HEIGHT, Maths.subtract(mInt1, mInt2)));
        mLabelList.Add(createLabel(LABEL_X, calculateLabelY(mLabelList[1]), LABEL_WIDTH, LABEL_HEIGHT, Maths.multiply(mInt1, mInt2)));
        mLabelList.Add(createLabel(LABEL_X, calculateLabelY(mLabelList[2]), LABEL_WIDTH, LABEL_HEIGHT, Maths.divide  (mInt1, mInt2)));
        mLabelList.Add(createLabel(LABEL_X, calculateLabelY(mLabelList[3]), LABEL_WIDTH, LABEL_HEIGHT, Maths.mod     (mInt1, mInt2)));
        
        /** Do math on random data. */
        mLabelList.Add(createLabel(LABEL_X, calculateLabelY(mLabelList[4], 20), LABEL_WIDTH, LABEL_HEIGHT, Maths.add     (r1, r2)));
        mLabelList.Add(createLabel(LABEL_X, calculateLabelY(mLabelList[5]),     LABEL_WIDTH, LABEL_HEIGHT, Maths.subtract(r1, r2)));
        mLabelList.Add(createLabel(LABEL_X, calculateLabelY(mLabelList[6]),     LABEL_WIDTH, LABEL_HEIGHT, Maths.multiply(r1, r2)));
        mLabelList.Add(createLabel(LABEL_X, calculateLabelY(mLabelList[7]),     LABEL_WIDTH, LABEL_HEIGHT, Maths.divide  (r1, r2)));
        mLabelList.Add(createLabel(LABEL_X, calculateLabelY(mLabelList[8]),     LABEL_WIDTH, LABEL_HEIGHT, Maths.mod     (r1, r2)));
        
        /** Add labels to form. */
        this.PerformLayout();
        }

      /** Update the existing data. */
      else
        {
        /** Update User entered data. */
        mLabelList[0].Text = Maths.add     (mInt1, mInt2);
        mLabelList[1].Text = Maths.subtract(mInt1, mInt2);
        mLabelList[2].Text = Maths.multiply(mInt1, mInt2);
        mLabelList[3].Text = Maths.divide  (mInt1, mInt2);
        mLabelList[4].Text = Maths.mod     (mInt1, mInt2);

        /** Update random data. */
        mLabelList[5].Text = Maths.add     (r1, r2);
        mLabelList[6].Text = Maths.subtract(r1, r2);
        mLabelList[7].Text = Maths.multiply(r1, r2);
        mLabelList[8].Text = Maths.divide  (r1, r2);
        mLabelList[9].Text = Maths.mod     (r1, r2);
        }
      }

    /**************************************************************************
    * calculateLabelY */
    /**
    * Calculates the Label's Y position.
    * 
    * @param  label   Label object to set Y position relative to.
    * @param  offset  Additional offset value to apply.
    * @returns  Value to use for position.
    **************************************************************************/
    private int calculateLabelY(Label label){ return calculateLabelY(label, 0); }
    private int calculateLabelY(Label label, int offset)
      {
      return label.Location.Y + LABEL_HEIGHT + offset;
      }

    /**************************************************************************
    * createLabel */
    /**
    * Creates a label.
    * 
    * @param  x        X coordinate.
    * @param  y        Y coordinate.
    * @param  w        Width.
    * @param  h        Height.
    * @param  message  Label message.
    * @returns  New Label.
    **************************************************************************/
    private Label createLabel(int x, int y, int w, int h, string message)
      {
      Label l = new Label();
      
      l.Location = new Point(x, y);
      l.Size     = new Size(w, h);
      l.Text     = message;
      
      this.Controls.Add(l);
      
      return l;
      }
    }
  }
