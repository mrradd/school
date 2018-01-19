namespace Coffee
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.lblWelcome = new System.Windows.Forms.Label();
      this.btnAmericano = new System.Windows.Forms.Button();
      this.lblAmericano = new System.Windows.Forms.Label();
      this.lblLatte = new System.Windows.Forms.Label();
      this.btnLatte = new System.Windows.Forms.Button();
      this.lblMocha = new System.Windows.Forms.Label();
      this.btnMocha = new System.Windows.Forms.Button();
      this.lblTotal = new System.Windows.Forms.Label();
      this.lblTotalDollar = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.tbQtyAmericano = new System.Windows.Forms.TextBox();
      this.tbQtyLatte = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.tbQtyMocha = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.btnExit = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblWelcome
      // 
      this.lblWelcome.AutoSize = true;
      this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
      this.lblWelcome.ForeColor = System.Drawing.Color.White;
      this.lblWelcome.Location = new System.Drawing.Point(155, 19);
      this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblWelcome.Name = "lblWelcome";
      this.lblWelcome.Size = new System.Drawing.Size(108, 14);
      this.lblWelcome.TabIndex = 0;
      this.lblWelcome.Text = "Welcome to Here!";
      // 
      // btnAmericano
      // 
      this.btnAmericano.Location = new System.Drawing.Point(177, 84);
      this.btnAmericano.Margin = new System.Windows.Forms.Padding(2);
      this.btnAmericano.Name = "btnAmericano";
      this.btnAmericano.Size = new System.Drawing.Size(128, 24);
      this.btnAmericano.TabIndex = 1;
      this.btnAmericano.Text = "Americano";
      this.btnAmericano.UseVisualStyleBackColor = true;
      this.btnAmericano.Click += new System.EventHandler(this.btnAmericano_Click);
      // 
      // lblAmericano
      // 
      this.lblAmericano.AutoSize = true;
      this.lblAmericano.BackColor = System.Drawing.Color.Transparent;
      this.lblAmericano.ForeColor = System.Drawing.Color.White;
      this.lblAmericano.Location = new System.Drawing.Point(331, 89);
      this.lblAmericano.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblAmericano.Name = "lblAmericano";
      this.lblAmericano.Size = new System.Drawing.Size(42, 14);
      this.lblAmericano.TabIndex = 2;
      this.lblAmericano.Text = "$2.50";
      // 
      // lblLatte
      // 
      this.lblLatte.AutoSize = true;
      this.lblLatte.BackColor = System.Drawing.Color.Transparent;
      this.lblLatte.ForeColor = System.Drawing.Color.White;
      this.lblLatte.Location = new System.Drawing.Point(331, 140);
      this.lblLatte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblLatte.Name = "lblLatte";
      this.lblLatte.Size = new System.Drawing.Size(42, 14);
      this.lblLatte.TabIndex = 4;
      this.lblLatte.Text = "$3.25";
      // 
      // btnLatte
      // 
      this.btnLatte.Location = new System.Drawing.Point(177, 135);
      this.btnLatte.Margin = new System.Windows.Forms.Padding(2);
      this.btnLatte.Name = "btnLatte";
      this.btnLatte.Size = new System.Drawing.Size(128, 24);
      this.btnLatte.TabIndex = 3;
      this.btnLatte.Text = "Latte";
      this.btnLatte.UseVisualStyleBackColor = true;
      this.btnLatte.Click += new System.EventHandler(this.btnLatte_Click);
      // 
      // lblMocha
      // 
      this.lblMocha.AutoSize = true;
      this.lblMocha.BackColor = System.Drawing.Color.Transparent;
      this.lblMocha.ForeColor = System.Drawing.Color.White;
      this.lblMocha.Location = new System.Drawing.Point(331, 191);
      this.lblMocha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblMocha.Name = "lblMocha";
      this.lblMocha.Size = new System.Drawing.Size(42, 14);
      this.lblMocha.TabIndex = 6;
      this.lblMocha.Text = "$4.00";
      // 
      // btnMocha
      // 
      this.btnMocha.Location = new System.Drawing.Point(177, 184);
      this.btnMocha.Margin = new System.Windows.Forms.Padding(2);
      this.btnMocha.Name = "btnMocha";
      this.btnMocha.Size = new System.Drawing.Size(128, 24);
      this.btnMocha.TabIndex = 5;
      this.btnMocha.Text = "Mocha";
      this.btnMocha.UseVisualStyleBackColor = true;
      this.btnMocha.Click += new System.EventHandler(this.btnMocha_Click);
      // 
      // lblTotal
      // 
      this.lblTotal.AutoSize = true;
      this.lblTotal.BackColor = System.Drawing.Color.Transparent;
      this.lblTotal.ForeColor = System.Drawing.Color.White;
      this.lblTotal.Location = new System.Drawing.Point(172, 242);
      this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblTotal.Name = "lblTotal";
      this.lblTotal.Size = new System.Drawing.Size(37, 14);
      this.lblTotal.TabIndex = 7;
      this.lblTotal.Text = "Total";
      // 
      // lblTotalDollar
      // 
      this.lblTotalDollar.AutoSize = true;
      this.lblTotalDollar.BackColor = System.Drawing.Color.Transparent;
      this.lblTotalDollar.ForeColor = System.Drawing.Color.White;
      this.lblTotalDollar.Location = new System.Drawing.Point(209, 242);
      this.lblTotalDollar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblTotalDollar.Name = "lblTotalDollar";
      this.lblTotalDollar.Size = new System.Drawing.Size(35, 14);
      this.lblTotalDollar.TabIndex = 8;
      this.lblTotalDollar.Text = "0.00";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(44, 89);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(29, 14);
      this.label1.TabIndex = 9;
      this.label1.Text = "Qty";
      // 
      // tbQtyAmericano
      // 
      this.tbQtyAmericano.Location = new System.Drawing.Point(76, 85);
      this.tbQtyAmericano.Margin = new System.Windows.Forms.Padding(2);
      this.tbQtyAmericano.Name = "tbQtyAmericano";
      this.tbQtyAmericano.Size = new System.Drawing.Size(83, 20);
      this.tbQtyAmericano.TabIndex = 10;
      // 
      // tbQtyLatte
      // 
      this.tbQtyLatte.Location = new System.Drawing.Point(76, 136);
      this.tbQtyLatte.Margin = new System.Windows.Forms.Padding(2);
      this.tbQtyLatte.Name = "tbQtyLatte";
      this.tbQtyLatte.Size = new System.Drawing.Size(83, 20);
      this.tbQtyLatte.TabIndex = 12;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(44, 140);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(29, 14);
      this.label2.TabIndex = 11;
      this.label2.Text = "Qty";
      // 
      // tbQtyMocha
      // 
      this.tbQtyMocha.Location = new System.Drawing.Point(76, 187);
      this.tbQtyMocha.Margin = new System.Windows.Forms.Padding(2);
      this.tbQtyMocha.Name = "tbQtyMocha";
      this.tbQtyMocha.Size = new System.Drawing.Size(83, 20);
      this.tbQtyMocha.TabIndex = 14;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.BackColor = System.Drawing.Color.Transparent;
      this.label3.ForeColor = System.Drawing.Color.White;
      this.label3.Location = new System.Drawing.Point(44, 191);
      this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(29, 14);
      this.label3.TabIndex = 13;
      this.label3.Text = "Qty";
      // 
      // btnExit
      // 
      this.btnExit.Location = new System.Drawing.Point(358, 373);
      this.btnExit.Margin = new System.Windows.Forms.Padding(2);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(46, 24);
      this.btnExit.TabIndex = 15;
      this.btnExit.Text = "Exit";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.ClientSize = new System.Drawing.Size(415, 408);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.tbQtyMocha);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.tbQtyLatte);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.tbQtyAmericano);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lblTotalDollar);
      this.Controls.Add(this.lblTotal);
      this.Controls.Add(this.lblMocha);
      this.Controls.Add(this.btnMocha);
      this.Controls.Add(this.lblLatte);
      this.Controls.Add(this.btnLatte);
      this.Controls.Add(this.lblAmericano);
      this.Controls.Add(this.btnAmericano);
      this.Controls.Add(this.lblWelcome);
      this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "Form1";
      this.Text = "Buy Some Coffee!";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblWelcome;
    private System.Windows.Forms.Button btnAmericano;
    private System.Windows.Forms.Label lblAmericano;
    private System.Windows.Forms.Label lblLatte;
    private System.Windows.Forms.Button btnLatte;
    private System.Windows.Forms.Label lblMocha;
    private System.Windows.Forms.Button btnMocha;
    private System.Windows.Forms.Label lblTotal;
    private System.Windows.Forms.Label lblTotalDollar;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox tbQtyAmericano;
    private System.Windows.Forms.TextBox tbQtyLatte;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tbQtyMocha;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnExit;
  }
}

