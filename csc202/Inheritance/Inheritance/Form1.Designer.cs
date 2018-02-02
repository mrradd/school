namespace Inheritance
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
      this.pclCharacter = new System.Windows.Forms.Panel();
      this.tbCharName = new System.Windows.Forms.TextBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.rbCharFighter = new System.Windows.Forms.RadioButton();
      this.rbCharMonk = new System.Windows.Forms.RadioButton();
      this.rbCharWizard = new System.Windows.Forms.RadioButton();
      this.panel3 = new System.Windows.Forms.Panel();
      this.rbCharDead = new System.Windows.Forms.RadioButton();
      this.rbCharAlive = new System.Windows.Forms.RadioButton();
      this.lblCharDisplay = new System.Windows.Forms.Label();
      this.pnlFighter = new System.Windows.Forms.Panel();
      this.lblPlayerDisplay = new System.Windows.Forms.Label();
      this.panel5 = new System.Windows.Forms.Panel();
      this.rbPlayerDead = new System.Windows.Forms.RadioButton();
      this.rbPlayerAlive = new System.Windows.Forms.RadioButton();
      this.panel6 = new System.Windows.Forms.Panel();
      this.rbPlayerWizard = new System.Windows.Forms.RadioButton();
      this.rbPlayerMonk = new System.Windows.Forms.RadioButton();
      this.rbPlayerFighter = new System.Windows.Forms.RadioButton();
      this.tbPlayerName = new System.Windows.Forms.TextBox();
      this.tbPlayerExperience = new System.Windows.Forms.TextBox();
      this.tbPlayerLives = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.pnlNPC = new System.Windows.Forms.Panel();
      this.label5 = new System.Windows.Forms.Label();
      this.lblNPCDisplay = new System.Windows.Forms.Label();
      this.panel4 = new System.Windows.Forms.Panel();
      this.rbNPCDead = new System.Windows.Forms.RadioButton();
      this.rbNPCAlive = new System.Windows.Forms.RadioButton();
      this.panel7 = new System.Windows.Forms.Panel();
      this.rbNPCWizard = new System.Windows.Forms.RadioButton();
      this.rbNPCMonk = new System.Windows.Forms.RadioButton();
      this.rbNPCFighter = new System.Windows.Forms.RadioButton();
      this.tbNPCName = new System.Windows.Forms.TextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.rbNPCIsEvil = new System.Windows.Forms.RadioButton();
      this.rbNPCIsGood = new System.Windows.Forms.RadioButton();
      this.panel8 = new System.Windows.Forms.Panel();
      this.rbNPCSad = new System.Windows.Forms.RadioButton();
      this.rbNPCAngry = new System.Windows.Forms.RadioButton();
      this.rbNPCHappy = new System.Windows.Forms.RadioButton();
      this.pclCharacter.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.pnlFighter.SuspendLayout();
      this.panel5.SuspendLayout();
      this.panel6.SuspendLayout();
      this.pnlNPC.SuspendLayout();
      this.panel4.SuspendLayout();
      this.panel7.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel8.SuspendLayout();
      this.SuspendLayout();
      // 
      // pclCharacter
      // 
      this.pclCharacter.BackColor = System.Drawing.Color.PaleGreen;
      this.pclCharacter.Controls.Add(this.label1);
      this.pclCharacter.Controls.Add(this.lblCharDisplay);
      this.pclCharacter.Controls.Add(this.panel3);
      this.pclCharacter.Controls.Add(this.panel2);
      this.pclCharacter.Controls.Add(this.tbCharName);
      this.pclCharacter.Location = new System.Drawing.Point(14, 14);
      this.pclCharacter.Name = "pclCharacter";
      this.pclCharacter.Size = new System.Drawing.Size(642, 164);
      this.pclCharacter.TabIndex = 0;
      // 
      // tbCharName
      // 
      this.tbCharName.Location = new System.Drawing.Point(51, 3);
      this.tbCharName.Name = "tbCharName";
      this.tbCharName.Size = new System.Drawing.Size(233, 21);
      this.tbCharName.TabIndex = 0;
      this.tbCharName.Text = "Enter Name...";
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.rbCharWizard);
      this.panel2.Controls.Add(this.rbCharMonk);
      this.panel2.Controls.Add(this.rbCharFighter);
      this.panel2.Location = new System.Drawing.Point(380, 3);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(80, 86);
      this.panel2.TabIndex = 1;
      // 
      // rbCharFighter
      // 
      this.rbCharFighter.AutoSize = true;
      this.rbCharFighter.Location = new System.Drawing.Point(5, 4);
      this.rbCharFighter.Name = "rbCharFighter";
      this.rbCharFighter.Size = new System.Drawing.Size(64, 19);
      this.rbCharFighter.TabIndex = 0;
      this.rbCharFighter.TabStop = true;
      this.rbCharFighter.Text = "Fighter";
      this.rbCharFighter.UseVisualStyleBackColor = true;
      // 
      // rbCharMonk
      // 
      this.rbCharMonk.AutoSize = true;
      this.rbCharMonk.Location = new System.Drawing.Point(5, 31);
      this.rbCharMonk.Name = "rbCharMonk";
      this.rbCharMonk.Size = new System.Drawing.Size(56, 19);
      this.rbCharMonk.TabIndex = 1;
      this.rbCharMonk.TabStop = true;
      this.rbCharMonk.Text = "Monk";
      this.rbCharMonk.UseVisualStyleBackColor = true;
      // 
      // rbCharWizard
      // 
      this.rbCharWizard.AutoSize = true;
      this.rbCharWizard.Location = new System.Drawing.Point(3, 58);
      this.rbCharWizard.Name = "rbCharWizard";
      this.rbCharWizard.Size = new System.Drawing.Size(64, 19);
      this.rbCharWizard.TabIndex = 2;
      this.rbCharWizard.TabStop = true;
      this.rbCharWizard.Text = "Wizard";
      this.rbCharWizard.UseVisualStyleBackColor = true;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.rbCharDead);
      this.panel3.Controls.Add(this.rbCharAlive);
      this.panel3.Location = new System.Drawing.Point(292, 3);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(80, 63);
      this.panel3.TabIndex = 3;
      // 
      // rbCharDead
      // 
      this.rbCharDead.AutoSize = true;
      this.rbCharDead.Location = new System.Drawing.Point(5, 31);
      this.rbCharDead.Name = "rbCharDead";
      this.rbCharDead.Size = new System.Drawing.Size(51, 19);
      this.rbCharDead.TabIndex = 1;
      this.rbCharDead.TabStop = true;
      this.rbCharDead.Text = "Dead";
      this.rbCharDead.UseVisualStyleBackColor = true;
      // 
      // rbCharAlive
      // 
      this.rbCharAlive.AutoSize = true;
      this.rbCharAlive.BackColor = System.Drawing.Color.PaleGreen;
      this.rbCharAlive.Location = new System.Drawing.Point(5, 4);
      this.rbCharAlive.Name = "rbCharAlive";
      this.rbCharAlive.Size = new System.Drawing.Size(53, 19);
      this.rbCharAlive.TabIndex = 0;
      this.rbCharAlive.TabStop = true;
      this.rbCharAlive.Text = "Alive";
      this.rbCharAlive.UseVisualStyleBackColor = false;
      // 
      // lblCharDisplay
      // 
      this.lblCharDisplay.AutoSize = true;
      this.lblCharDisplay.Location = new System.Drawing.Point(3, 132);
      this.lblCharDisplay.Name = "lblCharDisplay";
      this.lblCharDisplay.Size = new System.Drawing.Size(182, 15);
      this.lblCharDisplay.TabIndex = 4;
      this.lblCharDisplay.Text = "LOREM IPSEM DOLAR IMET";
      // 
      // pnlFighter
      // 
      this.pnlFighter.BackColor = System.Drawing.Color.Goldenrod;
      this.pnlFighter.Controls.Add(this.label4);
      this.pnlFighter.Controls.Add(this.label3);
      this.pnlFighter.Controls.Add(this.label2);
      this.pnlFighter.Controls.Add(this.tbPlayerLives);
      this.pnlFighter.Controls.Add(this.tbPlayerExperience);
      this.pnlFighter.Controls.Add(this.lblPlayerDisplay);
      this.pnlFighter.Controls.Add(this.panel5);
      this.pnlFighter.Controls.Add(this.panel6);
      this.pnlFighter.Controls.Add(this.tbPlayerName);
      this.pnlFighter.Location = new System.Drawing.Point(14, 184);
      this.pnlFighter.Name = "pnlFighter";
      this.pnlFighter.Size = new System.Drawing.Size(642, 166);
      this.pnlFighter.TabIndex = 5;
      // 
      // lblPlayerDisplay
      // 
      this.lblPlayerDisplay.AutoSize = true;
      this.lblPlayerDisplay.Location = new System.Drawing.Point(9, 138);
      this.lblPlayerDisplay.Name = "lblPlayerDisplay";
      this.lblPlayerDisplay.Size = new System.Drawing.Size(182, 15);
      this.lblPlayerDisplay.TabIndex = 4;
      this.lblPlayerDisplay.Text = "LOREM IPSEM DOLAR IMET";
      // 
      // panel5
      // 
      this.panel5.Controls.Add(this.rbPlayerDead);
      this.panel5.Controls.Add(this.rbPlayerAlive);
      this.panel5.Location = new System.Drawing.Point(289, 3);
      this.panel5.Name = "panel5";
      this.panel5.Size = new System.Drawing.Size(80, 63);
      this.panel5.TabIndex = 3;
      // 
      // rbPlayerDead
      // 
      this.rbPlayerDead.AutoSize = true;
      this.rbPlayerDead.Location = new System.Drawing.Point(5, 31);
      this.rbPlayerDead.Name = "rbPlayerDead";
      this.rbPlayerDead.Size = new System.Drawing.Size(51, 19);
      this.rbPlayerDead.TabIndex = 1;
      this.rbPlayerDead.TabStop = true;
      this.rbPlayerDead.Text = "Dead";
      this.rbPlayerDead.UseVisualStyleBackColor = true;
      // 
      // rbPlayerAlive
      // 
      this.rbPlayerAlive.AutoSize = true;
      this.rbPlayerAlive.BackColor = System.Drawing.Color.Goldenrod;
      this.rbPlayerAlive.Location = new System.Drawing.Point(5, 4);
      this.rbPlayerAlive.Name = "rbPlayerAlive";
      this.rbPlayerAlive.Size = new System.Drawing.Size(53, 19);
      this.rbPlayerAlive.TabIndex = 0;
      this.rbPlayerAlive.TabStop = true;
      this.rbPlayerAlive.Text = "Alive";
      this.rbPlayerAlive.UseVisualStyleBackColor = false;
      // 
      // panel6
      // 
      this.panel6.Controls.Add(this.rbPlayerWizard);
      this.panel6.Controls.Add(this.rbPlayerMonk);
      this.panel6.Controls.Add(this.rbPlayerFighter);
      this.panel6.Location = new System.Drawing.Point(376, 3);
      this.panel6.Name = "panel6";
      this.panel6.Size = new System.Drawing.Size(80, 85);
      this.panel6.TabIndex = 1;
      // 
      // rbPlayerWizard
      // 
      this.rbPlayerWizard.AutoSize = true;
      this.rbPlayerWizard.Location = new System.Drawing.Point(3, 58);
      this.rbPlayerWizard.Name = "rbPlayerWizard";
      this.rbPlayerWizard.Size = new System.Drawing.Size(64, 19);
      this.rbPlayerWizard.TabIndex = 2;
      this.rbPlayerWizard.TabStop = true;
      this.rbPlayerWizard.Text = "Wizard";
      this.rbPlayerWizard.UseVisualStyleBackColor = true;
      // 
      // rbPlayerMonk
      // 
      this.rbPlayerMonk.AutoSize = true;
      this.rbPlayerMonk.Location = new System.Drawing.Point(5, 31);
      this.rbPlayerMonk.Name = "rbPlayerMonk";
      this.rbPlayerMonk.Size = new System.Drawing.Size(56, 19);
      this.rbPlayerMonk.TabIndex = 1;
      this.rbPlayerMonk.TabStop = true;
      this.rbPlayerMonk.Text = "Monk";
      this.rbPlayerMonk.UseVisualStyleBackColor = true;
      // 
      // rbPlayerFighter
      // 
      this.rbPlayerFighter.AutoSize = true;
      this.rbPlayerFighter.Location = new System.Drawing.Point(5, 4);
      this.rbPlayerFighter.Name = "rbPlayerFighter";
      this.rbPlayerFighter.Size = new System.Drawing.Size(64, 19);
      this.rbPlayerFighter.TabIndex = 0;
      this.rbPlayerFighter.TabStop = true;
      this.rbPlayerFighter.Text = "Fighter";
      this.rbPlayerFighter.UseVisualStyleBackColor = true;
      // 
      // tbPlayerName
      // 
      this.tbPlayerName.Location = new System.Drawing.Point(49, 3);
      this.tbPlayerName.Name = "tbPlayerName";
      this.tbPlayerName.Size = new System.Drawing.Size(233, 21);
      this.tbPlayerName.TabIndex = 0;
      this.tbPlayerName.Text = "Enter Name...";
      // 
      // tbPlayerExperience
      // 
      this.tbPlayerExperience.Location = new System.Drawing.Point(49, 34);
      this.tbPlayerExperience.Name = "tbPlayerExperience";
      this.tbPlayerExperience.Size = new System.Drawing.Size(170, 21);
      this.tbPlayerExperience.TabIndex = 5;
      this.tbPlayerExperience.Text = "Enter Experience Points...";
      // 
      // tbPlayerLives
      // 
      this.tbPlayerLives.Location = new System.Drawing.Point(49, 64);
      this.tbPlayerLives.Name = "tbPlayerLives";
      this.tbPlayerLives.Size = new System.Drawing.Size(170, 21);
      this.tbPlayerLives.TabIndex = 6;
      this.tbPlayerLives.Text = "Lives Remaining...";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(37, 15);
      this.label1.TabIndex = 5;
      this.label1.Text = "Name";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(5, 6);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(37, 15);
      this.label2.TabIndex = 6;
      this.label2.Text = "Name";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(9, 40);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(34, 15);
      this.label3.TabIndex = 7;
      this.label3.Text = "EXP";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(9, 69);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(36, 15);
      this.label4.TabIndex = 8;
      this.label4.Text = "Lives";
      // 
      // pnlNPC
      // 
      this.pnlNPC.BackColor = System.Drawing.Color.Salmon;
      this.pnlNPC.Controls.Add(this.panel8);
      this.pnlNPC.Controls.Add(this.panel1);
      this.pnlNPC.Controls.Add(this.label5);
      this.pnlNPC.Controls.Add(this.lblNPCDisplay);
      this.pnlNPC.Controls.Add(this.panel4);
      this.pnlNPC.Controls.Add(this.panel7);
      this.pnlNPC.Controls.Add(this.tbNPCName);
      this.pnlNPC.Location = new System.Drawing.Point(14, 358);
      this.pnlNPC.Name = "pnlNPC";
      this.pnlNPC.Size = new System.Drawing.Size(642, 164);
      this.pnlNPC.TabIndex = 6;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(3, 3);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(37, 15);
      this.label5.TabIndex = 5;
      this.label5.Text = "Name";
      // 
      // lblNPCDisplay
      // 
      this.lblNPCDisplay.AutoSize = true;
      this.lblNPCDisplay.Location = new System.Drawing.Point(3, 132);
      this.lblNPCDisplay.Name = "lblNPCDisplay";
      this.lblNPCDisplay.Size = new System.Drawing.Size(182, 15);
      this.lblNPCDisplay.TabIndex = 4;
      this.lblNPCDisplay.Text = "LOREM IPSEM DOLAR IMET";
      // 
      // panel4
      // 
      this.panel4.Controls.Add(this.rbNPCDead);
      this.panel4.Controls.Add(this.rbNPCAlive);
      this.panel4.Location = new System.Drawing.Point(292, 3);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(80, 63);
      this.panel4.TabIndex = 3;
      // 
      // rbNPCDead
      // 
      this.rbNPCDead.AutoSize = true;
      this.rbNPCDead.Location = new System.Drawing.Point(5, 31);
      this.rbNPCDead.Name = "rbNPCDead";
      this.rbNPCDead.Size = new System.Drawing.Size(51, 19);
      this.rbNPCDead.TabIndex = 1;
      this.rbNPCDead.TabStop = true;
      this.rbNPCDead.Text = "Dead";
      this.rbNPCDead.UseVisualStyleBackColor = true;
      // 
      // rbNPCAlive
      // 
      this.rbNPCAlive.AutoSize = true;
      this.rbNPCAlive.BackColor = System.Drawing.Color.Salmon;
      this.rbNPCAlive.Location = new System.Drawing.Point(5, 4);
      this.rbNPCAlive.Name = "rbNPCAlive";
      this.rbNPCAlive.Size = new System.Drawing.Size(53, 19);
      this.rbNPCAlive.TabIndex = 0;
      this.rbNPCAlive.TabStop = true;
      this.rbNPCAlive.Text = "Alive";
      this.rbNPCAlive.UseVisualStyleBackColor = false;
      // 
      // panel7
      // 
      this.panel7.Controls.Add(this.rbNPCWizard);
      this.panel7.Controls.Add(this.rbNPCMonk);
      this.panel7.Controls.Add(this.rbNPCFighter);
      this.panel7.Location = new System.Drawing.Point(380, 3);
      this.panel7.Name = "panel7";
      this.panel7.Size = new System.Drawing.Size(80, 87);
      this.panel7.TabIndex = 1;
      // 
      // rbNPCWizard
      // 
      this.rbNPCWizard.AutoSize = true;
      this.rbNPCWizard.Location = new System.Drawing.Point(3, 58);
      this.rbNPCWizard.Name = "rbNPCWizard";
      this.rbNPCWizard.Size = new System.Drawing.Size(64, 19);
      this.rbNPCWizard.TabIndex = 2;
      this.rbNPCWizard.TabStop = true;
      this.rbNPCWizard.Text = "Wizard";
      this.rbNPCWizard.UseVisualStyleBackColor = true;
      // 
      // rbNPCMonk
      // 
      this.rbNPCMonk.AutoSize = true;
      this.rbNPCMonk.Location = new System.Drawing.Point(5, 31);
      this.rbNPCMonk.Name = "rbNPCMonk";
      this.rbNPCMonk.Size = new System.Drawing.Size(56, 19);
      this.rbNPCMonk.TabIndex = 1;
      this.rbNPCMonk.TabStop = true;
      this.rbNPCMonk.Text = "Monk";
      this.rbNPCMonk.UseVisualStyleBackColor = true;
      // 
      // rbNPCFighter
      // 
      this.rbNPCFighter.AutoSize = true;
      this.rbNPCFighter.Location = new System.Drawing.Point(5, 4);
      this.rbNPCFighter.Name = "rbNPCFighter";
      this.rbNPCFighter.Size = new System.Drawing.Size(64, 19);
      this.rbNPCFighter.TabIndex = 0;
      this.rbNPCFighter.TabStop = true;
      this.rbNPCFighter.Text = "Fighter";
      this.rbNPCFighter.UseVisualStyleBackColor = true;
      // 
      // tbNPCName
      // 
      this.tbNPCName.Location = new System.Drawing.Point(51, 3);
      this.tbNPCName.Name = "tbNPCName";
      this.tbNPCName.Size = new System.Drawing.Size(233, 21);
      this.tbNPCName.TabIndex = 0;
      this.tbNPCName.Text = "Enter Name...";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.rbNPCIsEvil);
      this.panel1.Controls.Add(this.rbNPCIsGood);
      this.panel1.Location = new System.Drawing.Point(467, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(80, 63);
      this.panel1.TabIndex = 4;
      // 
      // rbNPCIsEvil
      // 
      this.rbNPCIsEvil.AutoSize = true;
      this.rbNPCIsEvil.Location = new System.Drawing.Point(5, 31);
      this.rbNPCIsEvil.Name = "rbNPCIsEvil";
      this.rbNPCIsEvil.Size = new System.Drawing.Size(48, 19);
      this.rbNPCIsEvil.TabIndex = 1;
      this.rbNPCIsEvil.TabStop = true;
      this.rbNPCIsEvil.Text = "Evil";
      this.rbNPCIsEvil.UseVisualStyleBackColor = true;
      // 
      // rbNPCIsGood
      // 
      this.rbNPCIsGood.AutoSize = true;
      this.rbNPCIsGood.BackColor = System.Drawing.Color.Salmon;
      this.rbNPCIsGood.Location = new System.Drawing.Point(5, 4);
      this.rbNPCIsGood.Name = "rbNPCIsGood";
      this.rbNPCIsGood.Size = new System.Drawing.Size(52, 19);
      this.rbNPCIsGood.TabIndex = 0;
      this.rbNPCIsGood.TabStop = true;
      this.rbNPCIsGood.Text = "Good";
      this.rbNPCIsGood.UseVisualStyleBackColor = false;
      // 
      // panel8
      // 
      this.panel8.Controls.Add(this.rbNPCSad);
      this.panel8.Controls.Add(this.rbNPCAngry);
      this.panel8.Controls.Add(this.rbNPCHappy);
      this.panel8.Location = new System.Drawing.Point(555, 3);
      this.panel8.Name = "panel8";
      this.panel8.Size = new System.Drawing.Size(80, 87);
      this.panel8.TabIndex = 3;
      // 
      // rbNPCSad
      // 
      this.rbNPCSad.AutoSize = true;
      this.rbNPCSad.Location = new System.Drawing.Point(3, 58);
      this.rbNPCSad.Name = "rbNPCSad";
      this.rbNPCSad.Size = new System.Drawing.Size(44, 19);
      this.rbNPCSad.TabIndex = 2;
      this.rbNPCSad.TabStop = true;
      this.rbNPCSad.Text = "Sad";
      this.rbNPCSad.UseVisualStyleBackColor = true;
      // 
      // rbNPCAngry
      // 
      this.rbNPCAngry.AutoSize = true;
      this.rbNPCAngry.Location = new System.Drawing.Point(5, 31);
      this.rbNPCAngry.Name = "rbNPCAngry";
      this.rbNPCAngry.Size = new System.Drawing.Size(58, 19);
      this.rbNPCAngry.TabIndex = 1;
      this.rbNPCAngry.TabStop = true;
      this.rbNPCAngry.Text = "Angry";
      this.rbNPCAngry.UseVisualStyleBackColor = true;
      // 
      // rbNPCHappy
      // 
      this.rbNPCHappy.AutoSize = true;
      this.rbNPCHappy.Location = new System.Drawing.Point(5, 4);
      this.rbNPCHappy.Name = "rbNPCHappy";
      this.rbNPCHappy.Size = new System.Drawing.Size(60, 19);
      this.rbNPCHappy.TabIndex = 0;
      this.rbNPCHappy.TabStop = true;
      this.rbNPCHappy.Text = "Happy";
      this.rbNPCHappy.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.ClientSize = new System.Drawing.Size(670, 535);
      this.Controls.Add(this.pnlNPC);
      this.Controls.Add(this.pnlFighter);
      this.Controls.Add(this.pclCharacter);
      this.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.pclCharacter.ResumeLayout(false);
      this.pclCharacter.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.pnlFighter.ResumeLayout(false);
      this.pnlFighter.PerformLayout();
      this.panel5.ResumeLayout(false);
      this.panel5.PerformLayout();
      this.panel6.ResumeLayout(false);
      this.panel6.PerformLayout();
      this.pnlNPC.ResumeLayout(false);
      this.pnlNPC.PerformLayout();
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.panel7.ResumeLayout(false);
      this.panel7.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel8.ResumeLayout(false);
      this.panel8.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pclCharacter;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.RadioButton rbCharWizard;
    private System.Windows.Forms.RadioButton rbCharMonk;
    private System.Windows.Forms.RadioButton rbCharFighter;
    private System.Windows.Forms.TextBox tbCharName;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.RadioButton rbCharDead;
    private System.Windows.Forms.RadioButton rbCharAlive;
    private System.Windows.Forms.Label lblCharDisplay;
    private System.Windows.Forms.Panel pnlFighter;
    private System.Windows.Forms.Label lblPlayerDisplay;
    private System.Windows.Forms.Panel panel5;
    private System.Windows.Forms.RadioButton rbPlayerDead;
    private System.Windows.Forms.RadioButton rbPlayerAlive;
    private System.Windows.Forms.Panel panel6;
    private System.Windows.Forms.RadioButton rbPlayerWizard;
    private System.Windows.Forms.RadioButton rbPlayerMonk;
    private System.Windows.Forms.RadioButton rbPlayerFighter;
    private System.Windows.Forms.TextBox tbPlayerName;
    private System.Windows.Forms.TextBox tbPlayerExperience;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tbPlayerLives;
    private System.Windows.Forms.Panel pnlNPC;
    private System.Windows.Forms.Panel panel8;
    private System.Windows.Forms.RadioButton rbNPCSad;
    private System.Windows.Forms.RadioButton rbNPCAngry;
    private System.Windows.Forms.RadioButton rbNPCHappy;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.RadioButton rbNPCIsEvil;
    private System.Windows.Forms.RadioButton rbNPCIsGood;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label lblNPCDisplay;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.RadioButton rbNPCDead;
    private System.Windows.Forms.RadioButton rbNPCAlive;
    private System.Windows.Forms.Panel panel7;
    private System.Windows.Forms.RadioButton rbNPCWizard;
    private System.Windows.Forms.RadioButton rbNPCMonk;
    private System.Windows.Forms.RadioButton rbNPCFighter;
    private System.Windows.Forms.TextBox tbNPCName;
  }
}

