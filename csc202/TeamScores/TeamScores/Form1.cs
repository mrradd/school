using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamScores
  {
  public partial class Form1 : Form
    {
    public Team team;

    private BindingSource bindingSource1 = new BindingSource();

    public Form1()
      {
      InitializeComponent();

      team = new Team();
      for(int i = 0; i < 11; i++)
        {
        Player p = new Player("#" + i, i * 2);
        team.playerList.Add(p);
        }

      /** Bind the player list to the data grid. */
      bindingSource1 = new BindingSource(team.playerList, null);
      dgTeam.DataSource = bindingSource1;

      /** Show the mean score. */
      tbMeanScore.Text = team.meanScore().ToString();
      }

    /**************************************************************************
    * dgTeam_CellLeave */
    /**
    * Clears the error text.
    **************************************************************************/
    private void dgTeam_CellLeave(object sender, DataGridViewCellEventArgs e)
      {
      dgTeam.Rows[e.RowIndex].ErrorText = String.Empty;
      }     

    /**************************************************************************
    * dgTeam_CellValidating */
    /**
    * Validates the player score input.
    **************************************************************************/
    private void dgTeam_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
      {
      string headerText = dgTeam.Columns[e.ColumnIndex].HeaderText;
      
      /** Display an error if there is bad input. */
      int s = 0;
      if(headerText.Equals("score") && !int.TryParse(e.FormattedValue.ToString(), out s))
        {
        dgTeam.Rows[e.RowIndex].ErrorText = "Invalid input for score.";
        e.Cancel = true;
        } 
      }

    /**************************************************************************
    * dgTeam_CellValidated */
    /**
    * Updates the mean score after validation.
    **************************************************************************/
    private void dgTeam_CellValidated(object sender, DataGridViewCellEventArgs e)
      {
      tbMeanScore.Text = team.meanScore().ToString();
      }
  }
  }
