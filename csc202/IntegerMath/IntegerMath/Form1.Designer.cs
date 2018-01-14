using System.Windows.Forms;

namespace IntegerMath
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
      this.tbInt1 = new System.Windows.Forms.TextBox();
      this.lblInt1 = new System.Windows.Forms.Label();
      this.lblInt2 = new System.Windows.Forms.Label();
      this.tbInt2 = new System.Windows.Forms.TextBox();
      this.btnGo = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // tbInt1
      // 
      this.tbInt1.AccessibleName = "tbInt1";
      this.tbInt1.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.tbInt1.Location = new System.Drawing.Point(137, 14);
      this.tbInt1.Name = "tbInt1";
      this.tbInt1.Size = new System.Drawing.Size(100, 20);
      this.tbInt1.TabIndex = 0;
      // 
      // lblInt1
      // 
      this.lblInt1.AccessibleName = "lblInt1";
      this.lblInt1.AutoSize = true;
      this.lblInt1.Location = new System.Drawing.Point(37, 14);
      this.lblInt1.Name = "lblInt1";
      this.lblInt1.Size = new System.Drawing.Size(94, 13);
      this.lblInt1.TabIndex = 1;
      this.lblInt1.Text = "Enter First Number";
      // 
      // lblInt2
      // 
      this.lblInt2.AccessibleName = "lblInt2";
      this.lblInt2.AutoSize = true;
      this.lblInt2.Location = new System.Drawing.Point(19, 40);
      this.lblInt2.Name = "lblInt2";
      this.lblInt2.Size = new System.Drawing.Size(112, 13);
      this.lblInt2.TabIndex = 3;
      this.lblInt2.Text = "Enter Second Number";
      // 
      // tbInt2
      // 
      this.tbInt2.AccessibleName = "tbInt2";
      this.tbInt2.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.tbInt2.Location = new System.Drawing.Point(137, 40);
      this.tbInt2.Name = "tbInt2";
      this.tbInt2.Size = new System.Drawing.Size(100, 20);
      this.tbInt2.TabIndex = 2;
      // 
      // btnGo
      // 
      this.btnGo.AccessibleName = "btnGo";
      this.btnGo.Location = new System.Drawing.Point(96, 66);
      this.btnGo.Name = "btnGo";
      this.btnGo.Size = new System.Drawing.Size(75, 23);
      this.btnGo.TabIndex = 4;
      this.btnGo.Text = "Go";
      this.btnGo.UseVisualStyleBackColor = true;
      this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 262);
      this.Controls.Add(this.btnGo);
      this.Controls.Add(this.lblInt2);
      this.Controls.Add(this.tbInt2);
      this.Controls.Add(this.lblInt1);
      this.Controls.Add(this.tbInt1);
      this.Name = "Form1";
      this.Text = "Enter 2 Numbers";
      this.ResumeLayout(false);
      this.PerformLayout();

      }

    #endregion
    private System.Windows.Forms.TextBox tbInt1;
    private System.Windows.Forms.Label lblInt1;
    private System.Windows.Forms.Label lblInt2;
    private System.Windows.Forms.TextBox tbInt2;
    private System.Windows.Forms.Button btnGo;
  }
  }

