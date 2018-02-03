namespace TeamScores
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
      this.dgTeam = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.tbMeanScore = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dgTeam)).BeginInit();
      this.SuspendLayout();
      // 
      // dgTeam
      // 
      this.dgTeam.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
      this.dgTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgTeam.Location = new System.Drawing.Point(14, 13);
      this.dgTeam.Name = "dgTeam";
      this.dgTeam.Size = new System.Drawing.Size(245, 302);
      this.dgTeam.TabIndex = 0;
      this.dgTeam.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTeam_CellLeave);
      this.dgTeam.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTeam_CellValidated);
      this.dgTeam.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgTeam_CellValidating);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(36, 348);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(77, 14);
      this.label1.TabIndex = 2;
      this.label1.Text = "Mean Score";
      // 
      // tbMeanScore
      // 
      this.tbMeanScore.Location = new System.Drawing.Point(116, 345);
      this.tbMeanScore.Name = "tbMeanScore";
      this.tbMeanScore.ReadOnly = true;
      this.tbMeanScore.Size = new System.Drawing.Size(116, 20);
      this.tbMeanScore.TabIndex = 3;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.ClientSize = new System.Drawing.Size(273, 403);
      this.Controls.Add(this.tbMeanScore);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dgTeam);
      this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.dgTeam)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dgTeam;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox tbMeanScore;
  }
}

