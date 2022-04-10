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
                dtpMatchTime.Value = this.selectedMatch.MatchTime;
                cboHomeTeam.SelectedItem = this.selectedMatch.HomeTeam;
                cboGuestTeam.SelectedItem = this.selectedMatch.GuestTeam;
                nudScore1.Value = (decimal)this.selectedMatch.Score1;
                nudScore2.Value = (decimal)this.selectedMatch.Score2;
                txtResult.Text = this.selectedMatch.Result.ToString();
                btnAddNewMatch.Text = "Edit Selected Match";
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
                db.Matches.Add(new Match()
                {
                    MatchTime = dtpMatchTime.Value,
                    HomeTeamId = (int)cboHomeTeam.SelectedValue,
                    GuestTeamId = (int)cboGuestTeam.SelectedValue,
                    Score1 = (int)nudScore1.Value,
                    Score2 = (int)nudScore2.Value
                }
                   );
            }
            else if (btnAddNewMatch.Text == "Edit Selected Match")
            {
                selectedMatch.MatchTime = dtpMatchTime.Value;
                selectedMatch.HomeTeamId = (int)cboHomeTeam.SelectedValue;
                selectedMatch.GuestTeamId = (int)cboGuestTeam.SelectedValue;
                selectedMatch.Score1 = (int)nudScore1.Value;
                selectedMatch.Score2 = (int)nudScore2.Value;
            }
            db.SaveChanges();
        }
    }
}
