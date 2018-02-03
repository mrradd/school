namespace Strings
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if(disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.tbString1 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.tbString2 = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.tbString3 = new System.Windows.Forms.TextBox();
      this.tbString1Reveresed = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.tbSubstringOfString1 = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.tbString2String1 = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.tbString3InString1 = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.tbIsPalindrome = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // tbString1
      // 
      this.tbString1.Location = new System.Drawing.Point(61, 14);
      this.tbString1.Name = "tbString1";
      this.tbString1.Size = new System.Drawing.Size(370, 20);
      this.tbString1.TabIndex = 0;
      this.tbString1.Leave += new System.EventHandler(this.tbString1_Leave);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 17);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(45, 15);
      this.label1.TabIndex = 1;
      this.label1.Text = "String 1";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 47);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(45, 15);
      this.label2.TabIndex = 3;
      this.label2.Text = "String 2";
      // 
      // tbString2
      // 
      this.tbString2.Location = new System.Drawing.Point(61, 44);
      this.tbString2.Name = "tbString2";
      this.tbString2.Size = new System.Drawing.Size(370, 20);
      this.tbString2.TabIndex = 2;
      this.tbString2.Leave += new System.EventHandler(this.tbString2_Leave);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 76);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(45, 15);
      this.label3.TabIndex = 5;
      this.label3.Text = "String 3";
      // 
      // tbString3
      // 
      this.tbString3.Location = new System.Drawing.Point(63, 74);
      this.tbString3.Name = "tbString3";
      this.tbString3.Size = new System.Drawing.Size(368, 20);
      this.tbString3.TabIndex = 4;
      this.tbString3.Leave += new System.EventHandler(this.tbString3_Leave);
      // 
      // tbString1Reveresed
      // 
      this.tbString1Reveresed.Location = new System.Drawing.Point(14, 147);
      this.tbString1Reveresed.Name = "tbString1Reveresed";
      this.tbString1Reveresed.ReadOnly = true;
      this.tbString1Reveresed.Size = new System.Drawing.Size(416, 20);
      this.tbString1Reveresed.TabIndex = 6;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 125);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(99, 15);
      this.label4.TabIndex = 7;
      this.label4.Text = "String 1 Reveresed";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(11, 173);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(106, 15);
      this.label5.TabIndex = 9;
      this.label5.Text = "Substring of String 1";
      // 
      // tbSubstringOfString1
      // 
      this.tbSubstringOfString1.Location = new System.Drawing.Point(13, 195);
      this.tbSubstringOfString1.Name = "tbSubstringOfString1";
      this.tbSubstringOfString1.ReadOnly = true;
      this.tbSubstringOfString1.Size = new System.Drawing.Size(416, 20);
      this.tbSubstringOfString1.TabIndex = 8;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(11, 221);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(169, 15);
      this.label6.TabIndex = 11;
      this.label6.Text = "String 2 Concatenated to String 1";
      // 
      // tbString2String1
      // 
      this.tbString2String1.Location = new System.Drawing.Point(13, 243);
      this.tbString2String1.Name = "tbString2String1";
      this.tbString2String1.ReadOnly = true;
      this.tbString2String1.Size = new System.Drawing.Size(416, 20);
      this.tbString2String1.TabIndex = 10;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(12, 278);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(137, 15);
      this.label7.TabIndex = 13;
      this.label7.Text = "String 3 Found in String 1?";
      // 
      // tbString3InString1
      // 
      this.tbString3InString1.Location = new System.Drawing.Point(155, 275);
      this.tbString3InString1.Name = "tbString3InString1";
      this.tbString3InString1.ReadOnly = true;
      this.tbString3InString1.Size = new System.Drawing.Size(136, 20);
      this.tbString3InString1.TabIndex = 12;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(28, 301);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(121, 15);
      this.label8.TabIndex = 15;
      this.label8.Text = "String 1 is Palindrome?";
      // 
      // tbIsPalindrome
      // 
      this.tbIsPalindrome.Location = new System.Drawing.Point(155, 301);
      this.tbIsPalindrome.Name = "tbIsPalindrome";
      this.tbIsPalindrome.ReadOnly = true;
      this.tbIsPalindrome.Size = new System.Drawing.Size(136, 20);
      this.tbIsPalindrome.TabIndex = 14;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
      this.ClientSize = new System.Drawing.Size(444, 337);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.tbIsPalindrome);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.tbString3InString1);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.tbString2String1);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.tbSubstringOfString1);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.tbString1Reveresed);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.tbString3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.tbString2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.tbString1);
      this.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox tbString1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tbString2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox tbString3;
    private System.Windows.Forms.TextBox tbString1Reveresed;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox tbSubstringOfString1;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox tbString2String1;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox tbString3InString1;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox tbIsPalindrome;
  }
}

