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
    public partial class PlayersForm : Form
    {
        private readonly AppDbContext db;

        public PlayersForm(AppDbContext db)
        {
            InitializeComponent();
            this.db = db;
            ListPlayerFormItems();
        }

        private void ListPlayerFormItems()
        {
            lstPlayers.DataSource = cboTeams.DataSource = null;
            cboTeams.DataSource = db.Teams.ToList();
            lstPlayers.DataSource = db.Players.ToList();
        }

        private void btnAddNewPlayer_Click(object sender, EventArgs e)
        {
            if (txtPlayerName.Text == "")
            {
                MessageBox.Show("Player Name can't be empty!");
                return;
            }

            if (btnAddNewPlayer.Text == "Add New Player")
            {
                db.Players.Add(new Player()
                {
                    Name = txtPlayerName.Text,
                    Team = (Team)cboTeams.SelectedItem
                }
                   );
            }
            else if (btnAddNewPlayer.Text == "Update Selected Player")
            {
                var selectedPlayer = lstPlayers.SelectedItem as Player;
                selectedPlayer.Name = txtPlayerName.Text;
                selectedPlayer.Team = (Team)cboTeams.SelectedItem;
            }
            db.SaveChanges();
            ClearPlayerForm();
            ListPlayerFormItems();

        }

        private void lstPlayers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstPlayers.SelectedIndex != -1)
            {
                var selectedPlayer = lstPlayers.SelectedItem as Player;
                txtPlayerName.Text = selectedPlayer.Name;
                cboTeams.SelectedValue = selectedPlayer.TeamId;
                btnAddNewPlayer.Text = "Update Selected Player";
                btnCancel.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearPlayerForm();
        }

        private void ClearPlayerForm()
        {
            btnCancel.Visible = false;
            btnAddNewPlayer.Text = "Add New Player";
            txtPlayerName.Clear();
            cboTeams.SelectedIndex = 0;
        }

        private void lstPlayers_KeyDown(object sender, KeyEventArgs e)
        {
            if (lstPlayers.SelectedIndex != -1 && e.KeyCode == Keys.Delete)
            {
                var selectedPlayer = lstPlayers.SelectedItem as Player;
                var dr = MessageBox.Show($"'{selectedPlayer.Name}' will be removed.\r\nAre you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    db.Players.Remove(selectedPlayer);
                    db.SaveChanges();
                }
                ListPlayerFormItems();
                ClearPlayerForm();
            }
        }
    }
}
