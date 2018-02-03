using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings
  {
  public partial class Form1 : Form
    {
    /** User entered strings. */
    public string mString1 = "";
    public string mString2 = "";
    public string mString3 = "";

    /** Reveresed mString1. */
    public string reverseString1 { get { return new string(mString1.ToCharArray().Reverse().ToArray()); } }

    /** Sets/Gets mString1. */
    public string string1
      {
      get { return  mString1; }
      set { mString1 = value; }
      }

    /** Sets/Gets mString2. */
    public string string2
      {
      get { return mString2; }
      set { mString2 = value; }
      }

    /** Sets/Gets mString3. */
    public string string3
      {
      get { return mString3; }
      set { mString3 = value; }
      }

    public Form1()
      {
      InitializeComponent();

      /** Bind result text boxes to the strings. */
      tbString1.DataBindings.Add("Text", this, "string1", false, DataSourceUpdateMode.OnPropertyChanged);
      tbString2.DataBindings.Add("Text", this, "string2", false, DataSourceUpdateMode.OnPropertyChanged);
      tbString3.DataBindings.Add("Text", this, "string3", false, DataSourceUpdateMode.OnPropertyChanged);
      }

    /**************************************************************************
    * tbString1_Leave */
    /**
    * Updates all text boxes.
    **************************************************************************/
    private void tbString1_Leave(object sender, EventArgs e)
      {
      /** Update the reveresed string text box. */
      tbString1Reveresed.Text = reverseString1;

      /** Update the is palindrome text box. Scrub all punctuation and spaces, make the words lower case, then test if palindrome. */
      string s = Regex.Replace(mString1,       @"[^\w]", "").ToLower();
      string r = Regex.Replace(reverseString1, @"[^\w]", "").ToLower();
      tbIsPalindrome.Text = s == r ? "Yes" : "No";

      /** Update substring text box. Make sure we do not take a substring larger than the string. */
      tbSubstringOfString1.Text = mString1.Substring(0, mString1.Length >= 3 ? 3 : mString1.Length).ToString();

      /** Update String3 in String1 text box. */
      tbString3InString1.Text = mString1.ToLower().Contains(mString3.ToLower()) ? "Yes" : "No";

      /** Update String2 concatenated to String1 text box. */
      tbString2String1.Text = mString1 + mString2;
      }

    /**************************************************************************
    * tbString2_Leave */
    /**
    * Updates the String 2 Concatenated to String 1 text box.
    **************************************************************************/
    private void tbString2_Leave(object sender, EventArgs e)
      {
      tbString2String1.Text = mString1 + mString2;
      }

    /**************************************************************************
    * tbString3_Leave */
    /**
    * Updates the String 3 Found In String 1 text box.
    **************************************************************************/
    private void tbString3_Leave(object sender, EventArgs e)
      {
      tbString3InString1.Text = mString1.ToLower().Contains(mString3.ToLower()) ? "Yes" : "No";
      }
    }
  }
