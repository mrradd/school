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
    private const int LABEL_HEIGHT = 13;
    private const int LABEL_WIDTH  = 100;
    
    /** First integer. */  private int mInt1;
    /** Second integer. */ private int mInt2;

    /** Random number. */  private Random mRand = new Random();

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
      Console.WriteLine("derp");
      mInt1 = 20;
      mInt2 = 33;
      if(mLabelList.Count < 1)
        {
        mLabelList.Add(createLabel(50, 100, LABEL_WIDTH, LABEL_HEIGHT, Maths.add(mInt1, mInt2)));
        mLabelList.Add(createLabel(50, mLabelList[0].Location.Y + LABEL_HEIGHT, LABEL_WIDTH, LABEL_HEIGHT, Maths.subtract(mInt1, mInt2)));
        mLabelList.Add(createLabel(50, mLabelList[1].Location.Y + LABEL_HEIGHT, LABEL_WIDTH, LABEL_HEIGHT, Maths.multiply(mInt1, mInt2)));
        mLabelList.Add(createLabel(50, mLabelList[2].Location.Y + LABEL_HEIGHT, LABEL_WIDTH, LABEL_HEIGHT, Maths.divide(mInt1, mInt2)));
        mLabelList.Add(createLabel(50, mLabelList[3].Location.Y + LABEL_HEIGHT, LABEL_WIDTH, LABEL_HEIGHT, Maths.mod(mInt1, mInt2)));
        this.PerformLayout();
        }
      else
        {
        int r1 = mRand.Next(1,100);
        int r2 = mRand.Next(1,100);

        mLabelList[0].Text = Maths.add(mInt1, mInt2);
        mLabelList[1].Text = Maths.subtract(mInt1, mInt2);
        mLabelList[2].Text = Maths.multiply(mInt1, mInt2);
        mLabelList[3].Text = Maths.divide(mInt1, mInt2);
        mLabelList[4].Text = Maths.mod(mInt1, mInt2);

        }
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
