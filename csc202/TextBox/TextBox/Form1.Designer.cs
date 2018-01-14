namespace TextBox
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
      this.btnGo = new System.Windows.Forms.Button();
      this.tbName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.tbResult = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // btnGo
      // 
      this.btnGo.AccessibleName = "btnGo";
      this.btnGo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnGo.Location = new System.Drawing.Point(140, 75);
      this.btnGo.Name = "btnGo";
      this.btnGo.Size = new System.Drawing.Size(75, 23);
      this.btnGo.TabIndex = 0;
      this.btnGo.Text = "Go";
      this.btnGo.UseVisualStyleBackColor = true;
      this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
      // 
      // tbName
      // 
      this.tbName.AccessibleName = "tbName";
      this.tbName.Location = new System.Drawing.Point(121, 34);
      this.tbName.Name = "tbName";
      this.tbName.Size = new System.Drawing.Size(229, 20);
      this.tbName.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(3, 37);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(112, 14);
      this.label1.TabIndex = 2;
      this.label1.Text = "Enter name here";
      // 
      // tbResult
      // 
      this.tbResult.AccessibleName = "tbResult";
      this.tbResult.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbResult.Location = new System.Drawing.Point(37, 166);
      this.tbResult.Name = "tbResult";
      this.tbResult.ReadOnly = true;
      this.tbResult.Size = new System.Drawing.Size(287, 23);
      this.tbResult.TabIndex = 3;
      this.tbResult.TabStop = false;
      this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.ClientSize = new System.Drawing.Size(362, 262);
      this.Controls.Add(this.tbResult);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.tbName);
      this.Controls.Add(this.btnGo);
      this.Name = "Form1";
      this.Text = "Enter Your Name";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnGo;
    private System.Windows.Forms.TextBox tbName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox tbResult;
  }
}

