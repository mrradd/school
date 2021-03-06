﻿namespace ATM
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
      this.pnlWelcome = new System.Windows.Forms.Panel();
      this.label4 = new System.Windows.Forms.Label();
      this.lvTestAccounts = new System.Windows.Forms.ListView();
      this.btnLogin = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.lblWelcomeAccountNumber = new System.Windows.Forms.Label();
      this.lblWelcomeName = new System.Windows.Forms.Label();
      this.lblWelcomeTitle = new System.Windows.Forms.Label();
      this.tbWelcomeAccountNumber = new System.Windows.Forms.TextBox();
      this.tbWelcomeName = new System.Windows.Forms.TextBox();
      this.pnlMenu = new System.Windows.Forms.Panel();
      this.label5 = new System.Windows.Forms.Label();
      this.lvTransactions = new System.Windows.Forms.ListView();
      this.btnLogout = new System.Windows.Forms.Button();
      this.tbCurrentBalance = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.tbAmount = new System.Windows.Forms.TextBox();
      this.btnWithdraw = new System.Windows.Forms.Button();
      this.btnDeposit = new System.Windows.Forms.Button();
      this.lblHeader = new System.Windows.Forms.Label();
      this.pnlWelcome.SuspendLayout();
      this.pnlMenu.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlWelcome
      // 
      this.pnlWelcome.Controls.Add(this.label4);
      this.pnlWelcome.Controls.Add(this.lvTestAccounts);
      this.pnlWelcome.Controls.Add(this.btnLogin);
      this.pnlWelcome.Controls.Add(this.label2);
      this.pnlWelcome.Controls.Add(this.lblWelcomeAccountNumber);
      this.pnlWelcome.Controls.Add(this.lblWelcomeName);
      this.pnlWelcome.Controls.Add(this.lblWelcomeTitle);
      this.pnlWelcome.Controls.Add(this.tbWelcomeAccountNumber);
      this.pnlWelcome.Controls.Add(this.tbWelcomeName);
      this.pnlWelcome.Location = new System.Drawing.Point(0, 77);
      this.pnlWelcome.Name = "pnlWelcome";
      this.pnlWelcome.Size = new System.Drawing.Size(533, 272);
      this.pnlWelcome.TabIndex = 0;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(383, 17);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(58, 14);
      this.label4.TabIndex = 8;
      this.label4.Text = "Accounts";
      // 
      // lvTestAccounts
      // 
      this.lvTestAccounts.Location = new System.Drawing.Point(303, 34);
      this.lvTestAccounts.Name = "lvTestAccounts";
      this.lvTestAccounts.Size = new System.Drawing.Size(226, 234);
      this.lvTestAccounts.TabIndex = 7;
      this.lvTestAccounts.UseCompatibleStateImageBehavior = false;
      // 
      // btnLogin
      // 
      this.btnLogin.Location = new System.Drawing.Point(112, 142);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new System.Drawing.Size(87, 25);
      this.btnLogin.TabIndex = 6;
      this.btnLogin.Text = "Login";
      this.btnLogin.UseVisualStyleBackColor = true;
      this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(145, 65);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(20, 14);
      this.label2.TabIndex = 5;
      this.label2.Text = "or";
      // 
      // lblWelcomeAccountNumber
      // 
      this.lblWelcomeAccountNumber.AutoSize = true;
      this.lblWelcomeAccountNumber.Location = new System.Drawing.Point(17, 94);
      this.lblWelcomeAccountNumber.Name = "lblWelcomeAccountNumber";
      this.lblWelcomeAccountNumber.Size = new System.Drawing.Size(100, 14);
      this.lblWelcomeAccountNumber.TabIndex = 4;
      this.lblWelcomeAccountNumber.Text = "Account Number";
      // 
      // lblWelcomeName
      // 
      this.lblWelcomeName.AutoSize = true;
      this.lblWelcomeName.Location = new System.Drawing.Point(78, 38);
      this.lblWelcomeName.Name = "lblWelcomeName";
      this.lblWelcomeName.Size = new System.Drawing.Size(38, 14);
      this.lblWelcomeName.TabIndex = 3;
      this.lblWelcomeName.Text = "Name";
      // 
      // lblWelcomeTitle
      // 
      this.lblWelcomeTitle.AutoSize = true;
      this.lblWelcomeTitle.Location = new System.Drawing.Point(59, 10);
      this.lblWelcomeTitle.Name = "lblWelcomeTitle";
      this.lblWelcomeTitle.Size = new System.Drawing.Size(186, 14);
      this.lblWelcomeTitle.TabIndex = 2;
      this.lblWelcomeTitle.Text = "Enter account number or name...";
      // 
      // tbWelcomeAccountNumber
      // 
      this.tbWelcomeAccountNumber.Location = new System.Drawing.Point(126, 90);
      this.tbWelcomeAccountNumber.Name = "tbWelcomeAccountNumber";
      this.tbWelcomeAccountNumber.Size = new System.Drawing.Size(154, 21);
      this.tbWelcomeAccountNumber.TabIndex = 1;
      // 
      // tbWelcomeName
      // 
      this.tbWelcomeName.Location = new System.Drawing.Point(126, 34);
      this.tbWelcomeName.Name = "tbWelcomeName";
      this.tbWelcomeName.Size = new System.Drawing.Size(154, 21);
      this.tbWelcomeName.TabIndex = 0;
      // 
      // pnlMenu
      // 
      this.pnlMenu.Controls.Add(this.label5);
      this.pnlMenu.Controls.Add(this.lvTransactions);
      this.pnlMenu.Controls.Add(this.btnLogout);
      this.pnlMenu.Controls.Add(this.tbCurrentBalance);
      this.pnlMenu.Controls.Add(this.label3);
      this.pnlMenu.Controls.Add(this.label1);
      this.pnlMenu.Controls.Add(this.tbAmount);
      this.pnlMenu.Controls.Add(this.btnWithdraw);
      this.pnlMenu.Controls.Add(this.btnDeposit);
      this.pnlMenu.Controls.Add(this.lblHeader);
      this.pnlMenu.Location = new System.Drawing.Point(24, 13);
      this.pnlMenu.Name = "pnlMenu";
      this.pnlMenu.Size = new System.Drawing.Size(478, 438);
      this.pnlMenu.TabIndex = 1;
      this.pnlMenu.Visible = false;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(276, 87);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(78, 14);
      this.label5.TabIndex = 9;
      this.label5.Text = "Transactions";
      // 
      // lvTransactions
      // 
      this.lvTransactions.Location = new System.Drawing.Point(160, 104);
      this.lvTransactions.Name = "lvTransactions";
      this.lvTransactions.Size = new System.Drawing.Size(311, 329);
      this.lvTransactions.TabIndex = 8;
      this.lvTransactions.UseCompatibleStateImageBehavior = false;
      // 
      // btnLogout
      // 
      this.btnLogout.Location = new System.Drawing.Point(3, 409);
      this.btnLogout.Name = "btnLogout";
      this.btnLogout.Size = new System.Drawing.Size(87, 25);
      this.btnLogout.TabIndex = 7;
      this.btnLogout.Text = "Logout";
      this.btnLogout.UseVisualStyleBackColor = true;
      this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
      // 
      // tbCurrentBalance
      // 
      this.tbCurrentBalance.Location = new System.Drawing.Point(180, 44);
      this.tbCurrentBalance.Name = "tbCurrentBalance";
      this.tbCurrentBalance.ReadOnly = true;
      this.tbCurrentBalance.Size = new System.Drawing.Size(116, 21);
      this.tbCurrentBalance.TabIndex = 6;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(75, 47);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(107, 14);
      this.label3.TabIndex = 5;
      this.label3.Text = "Current Balance $";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(9, 149);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(15, 14);
      this.label1.TabIndex = 4;
      this.label1.Text = "$";
      // 
      // tbAmount
      // 
      this.tbAmount.Location = new System.Drawing.Point(24, 145);
      this.tbAmount.Name = "tbAmount";
      this.tbAmount.Size = new System.Drawing.Size(116, 21);
      this.tbAmount.TabIndex = 3;
      // 
      // btnWithdraw
      // 
      this.btnWithdraw.Location = new System.Drawing.Point(37, 233);
      this.btnWithdraw.Name = "btnWithdraw";
      this.btnWithdraw.Size = new System.Drawing.Size(87, 25);
      this.btnWithdraw.TabIndex = 2;
      this.btnWithdraw.Text = "Withdraw";
      this.btnWithdraw.UseVisualStyleBackColor = true;
      this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
      // 
      // btnDeposit
      // 
      this.btnDeposit.Location = new System.Drawing.Point(37, 187);
      this.btnDeposit.Name = "btnDeposit";
      this.btnDeposit.Size = new System.Drawing.Size(87, 25);
      this.btnDeposit.TabIndex = 1;
      this.btnDeposit.Text = "Deposit";
      this.btnDeposit.UseVisualStyleBackColor = true;
      this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
      // 
      // lblHeader
      // 
      this.lblHeader.AutoSize = true;
      this.lblHeader.Location = new System.Drawing.Point(159, 13);
      this.lblHeader.Name = "lblHeader";
      this.lblHeader.Size = new System.Drawing.Size(141, 14);
      this.lblHeader.TabIndex = 0;
      this.lblHeader.Text = "Name - Account Number";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.InactiveCaption;
      this.ClientSize = new System.Drawing.Size(530, 460);
      this.Controls.Add(this.pnlWelcome);
      this.Controls.Add(this.pnlMenu);
      this.Font = new System.Drawing.Font("Moire", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Name = "Form1";
      this.Text = "Form1";
      this.pnlWelcome.ResumeLayout(false);
      this.pnlWelcome.PerformLayout();
      this.pnlMenu.ResumeLayout(false);
      this.pnlMenu.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnlWelcome;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblWelcomeAccountNumber;
    private System.Windows.Forms.Label lblWelcomeName;
    private System.Windows.Forms.Label lblWelcomeTitle;
    private System.Windows.Forms.TextBox tbWelcomeAccountNumber;
    private System.Windows.Forms.TextBox tbWelcomeName;
    private System.Windows.Forms.Panel pnlMenu;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox tbAmount;
    private System.Windows.Forms.Button btnWithdraw;
    private System.Windows.Forms.Button btnDeposit;
    private System.Windows.Forms.Label lblHeader;
    private System.Windows.Forms.TextBox tbCurrentBalance;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnLogout;
    private System.Windows.Forms.ListView lvTestAccounts;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ListView lvTransactions;
  }
}

