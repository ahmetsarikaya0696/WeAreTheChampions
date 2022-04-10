using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeAreTheChampions
{
    public partial class MatchForm : Form
    {
        private AppDbContext db;
        private readonly Match selectedMatch;

        public MatchForm(AppDbContext db, Match selectedMatch = null)
        {
            InitializeComponent();
            this.db = db;
            this.selectedMatch = selectedMatch;
            ListMatchFormItems();
            if (this.selectedMatch != null)
            {
                cbAddScore.Checked = selectedMatch.Score1 != null && selectedMatch.Score2 != null ? true : false;
                dtpMatchTime.Value = this.selectedMatch.MatchTime;
                cboHomeTeam.SelectedItem = this.selectedMatch.HomeTeam;
                cboGuestTeam.SelectedItem = this.selectedMatch.GuestTeam;
                btnAddNewMatch.Text = "Edit Selected Match";
                if (this.selectedMatch.Score1 != null || this.selectedMatch.Score2 != null)
                {
                    nudScore1.Value = (decimal)this.selectedMatch.Score1;
                    nudScore2.Value = (decimal)this.selectedMatch.Score2;
                    txtResult.Text = this.selectedMatch.Result.ToString();
                }
                else
                {
                    nudScore1.Visible = nudScore2.Visible = txtResult.Visible = false;
                }
            }
        }

        private void ListMatchFormItems()
        {
            cboHomeTeam.DataSource = cboGuestTeam.DataSource = null;
            cboHomeTeam.DataSource = db.Teams.ToList();
            cboGuestTeam.DataSource = db.Teams.ToList();
        }

        private void btnAddNewMatch_Click(object sender, EventArgs e)
        {
            if (cboHomeTeam.SelectedIndex == -1 || cboGuestTeam.SelectedIndex == -1)
            {
                MessageBox.Show("Home Team and Guest Team fields are required!");
                return;
            }


            if (btnAddNewMatch.Text == "Add New Match")
            {
                var newMatch = cbAddScore.Checked ?
                    new Match()
                    {
                        MatchTime = dtpMatchTime.Value,
                        HomeTeamId = (int)cboHomeTeam.SelectedValue,
                        GuestTeamId = (int)cboGuestTeam.SelectedValue,
                        Score1 = (int)nudScore1.Value,
                        Score2 = (int)nudScore2.Value
                    } :
                    new Match()
                    {
                        MatchTime = dtpMatchTime.Value,
                        HomeTeamId = (int)cboHomeTeam.SelectedValue,
                        GuestTeamId = (int)cboGuestTeam.SelectedValue,
                        Score1 = null,
                        Score2 = null
                    };
                db.Matches.Add(newMatch);
            }
            else if (btnAddNewMatch.Text == "Edit Selected Match")
            {
                selectedMatch.MatchTime = dtpMatchTime.Value;
                selectedMatch.HomeTeamId = (int)cboHomeTeam.SelectedValue;
                selectedMatch.GuestTeamId = (int)cboGuestTeam.SelectedValue;
                if (cbAddScore.Checked)
                {
                    selectedMatch.Score1 = (int)nudScore1.Value;
                    selectedMatch.Score2 = (int)nudScore2.Value; 
                }
                else
                {
                    selectedMatch.Score1 = selectedMatch.Score2 = null;
                }
            }
            db.SaveChanges();
        }

        private void cbAddScore_CheckedChanged(object sender, EventArgs e)
        {
            lblScore1.Visible = lblScore2.Visible = lblResult.Visible = nudScore1.Visible = nudScore2.Visible = txtResult.Visible = cbAddScore.Checked;
        }
    }
}
