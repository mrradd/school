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
      this.gbCharacterClass = new System.Windows.Forms.GroupBox();
      this.rbCharacterWizard = new System.Windows.Forms.RadioButton();
      this.rbCharacterFighter = new System.Windows.Forms.RadioButton();
      this.rbCharacterMonk = new System.Windows.Forms.RadioButton();
      this.gbCharacterAlive = new System.Windows.Forms.GroupBox();
      this.rbCharacterAliveNo = new System.Windows.Forms.RadioButton();
      this.rbCharacterAliveYes = new System.Windows.Forms.RadioButton();
      this.label1 = new System.Windows.Forms.Label();
      this.lblCharacterDisplay = new System.Windows.Forms.Label();
      this.tbCharacterName = new System.Windows.Forms.TextBox();
      this.pnlFighter = new System.Windows.Forms.Panel();
      this.gbPlayerClass = new System.Windows.Forms.GroupBox();
      this.rbPlayerWizard = new System.Windows.Forms.RadioButton();
      this.rbPlayerFighter = new System.Windows.Forms.RadioButton();
      this.rbPlayerMonk = new System.Windows.Forms.RadioButton();
      this.gbPlayerAlive = new System.Windows.Forms.GroupBox();
      this.rbPlayerAliveNo = new System.Windows.Forms.RadioButton();
      this.rbPlayerAliveYes = new System.Windows.Forms.RadioButton();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.tbPlayerLives = new System.Windows.Forms.TextBox();
      this.tbPlayerExperience = new System.Windows.Forms.TextBox();
      this.lblPlayerDisplay = new System.Windows.Forms.Label();
      this.tbPlayerName = new System.Windows.Forms.TextBox();
      this.pnlNPC = new System.Windows.Forms.Panel();
      this.gbNPCEmotion = new System.Windows.Forms.GroupBox();
      this.rbNPCSad = new System.Windows.Forms.RadioButton();
      this.rbNPCAngry = new System.Windows.Forms.RadioButton();
      this.rbNPCHappy = new System.Windows.Forms.RadioButton();
      this.gbNPCIsGood = new System.Windows.Forms.GroupBox();
      this.rbNPCIsGoodNo = new System.Windows.Forms.RadioButton();
      this.rbNPCIsGoodYes = new System.Windows.Forms.RadioButton();
      this.gbNPCClass = new System.Windows.Forms.GroupBox();
      this.rbNPCWizard = new System.Windows.Forms.RadioButton();
      this.rbNPCFighter = new System.Windows.Forms.RadioButton();
      this.rbNPCMonk = new System.Windows.Forms.RadioButton();
      this.gbNPCAlive = new System.Windows.Forms.GroupBox();
      this.rbNPCAliveNo = new System.Windows.Forms.RadioButton();
      this.rbNPCAliveYes = new System.Windows.Forms.RadioButton();
      this.label5 = new System.Windows.Forms.Label();
      this.lblNPCDisplay = new System.Windows.Forms.Label();
      this.tbNPCName = new System.Windows.Forms.TextBox();
      this.pclCharacter.SuspendLayout();
      this.gbCharacterClass.SuspendLayout();
      this.gbCharacterAlive.SuspendLayout();
      this.pnlFighter.SuspendLayout();
      this.gbPlayerClass.SuspendLayout();
      this.gbPlayerAlive.SuspendLayout();
      this.pnlNPC.SuspendLayout();
      this.gbNPCEmotion.SuspendLayout();
      this.gbNPCIsGood.SuspendLayout();
      this.gbNPCClass.SuspendLayout();
      this.gbNPCAlive.SuspendLayout();
      this.SuspendLayout();
      // 
      // pclCharacter
      // 
      this.pclCharacter.BackColor = System.Drawing.Color.PaleGreen;
      this.pclCharacter.Controls.Add(this.gbCharacterClass);
      this.pclCharacter.Controls.Add(this.gbCharacterAlive);
      this.pclCharacter.Controls.Add(this.label1);
      this.pclCharacter.Controls.Add(this.lblCharacterDisplay);
      this.pclCharacter.Controls.Add(this.tbCharacterName);
      this.pclCharacter.Location = new System.Drawing.Point(12, 12);
      this.pclCharacter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.pclCharacter.Name = "pclCharacter";
      this.pclCharacter.Size = new System.Drawing.Size(556, 153);
      this.pclCharacter.TabIndex = 0;
      // 
      // gbCharacterClass
      // 
      this.gbCharacterClass.Controls.Add(this.rbCharacterWizard);
      this.gbCharacterClass.Controls.Add(this.rbCharacterFighter);
      this.gbCharacterClass.Controls.Add(this.rbCharacterMonk);
      this.gbCharacterClass.Location = new System.Drawing.Point(311, 2);
      this.gbCharacterClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.gbCharacterClass.Name = "gbCharacterClass";
      this.gbCharacterClass.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.gbCharacterClass.Size = new System.Drawing.Size(71, 88);
      this.gbCharacterClass.TabIndex = 10;
      this.gbCharacterClass.TabStop = false;
      this.gbCharacterClass.Text = "Class";
      // 
      // rbCharacterWizard
      // 
      this.rbCharacterWizard.AutoSize = true;
      this.rbCharacterWizard.Location = new System.Drawing.Point(5, 66);
      this.rbCharacterWizard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rbCharacterWizard.Name = "rbCharacterWizard";
      this.rbCharacterWizard.Size = new System.Drawing.Size(63, 19);
      this.rbCharacterWizard.TabIndex = 2;
      this.rbCharacterWizard.TabStop = true;
      this.rbCharacterWizard.Text = "Wizard";
      this.rbCharacterWizard.UseVisualStyleBackColor = true;
      this.rbCharacterWizard.CheckedChanged += new System.EventHandler(this.rbCharacterClass_CheckedChanged);
      // 
      // rbCharacterFighter
      // 
      this.rbCharacterFighter.AutoSize = true;
      this.rbCharacterFighter.Location = new System.Drawing.Point(5, 18);
      this.rbCharacterFighter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rbCharacterFighter.Name = "rbCharacterFighter";
      this.rbCharacterFighter.Size = new System.Drawing.Size(63, 19);
      this.rbCharacterFighter.TabIndex = 0;
      this.rbCharacterFighter.TabStop = true;
      this.rbCharacterFighter.Text = "Fighter";
      this.rbCharacterFighter.UseVisualStyleBackColor = true;
      this.rbCharacterFighter.CheckedChanged += new System.EventHandler(this.rbCharacterClass_CheckedChanged);
      // 
      // rbCharacterMonk
      // 
      this.rbCharacterMonk.AutoSize = true;
      this.rbCharacterMonk.Location = new System.Drawing.Point(5, 42);
      this.rbCharacterMonk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rbCharacterMonk.Name = "rbCharacterMonk";
      this.rbCharacterMonk.Size = new System.Drawing.Size(56, 19);
      this.rbCharacterMonk.TabIndex = 1;
      this.rbCharacterMonk.TabStop = true;
      this.rbCharacterMonk.Text = "Monk";
      this.rbCharacterMonk.UseVisualStyleBackColor = true;
      this.rbCharacterMonk.CheckedChanged += new System.EventHandler(this.rbCharacterClass_CheckedChanged);
      // 
      // gbCharacterAlive
      // 
      this.gbCharacterAlive.Controls.Add(this.rbCharacterAliveNo);
      this.gbCharacterAlive.Controls.Add(this.rbCharacterAliveYes);
      this.gbCharacterAlive.Location = new System.Drawing.Point(255, 2);
      this.gbCharacterAlive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.gbCharacterAlive.Name = "gbCharacterAlive";
      this.gbCharacterAlive.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.gbCharacterAlive.Size = new System.Drawing.Size(51, 72);
      this.gbCharacterAlive.TabIndex = 8;
      this.gbCharacterAlive.TabStop = false;
      this.gbCharacterAlive.Text = "Alive";
      // 
      // rbCharacterAliveNo
      // 
      this.rbCharacterAliveNo.AutoSize = true;
      this.rbCharacterAliveNo.Location = new System.Drawing.Point(3, 42);
      this.rbCharacterAliveNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rbCharacterAliveNo.Name = "rbCharacterAliveNo";
      this.rbCharacterAliveNo.Size = new System.Drawing.Size(41, 19);
      this.rbCharacterAliveNo.TabIndex = 1;
      this.rbCharacterAliveNo.TabStop = true;
      this.rbCharacterAliveNo.Text = "No";
      this.rbCharacterAliveNo.UseVisualStyleBackColor = true;
      this.rbCharacterAliveNo.CheckedChanged += new System.EventHandler(this.rbCharacterIsAlive_CheckedChanged);
      // 
      // rbCharacterAliveYes
      // 
      this.rbCharacterAliveYes.AutoSize = true;
      this.rbCharacterAliveYes.BackColor = System.Drawing.Color.PaleGreen;
      this.rbCharacterAliveYes.Location = new System.Drawing.Point(3, 18);
      this.rbCharacterAliveYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rbCharacterAliveYes.Name = "rbCharacterAliveYes";
      this.rbCharacterAliveYes.Size = new System.Drawing.Size(45, 19);
      this.rbCharacterAliveYes.TabIndex = 0;
      this.rbCharacterAliveYes.TabStop = true;
      this.rbCharacterAliveYes.Text = "Yes";
      this.rbCharacterAliveYes.UseVisualStyleBackColor = false;
      this.rbCharacterAliveYes.CheckedChanged += new System.EventHandler(this.rbCharacterIsAlive_CheckedChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(41, 15);
      this.label1.TabIndex = 5;
      this.label1.Text = "Name";
      // 
      // lblCharacterDisplay
      // 
      this.lblCharacterDisplay.AutoSize = true;
      this.lblCharacterDisplay.Location = new System.Drawing.Point(3, 98);
      this.lblCharacterDisplay.Name = "lblCharacterDisplay";
      this.lblCharacterDisplay.Size = new System.Drawing.Size(168, 15);
      this.lblCharacterDisplay.TabIndex = 4;
      this.lblCharacterDisplay.Text = "LOREM IPSEM DOLAR IMET";
      // 
      // tbCharacterName
      // 
      this.tbCharacterName.Location = new System.Drawing.Point(45, 2);
      this.tbCharacterName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tbCharacterName.Name = "tbCharacterName";
      this.tbCharacterName.Size = new System.Drawing.Size(203, 21);
      this.tbCharacterName.TabIndex = 0;
      this.tbCharacterName.Text = "Enter Name...";
      this.tbCharacterName.TextChanged += new System.EventHandler(this.tbCharacterName_TextChanged);
      // 
      // pnlFighter
      // 
      this.pnlFighter.BackColor = System.Drawing.Color.Goldenrod;
      this.pnlFighter.Controls.Add(this.gbPlayerClass);
      this.pnlFighter.Controls.Add(this.gbPlayerAlive);
      this.pnlFighter.Controls.Add(this.label4);
      this.pnlFighter.Controls.Add(this.label3);
      this.pnlFighter.Controls.Add(this.label2);
      this.pnlFighter.Controls.Add(this.tbPlayerLives);
      this.pnlFighter.Controls.Add(this.tbPlayerExperience);
      this.pnlFighter.Controls.Add(this.lblPlayerDisplay);
      this.pnlFighter.Controls.Add(this.tbPlayerName);
      this.pnlFighter.Location = new System.Drawing.Point(10, 330);
      this.pnlFighter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.pnlFighter.Name = "pnlFighter";
      this.pnlFighter.Size = new System.Drawing.Size(556, 156);
      this.pnlFighter.TabIndex = 5;
      // 
      // gbPlayerClass
      // 
      this.gbPlayerClass.Controls.Add(this.rbPlayerWizard);
      this.gbPlayerClass.Controls.Add(this.rbPlayerFighter);
      this.gbPlayerClass.Controls.Add(this.rbPlayerMonk);
      this.gbPlayerClass.Location = new System.Drawing.Point(311, 0);
      this.gbPlayerClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.gbPlayerClass.Name = "gbPlayerClass";
      this.gbPlayerClass.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.gbPlayerClass.Size = new System.Drawing.Size(71, 88);
      this.gbPlayerClass.TabIndex = 11;
      this.gbPlayerClass.TabStop = false;
      this.gbPlayerClass.Text = "Class";
      // 
      // rbPlayerWizard
      // 
      this.rbPlayerWizard.AutoSize = true;
      this.rbPlayerWizard.Location = new System.Drawing.Point(5, 66);
      this.rbPlayerWizard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rbPlayerWizard.Name = "rbPlayerWizard";
      this.rbPlayerWizard.Size = new System.Drawing.Size(63, 19);
      this.rbPlayerWizard.TabIndex = 2;
      this.rbPlayerWizard.TabStop = true;
      this.rbPlayerWizard.Text = "Wizard";
      this.rbPlayerWizard.UseVisualStyleBackColor = true;
      this.rbPlayerWizard.CheckedChanged += new System.EventHandler(this.rbPlayerClass_CheckedChanged);
      // 
      // rbPlayerFighter
      // 
      this.rbPlayerFighter.AutoSize = true;
      this.rbPlayerFighter.Location = new System.Drawing.Point(5, 18);
      this.rbPlayerFighter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rbPlayerFighter.Name = "rbPlayerFighter";
      this.rbPlayerFighter.Size = new System.Drawing.Size(63, 19);
      this.rbPlayerFighter.TabIndex = 0;
      this.rbPlayerFighter.TabStop = true;
      this.rbPlayerFighter.Text = "Fighter";
      this.rbPlayerFighter.UseVisualStyleBackColor = true;
      this.rbPlayerFighter.CheckedChanged += new System.EventHandler(this.rbPlayerClass_CheckedChanged);
      // 
      // rbPlayerMonk
      // 
      this.rbPlayerMonk.AutoSize = true;
      this.rbPlayerMonk.Location = new System.Drawing.Point(5, 42);
      this.rbPlayerMonk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rbPlayerMonk.Name = "rbPlayerMonk";
      this.rbPlayerMonk.Size = new System.Drawing.Size(56, 19);
      this.rbPlayerMonk.TabIndex = 1;
      this.rbPlayerMonk.TabStop = true;
      this.rbPlayerMonk.Text = "Monk";
      this.rbPlayerMonk.UseVisualStyleBackColor = true;
      this.rbPlayerMonk.CheckedChanged += new System.EventHandler(this.rbPlayerClass_CheckedChanged);
      // 
      // gbPlayerAlive
      // 
      this.gbPlayerAlive.Controls.Add(this.rbPlayerAliveNo);
      this.gbPlayerAlive.Controls.Add(this.rbPlayerAliveYes);
      this.gbPlayerAlive.Location = new System.Drawing.Point(255, 0);
      this.gbPlayerAlive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.gbPlayerAlive.Name = "gbPlayerAlive";
      this.gbPlayerAlive.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.gbPlayerAlive.Size = new System.Drawing.Size(51, 72);
      this.gbPlayerAlive.TabIndex = 7;
      this.gbPlayerAlive.TabStop = false;
      this.gbPlayerAlive.Text = "Alive";
      // 
      // rbPlayerAliveNo
      // 
      this.rbPlayerAliveNo.AutoSize = true;
      this.rbPlayerAliveNo.Location = new System.Drawing.Point(3, 42);
      this.rbPlayerAliveNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rbPlayerAliveNo.Name = "rbPlayerAliveNo";
      this.rbPlayerAliveNo.Size = new System.Drawing.Size(41, 19);
      this.rbPlayerAliveNo.TabIndex = 1;
      this.rbPlayerAliveNo.TabStop = true;
      this.rbPlayerAliveNo.Text = "No";
      this.rbPlayerAliveNo.UseVisualStyleBackColor = true;
      this.rbPlayerAliveNo.CheckedChanged += new System.EventHandler(this.rbPlayerIsAlive_CheckedChanged);
      // 
      // rbPlayerAliveYes
      // 
      this.rbPlayerAliveYes.AutoSize = true;
      this.rbPlayerAliveYes.BackColor = System.Drawing.Color.Goldenrod;
      this.rbPlayerAliveYes.Location = new System.Drawing.Point(3, 18);
      this.rbPlayerAliveYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rbPlayerAliveYes.Name = "rbPlayerAliveYes";
      this.rbPlayerAliveYes.Size = new System.Drawing.Size(45, 19);
      this.rbPlayerAliveYes.TabIndex = 0;
      this.rbPlayerAliveYes.TabStop = true;
      this.rbPlayerAliveYes.Text = "Yes";
      this.rbPlayerAliveYes.UseVisualStyleBackColor = false;
      this.rbPlayerAliveYes.CheckedChanged += new System.EventHandler(this.rbPlayerIsAlive_CheckedChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(5, 63);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(35, 15);
      this.label4.TabIndex = 8;
      this.label4.Text = "Lives";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(9, 37);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(31, 15);
      this.label3.TabIndex = 7;
      this.label3.Text = "EXP";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(1, 6);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(41, 15);
      this.label2.TabIndex = 6;
      this.label2.Text = "Name";
      // 
      // tbPlayerLives
      // 
      this.tbPlayerLives.Location = new System.Drawing.Point(43, 60);
      this.tbPlayerLives.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tbPlayerLives.Name = "tbPlayerLives";
      this.tbPlayerLives.Size = new System.Drawing.Size(149, 21);
      this.tbPlayerLives.TabIndex = 6;
      this.tbPlayerLives.Text = "Lives Remaining...";
      this.tbPlayerLives.Leave += new System.EventHandler(this.tbPlayerLives_Leave);
      // 
      // tbPlayerExperience
      // 
      this.tbPlayerExperience.Location = new System.Drawing.Point(43, 32);
      this.tbPlayerExperience.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tbPlayerExperience.Name = "tbPlayerExperience";
      this.tbPlayerExperience.Size = new System.Drawing.Size(149, 21);
      this.tbPlayerExperience.TabIndex = 5;
      this.tbPlayerExperience.Text = "Enter Experience Points...";
      this.tbPlayerExperience.Leave += new System.EventHandler(this.tbPlayerExperience_Leave);
      // 
      // lblPlayerDisplay
      // 
      this.lblPlayerDisplay.AutoSize = true;
      this.lblPlayerDisplay.Location = new System.Drawing.Point(3, 110);
      this.lblPlayerDisplay.Name = "lblPlayerDisplay";
      this.lblPlayerDisplay.Size = new System.Drawing.Size(168, 15);
      this.lblPlayerDisplay.TabIndex = 4;
      this.lblPlayerDisplay.Text = "LOREM IPSEM DOLAR IMET";
      // 
      // tbPlayerName
      // 
      this.tbPlayerName.Location = new System.Drawing.Point(43, 2);
      this.tbPlayerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tbPlayerName.Name = "tbPlayerName";
      this.tbPlayerName.Size = new System.Drawing.Size(203, 21);
      this.tbPlayerName.TabIndex = 0;
      this.tbPlayerName.Text = "Enter Name...";
      this.tbPlayerName.TextChanged += new System.EventHandler(this.tbPlayerName_TextChanged);
      // 
      // pnlNPC
      // 
      this.pnlNPC.BackColor = System.Drawing.Color.Salmon;
      this.pnlNPC.Controls.Add(this.gbNPCEmotion);
      this.pnlNPC.Controls.Add(this.gbNPCIsGood);
      this.pnlNPC.Controls.Add(this.gbNPCClass);
      this.pnlNPC.Controls.Add(this.gbNPCAlive);
      this.pnlNPC.Controls.Add(this.label5);
      this.pnlNPC.Controls.Add(this.lblNPCDisplay);
      this.pnlNPC.Controls.Add(this.tbNPCName);
      this.pnlNPC.Location = new System.Drawing.Point(12, 170);
      this.pnlNPC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.pnlNPC.Name = "pnlNPC";
      this.pnlNPC.Size = new System.Drawing.Size(556, 153);
      this.pnlNPC.TabIndex = 6;
      // 
      // gbNPCEmotion
      // 
      this.gbNPCEmotion.Controls.Add(this.rbNPCSad);
      this.gbNPCEmotion.Controls.Add(this.rbNPCAngry);
      this.gbNPCEmotion.Controls.Add(this.rbNPCHappy);
      this.gbNPCEmotion.Location = new System.Drawing.Point(463, -1);
      this.gbNPCEmotion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.gbNPCEmotion.Name = "gbNPCEmotion";
      this.gbNPCEmotion.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.gbNPCEmotion.Size = new System.Drawing.Size(79, 88);
      this.gbNPCEmotion.TabIndex = 14;
      this.gbNPCEmotion.TabStop = false;
      this.gbNPCEmotion.Text = "Emotion";
      // 
      // rbNPCSad
      // 
      this.rbNPCSad.AutoSize = true;
      this.rbNPCSad.Location = new System.Drawing.Point(6, 61);
      this.rbNPCSad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rbNPCSad.Name = "rbNPCSad";
      this.rbNPCSad.Size = new System.Drawing.Size(47, 19);
      this.rbNPCSad.TabIndex = 2;
      this.rbNPCSad.TabStop = true;
      this.rbNPCSad.Text = "Sad";
      this.rbNPCSad.UseVisualStyleBackColor = true;
      this.rbNPCSad.CheckedChanged += new System.EventHandler(this.rbNPCEmotion_CheckedChanged);
      // 
      // rbNPCAngry
      // 
      this.rbNPCAngry.AutoSize = true;
      this.rbNPCAngry.Location = new System.Drawing.Point(6, 39);
      this.rbNPCAngry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rbNPCAngry.Name = "rbNPCAngry";
      this.rbNPCAngry.Size = new System.Drawing.Size(55, 19);
      this.rbNPCAngry.TabIndex = 1;
      this.rbNPCAngry.TabStop = true;
      this.rbNPCAngry.Text = "Angry";
      this.rbNPCAngry.UseVisualStyleBackColor = true;
      this.rbNPCAngry.CheckedChanged += new System.EventHandler(this.rbNPCEmotion_CheckedChanged);
      // 
      // rbNPCHappy
      // 
      this.rbNPCHappy.AutoSize = true;
      this.rbNPCHappy.Location = new System.Drawing.Point(6, 16);
      this.rbNPCHappy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rbNPCHappy.Name = "rbNPCHappy";
      this.rbNPCHappy.Size = new System.Drawing.Size(60, 19);
      this.rbNPCHappy.TabIndex = 0;
      this.rbNPCHappy.TabStop = true;
      this.rbNPCHappy.Text = "Happy";
      this.rbNPCHappy.UseVisualStyleBackColor = true;
      this.rbNPCHappy.CheckedChanged += new System.EventHandler(this.rbNPCEmotion_CheckedChanged);
      // 
      // gbNPCIsGood
      // 
      this.gbNPCIsGood.Controls.Add(this.rbNPCIsGoodNo);
      this.gbNPCIsGood.Controls.Add(this.rbNPCIsGoodYes);
      this.gbNPCIsGood.Location = new System.Drawing.Point(388, 0);
      this.gbNPCIsGood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.gbNPCIsGood.Name = "gbNPCIsGood";
      this.gbNPCIsGood.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.gbNPCIsGood.Size = new System.Drawing.Size(69, 69);
      this.gbNPCIsGood.TabIndex = 13;
      this.gbNPCIsGood.TabStop = false;
      this.gbNPCIsGood.Text = "Is Good";
      // 
      // rbNPCIsGoodNo
      // 
      this.rbNPCIsGoodNo.AutoSize = true;
      this.rbNPCIsGoodNo.Location = new System.Drawing.Point(5, 39);
      this.rbNPCIsGoodNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rbNPCIsGoodNo.Name = "rbNPCIsGoodNo";
      this.rbNPCIsGoodNo.Size = new System.Drawing.Size(41, 19);
      this.rbNPCIsGoodNo.TabIndex = 1;
      this.rbNPCIsGoodNo.TabStop = true;
      this.rbNPCIsGoodNo.Text = "No";
      this.rbNPCIsGoodNo.UseVisualStyleBackColor = true;
      this.rbNPCIsGoodNo.CheckedChanged += new System.EventHandler(this.rbNPCIsGood_CheckedChanged);
      // 
      // rbNPCIsGoodYes
      // 
      this.rbNPCIsGoodYes.AutoSize = true;
      this.rbNPCIsGoodYes.Location = new System.Drawing.Point(6, 16);
      this.rbNPCIsGoodYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rbNPCIsGoodYes.Name = "rbNPCIsGoodYes";
      this.rbNPCIsGoodYes.Size = new System.Drawing.Size(45, 19);
      this.rbNPCIsGoodYes.TabIndex = 0;
      this.rbNPCIsGoodYes.TabStop = true;
      this.rbNPCIsGoodYes.Text = "Yes";
      this.rbNPCIsGoodYes.UseVisualStyleBackColor = true;
      this.rbNPCIsGoodYes.CheckedChanged += new System.EventHandler(this.rbNPCIsGood_CheckedChanged);
      // 
      // gbNPCClass
      // 
      this.gbNPCClass.Controls.Add(this.rbNPCWizard);
      this.gbNPCClass.Controls.Add(this.rbNPCFighter);
      this.gbNPCClass.Controls.Add(this.rbNPCMonk);
      this.gbNPCClass.Location = new System.Drawing.Point(311, 0);
      this.gbNPCClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.gbNPCClass.Name = "gbNPCClass";
      this.gbNPCClass.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.gbNPCClass.Size = new System.Drawing.Size(71, 88);
      this.gbNPCClass.TabIndex = 12;
      this.gbNPCClass.TabStop = false;
      this.gbNPCClass.Text = "Class";
      // 
      // rbNPCWizard
      // 
      this.rbNPCWizard.AutoSize = true;
      this.rbNPCWizard.Location = new System.Drawing.Point(5, 61);
      this.rbNPCWizard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rbNPCWizard.Name = "rbNPCWizard";
      this.rbNPCWizard.Size = new System.Drawing.Size(63, 19);
      this.rbNPCWizard.TabIndex = 2;
      this.rbNPCWizard.TabStop = true;
      this.rbNPCWizard.Text = "Wizard";
      this.rbNPCWizard.UseVisualStyleBackColor = true;
      this.rbNPCWizard.CheckedChanged += new System.EventHandler(this.rbNPCClass__CheckedChanged);
      // 
      // rbNPCFighter
      // 
      this.rbNPCFighter.AutoSize = true;
      this.rbNPCFighter.Location = new System.Drawing.Point(5, 18);
      this.rbNPCFighter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rbNPCFighter.Name = "rbNPCFighter";
      this.rbNPCFighter.Size = new System.Drawing.Size(63, 19);
      this.rbNPCFighter.TabIndex = 0;
      this.rbNPCFighter.TabStop = true;
      this.rbNPCFighter.Text = "Fighter";
      this.rbNPCFighter.UseVisualStyleBackColor = true;
      this.rbNPCFighter.CheckedChanged += new System.EventHandler(this.rbNPCClass__CheckedChanged);
      // 
      // rbNPCMonk
      // 
      this.rbNPCMonk.AutoSize = true;
      this.rbNPCMonk.Location = new System.Drawing.Point(5, 39);
      this.rbNPCMonk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rbNPCMonk.Name = "rbNPCMonk";
      this.rbNPCMonk.Size = new System.Drawing.Size(56, 19);
      this.rbNPCMonk.TabIndex = 1;
      this.rbNPCMonk.TabStop = true;
      this.rbNPCMonk.Text = "Monk";
      this.rbNPCMonk.UseVisualStyleBackColor = true;
      this.rbNPCMonk.CheckedChanged += new System.EventHandler(this.rbNPCClass__CheckedChanged);
      // 
      // gbNPCAlive
      // 
      this.gbNPCAlive.Controls.Add(this.rbNPCAliveNo);
      this.gbNPCAlive.Controls.Add(this.rbNPCAliveYes);
      this.gbNPCAlive.Location = new System.Drawing.Point(255, 0);
      this.gbNPCAlive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.gbNPCAlive.Name = "gbNPCAlive";
      this.gbNPCAlive.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.gbNPCAlive.Size = new System.Drawing.Size(51, 72);
      this.gbNPCAlive.TabIndex = 8;
      this.gbNPCAlive.TabStop = false;
      this.gbNPCAlive.Text = "Alive";
      // 
      // rbNPCAliveNo
      // 
      this.rbNPCAliveNo.AutoSize = true;
      this.rbNPCAliveNo.Location = new System.Drawing.Point(3, 39);
      this.rbNPCAliveNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rbNPCAliveNo.Name = "rbNPCAliveNo";
      this.rbNPCAliveNo.Size = new System.Drawing.Size(41, 19);
      this.rbNPCAliveNo.TabIndex = 1;
      this.rbNPCAliveNo.TabStop = true;
      this.rbNPCAliveNo.Text = "No";
      this.rbNPCAliveNo.UseVisualStyleBackColor = true;
      this.rbNPCAliveNo.CheckedChanged += new System.EventHandler(this.rbNPCIsAlive_CheckedChanged);
      // 
      // rbNPCAliveYes
      // 
      this.rbNPCAliveYes.AutoSize = true;
      this.rbNPCAliveYes.BackColor = System.Drawing.Color.Salmon;
      this.rbNPCAliveYes.Location = new System.Drawing.Point(3, 18);
      this.rbNPCAliveYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rbNPCAliveYes.Name = "rbNPCAliveYes";
      this.rbNPCAliveYes.Size = new System.Drawing.Size(45, 19);
      this.rbNPCAliveYes.TabIndex = 0;
      this.rbNPCAliveYes.TabStop = true;
      this.rbNPCAliveYes.Text = "Yes";
      this.rbNPCAliveYes.UseVisualStyleBackColor = false;
      this.rbNPCAliveYes.CheckedChanged += new System.EventHandler(this.rbNPCIsAlive_CheckedChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(3, 5);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(41, 15);
      this.label5.TabIndex = 5;
      this.label5.Text = "Name";
      // 
      // lblNPCDisplay
      // 
      this.lblNPCDisplay.AutoSize = true;
      this.lblNPCDisplay.Location = new System.Drawing.Point(3, 98);
      this.lblNPCDisplay.Name = "lblNPCDisplay";
      this.lblNPCDisplay.Size = new System.Drawing.Size(168, 15);
      this.lblNPCDisplay.TabIndex = 4;
      this.lblNPCDisplay.Text = "LOREM IPSEM DOLAR IMET";
      // 
      // tbNPCName
      // 
      this.tbNPCName.Location = new System.Drawing.Point(45, 2);
      this.tbNPCName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tbNPCName.Name = "tbNPCName";
      this.tbNPCName.Size = new System.Drawing.Size(203, 21);
      this.tbNPCName.TabIndex = 0;
      this.tbNPCName.Text = "Enter Name...";
      this.tbNPCName.TextChanged += new System.EventHandler(this.tbNPCName_TextChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.ClientSize = new System.Drawing.Size(673, 502);
      this.Controls.Add(this.pnlNPC);
      this.Controls.Add(this.pnlFighter);
      this.Controls.Add(this.pclCharacter);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.pclCharacter.ResumeLayout(false);
      this.pclCharacter.PerformLayout();
      this.gbCharacterClass.ResumeLayout(false);
      this.gbCharacterClass.PerformLayout();
      this.gbCharacterAlive.ResumeLayout(false);
      this.gbCharacterAlive.PerformLayout();
      this.pnlFighter.ResumeLayout(false);
      this.pnlFighter.PerformLayout();
      this.gbPlayerClass.ResumeLayout(false);
      this.gbPlayerClass.PerformLayout();
      this.gbPlayerAlive.ResumeLayout(false);
      this.gbPlayerAlive.PerformLayout();
      this.pnlNPC.ResumeLayout(false);
      this.pnlNPC.PerformLayout();
      this.gbNPCEmotion.ResumeLayout(false);
      this.gbNPCEmotion.PerformLayout();
      this.gbNPCIsGood.ResumeLayout(false);
      this.gbNPCIsGood.PerformLayout();
      this.gbNPCClass.ResumeLayout(false);
      this.gbNPCClass.PerformLayout();
      this.gbNPCAlive.ResumeLayout(false);
      this.gbNPCAlive.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pclCharacter;
    private System.Windows.Forms.TextBox tbCharacterName;
    private System.Windows.Forms.Label lblCharacterDisplay;
    private System.Windows.Forms.Panel pnlFighter;
    private System.Windows.Forms.Label lblPlayerDisplay;
    private System.Windows.Forms.TextBox tbPlayerName;
    private System.Windows.Forms.TextBox tbPlayerExperience;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tbPlayerLives;
    private System.Windows.Forms.Panel pnlNPC;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label lblNPCDisplay;
    private System.Windows.Forms.TextBox tbNPCName;
    private System.Windows.Forms.GroupBox gbCharacterClass;
    private System.Windows.Forms.RadioButton rbCharacterWizard;
    private System.Windows.Forms.RadioButton rbCharacterFighter;
    private System.Windows.Forms.RadioButton rbCharacterMonk;
    private System.Windows.Forms.GroupBox gbCharacterAlive;
    private System.Windows.Forms.RadioButton rbCharacterAliveNo;
    private System.Windows.Forms.RadioButton rbCharacterAliveYes;
    private System.Windows.Forms.GroupBox gbPlayerClass;
    private System.Windows.Forms.RadioButton rbPlayerWizard;
    private System.Windows.Forms.RadioButton rbPlayerFighter;
    private System.Windows.Forms.RadioButton rbPlayerMonk;
    private System.Windows.Forms.GroupBox gbPlayerAlive;
    private System.Windows.Forms.RadioButton rbPlayerAliveNo;
    private System.Windows.Forms.RadioButton rbPlayerAliveYes;
    private System.Windows.Forms.GroupBox gbNPCEmotion;
    private System.Windows.Forms.RadioButton rbNPCSad;
    private System.Windows.Forms.RadioButton rbNPCAngry;
    private System.Windows.Forms.RadioButton rbNPCHappy;
    private System.Windows.Forms.GroupBox gbNPCIsGood;
    private System.Windows.Forms.RadioButton rbNPCIsGoodNo;
    private System.Windows.Forms.RadioButton rbNPCIsGoodYes;
    private System.Windows.Forms.GroupBox gbNPCClass;
    private System.Windows.Forms.RadioButton rbNPCWizard;
    private System.Windows.Forms.RadioButton rbNPCFighter;
    private System.Windows.Forms.RadioButton rbNPCMonk;
    private System.Windows.Forms.GroupBox gbNPCAlive;
    private System.Windows.Forms.RadioButton rbNPCAliveNo;
    private System.Windows.Forms.RadioButton rbNPCAliveYes;
  }
}

