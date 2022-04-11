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
    public partial class TeamForm : Form
    {
        private readonly AppDbContext db;

        public TeamForm(AppDbContext db)
        {
            InitializeComponent();
            this.db = db;
            ListTeamFormItems();
        }

        private void ListTeamFormItems()
        {
            clbTeamColors.DataSource = lstTeams.DataSource = null;
            clbTeamColors.DataSource = db.Colors.ToList();
            lstTeams.DataSource = db.Teams.ToList();
        }

        private void btnAddNewTeam_Click(object sender, EventArgs e)
        {
            if (btnAddNewTeam.Text == "Add New Team")
            {
                Team team = new Team()
                {
                    Name = txtTeamName.Text,
                    Colors = clbTeamColors.CheckedItems.OfType<Color>().ToList()
                };
                db.Teams.Add(team);
            }
            else if (btnAddNewTeam.Text == "Update Selected Team")
            {
                var selectedTeam = lstTeams.SelectedItem as Team;
                selectedTeam.Name = txtTeamName.Text;
                selectedTeam.Colors = clbTeamColors.CheckedItems.OfType<Color>().ToList();
            }
            ClearTeamForm();
            db.SaveChanges();
            ListTeamFormItems();
        }

        private void lstTeams_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstTeams.SelectedIndex != -1)
            {
                var selectedTeam = lstTeams.SelectedItem as Team;
                txtTeamName.Text = selectedTeam.Name;
                btnAddNewTeam.Text = "Update Selected Team";
                btnCancel.Visible = true;

                //önceden checked  olan bakicilarla birlikte getir
                for (int i = 0; i < clbTeamColors.Items.Count; i++)
                {
                    foreach (var teamColor in selectedTeam.Colors)
                    {
                        if (teamColor.ColorId == ((Color)clbTeamColors.Items[i]).ColorId)
                        {
                            clbTeamColors.SetItemChecked(i, true);
                        }
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearTeamForm();
        }

        private void ClearTeamForm()
        {
            txtTeamName.Clear();
            foreach (int i in clbTeamColors.CheckedIndices)
            {
                clbTeamColors.SetItemCheckState(i, CheckState.Unchecked);
            }
            btnCancel.Visible = false;
            btnAddNewTeam.Text = "Add New Team";
        }

        private void lstTeams_KeyDown(object sender, KeyEventArgs e)
        {
            if (lstTeams.SelectedIndex != -1 && e.KeyCode == Keys.Delete)
            {
                var selectedTeam = lstTeams.SelectedItem as Team;
                var dr = MessageBox.Show($"Team named '{selectedTeam.Name}' will be removed.\r\nAre you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    db.Teams.Remove(selectedTeam);
                    db.SaveChanges(); 
                    ClearTeamForm();
                    ListTeamFormItems();
                }
            }
        }

        private void lstTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTeams.SelectedIndex != -1)
            {
                var selectedTeam = lstTeams.SelectedItem as Team;
                lstPlayers.DataSource = db.Players.Where(p => p.TeamId == selectedTeam.TeamId).ToList();
            }
        }
    }
}
