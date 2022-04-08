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
    public partial class AddNewMatch : Form
    {
        private AppDbContext db;
        public AddNewMatch(AppDbContext db)
        {
            InitializeComponent();
            this.db = db;
            cboHomeTeam.DataSource = db.Teams.ToList();
            cboHomeTeam.DisplayMember = "Name";
            cboHomeTeam.ValueMember = "TeamId";

            cboGuestTeam.DataSource = db.Teams.ToList();
            cboGuestTeam.DisplayMember = "Name";
            cboGuestTeam.ValueMember = "TeamId";
        }

        private void btnAddNewMatch_Click(object sender, EventArgs e)
        {
            if (cboHomeTeam.SelectedIndex == -1 || cboGuestTeam.SelectedIndex == -1)
            {
                MessageBox.Show("Home Team and Guest Team fields are required!");
                return;
            }


            db.Matches.Add(new Match() 
            { 
                MatchTime=dtpMatchTime.Value,
                HomeTeamId=(int)cboHomeTeam.SelectedValue,
                GuestTeamId = (int)cboGuestTeam.SelectedValue,
                Score1 = (int)nudScore1.Value,
                Score2 = (int)nudScore2.Value
            }
            );
            db.SaveChanges();
        }
    }
}
