namespace GuessTheNumber
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
      this.tbGuess = new System.Windows.Forms.TextBox();
      this.lblEnterGuess = new System.Windows.Forms.Label();
      this.btnGuess = new System.Windows.Forms.Button();
      this.btnStart = new System.Windows.Forms.Button();
      this.lblResult = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // tbGuess
      // 
      this.tbGuess.Location = new System.Drawing.Point(123, 51);
      this.tbGuess.Name = "tbGuess";
      this.tbGuess.Size = new System.Drawing.Size(99, 20);
      this.tbGuess.TabIndex = 0;
      // 
      // lblEnterGuess
      // 
      this.lblEnterGuess.AutoSize = true;
      this.lblEnterGuess.Location = new System.Drawing.Point(54, 54);
      this.lblEnterGuess.Name = "lblEnterGuess";
      this.lblEnterGuess.Size = new System.Drawing.Size(63, 13);
      this.lblEnterGuess.TabIndex = 1;
      this.lblEnterGuess.Text = "Enter guess";
      // 
      // btnGuess
      // 
      this.btnGuess.Location = new System.Drawing.Point(104, 86);
      this.btnGuess.Name = "btnGuess";
      this.btnGuess.Size = new System.Drawing.Size(75, 23);
      this.btnGuess.TabIndex = 2;
      this.btnGuess.Text = "Guess";
      this.btnGuess.UseVisualStyleBackColor = true;
      this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
      // 
      // btnStart
      // 
      this.btnStart.Location = new System.Drawing.Point(104, 126);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(75, 23);
      this.btnStart.TabIndex = 3;
      this.btnStart.Text = "Start";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // lblResult
      // 
      this.lblResult.AutoSize = true;
      this.lblResult.Location = new System.Drawing.Point(106, 18);
      this.lblResult.Name = "lblResult";
      this.lblResult.Size = new System.Drawing.Size(102, 13);
      this.lblResult.TabIndex = 4;
      this.lblResult.Text = "Guess the number...";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.InactiveCaption;
      this.ClientSize = new System.Drawing.Size(284, 165);
      this.Controls.Add(this.lblResult);
      this.Controls.Add(this.btnStart);
      this.Controls.Add(this.btnGuess);
      this.Controls.Add(this.lblEnterGuess);
      this.Controls.Add(this.tbGuess);
      this.Name = "Form1";
      this.Text = "Guess The Number";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox tbGuess;
    private System.Windows.Forms.Label lblEnterGuess;
    private System.Windows.Forms.Button btnGuess;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Label lblResult;
  }
}

