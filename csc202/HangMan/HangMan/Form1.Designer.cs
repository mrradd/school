namespace HangMan
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
      this.label1 = new System.Windows.Forms.Label();
      this.tbGuess = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.tbWrongLetters = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.tbWordToGuess = new System.Windows.Forms.TextBox();
      this.lblWinLose = new System.Windows.Forms.Label();
      this.btnGo = new System.Windows.Forms.Button();
      this.btnReset = new System.Windows.Forms.Button();
      this.pnlGame = new System.Windows.Forms.Panel();
      this.cbDebugMode = new System.Windows.Forms.CheckBox();
      this.lblDebugAnswer = new System.Windows.Forms.Label();
      this.tbWordLength = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.btnStart = new System.Windows.Forms.Button();
      this.pnlGame.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(59, 48);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(40, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "Guess";
      // 
      // tbGuess
      // 
      this.tbGuess.Location = new System.Drawing.Point(105, 45);
      this.tbGuess.Name = "tbGuess";
      this.tbGuess.Size = new System.Drawing.Size(30, 19);
      this.tbGuess.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 73);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(96, 12);
      this.label2.TabIndex = 2;
      this.label2.Text = "Wrong Letters";
      // 
      // tbWrongLetters
      // 
      this.tbWrongLetters.Enabled = false;
      this.tbWrongLetters.Location = new System.Drawing.Point(105, 70);
      this.tbWrongLetters.Name = "tbWrongLetters";
      this.tbWrongLetters.ReadOnly = true;
      this.tbWrongLetters.Size = new System.Drawing.Size(116, 19);
      this.tbWrongLetters.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(3, 117);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(96, 12);
      this.label3.TabIndex = 4;
      this.label3.Text = "Word To Guess";
      // 
      // tbWordToGuess
      // 
      this.tbWordToGuess.Enabled = false;
      this.tbWordToGuess.Location = new System.Drawing.Point(105, 114);
      this.tbWordToGuess.Name = "tbWordToGuess";
      this.tbWordToGuess.ReadOnly = true;
      this.tbWordToGuess.Size = new System.Drawing.Size(171, 19);
      this.tbWordToGuess.TabIndex = 5;
      // 
      // lblWinLose
      // 
      this.lblWinLose.AutoSize = true;
      this.lblWinLose.Location = new System.Drawing.Point(90, 11);
      this.lblWinLose.Name = "lblWinLose";
      this.lblWinLose.Size = new System.Drawing.Size(89, 12);
      this.lblWinLose.TabIndex = 6;
      this.lblWinLose.Text = "You Win/Lose";
      // 
      // btnGo
      // 
      this.btnGo.Location = new System.Drawing.Point(105, 181);
      this.btnGo.Name = "btnGo";
      this.btnGo.Size = new System.Drawing.Size(75, 23);
      this.btnGo.TabIndex = 7;
      this.btnGo.Text = "Go";
      this.btnGo.UseVisualStyleBackColor = true;
      this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
      // 
      // btnReset
      // 
      this.btnReset.Location = new System.Drawing.Point(104, 210);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new System.Drawing.Size(75, 23);
      this.btnReset.TabIndex = 8;
      this.btnReset.Text = "Reset";
      this.btnReset.UseVisualStyleBackColor = true;
      this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
      // 
      // pnlGame
      // 
      this.pnlGame.Controls.Add(this.cbDebugMode);
      this.pnlGame.Controls.Add(this.lblDebugAnswer);
      this.pnlGame.Controls.Add(this.tbWordLength);
      this.pnlGame.Controls.Add(this.label4);
      this.pnlGame.Controls.Add(this.lblWinLose);
      this.pnlGame.Controls.Add(this.btnReset);
      this.pnlGame.Controls.Add(this.label2);
      this.pnlGame.Controls.Add(this.btnGo);
      this.pnlGame.Controls.Add(this.tbWrongLetters);
      this.pnlGame.Controls.Add(this.tbWordToGuess);
      this.pnlGame.Controls.Add(this.label1);
      this.pnlGame.Controls.Add(this.label3);
      this.pnlGame.Controls.Add(this.tbGuess);
      this.pnlGame.Location = new System.Drawing.Point(12, 12);
      this.pnlGame.Name = "pnlGame";
      this.pnlGame.Size = new System.Drawing.Size(285, 242);
      this.pnlGame.TabIndex = 9;
      // 
      // cbDebugMode
      // 
      this.cbDebugMode.AutoSize = true;
      this.cbDebugMode.Location = new System.Drawing.Point(5, 215);
      this.cbDebugMode.Name = "cbDebugMode";
      this.cbDebugMode.Size = new System.Drawing.Size(94, 16);
      this.cbDebugMode.TabIndex = 12;
      this.cbDebugMode.Text = "Debug Mode";
      this.cbDebugMode.UseVisualStyleBackColor = true;
      this.cbDebugMode.CheckedChanged += new System.EventHandler(this.cbDebugMode_CheckedChanged);
      // 
      // lblDebugAnswer
      // 
      this.lblDebugAnswer.AutoSize = true;
      this.lblDebugAnswer.Location = new System.Drawing.Point(17, 157);
      this.lblDebugAnswer.Name = "lblDebugAnswer";
      this.lblDebugAnswer.Size = new System.Drawing.Size(82, 12);
      this.lblDebugAnswer.TabIndex = 11;
      this.lblDebugAnswer.Text = "DebugAnswer";
      // 
      // tbWordLength
      // 
      this.tbWordLength.Enabled = false;
      this.tbWordLength.Location = new System.Drawing.Point(105, 135);
      this.tbWordLength.Name = "tbWordLength";
      this.tbWordLength.ReadOnly = true;
      this.tbWordLength.Size = new System.Drawing.Size(30, 19);
      this.tbWordLength.TabIndex = 10;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(17, 138);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(82, 12);
      this.label4.TabIndex = 9;
      this.label4.Text = "Word Length";
      // 
      // btnStart
      // 
      this.btnStart.Location = new System.Drawing.Point(122, 107);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(75, 23);
      this.btnStart.TabIndex = 10;
      this.btnStart.Text = "Start";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.ClientSize = new System.Drawing.Size(305, 257);
      this.Controls.Add(this.btnStart);
      this.Controls.Add(this.pnlGame);
      this.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Name = "Form1";
      this.Text = "Form1";
      this.pnlGame.ResumeLayout(false);
      this.pnlGame.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox tbGuess;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tbWrongLetters;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox tbWordToGuess;
    private System.Windows.Forms.Label lblWinLose;
    private System.Windows.Forms.Button btnGo;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.Panel pnlGame;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.TextBox tbWordLength;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label lblDebugAnswer;
    private System.Windows.Forms.CheckBox cbDebugMode;
  }
}

