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
            if (txtPlayerName.Text != "")
            {
                db.Players.Add(new Player()
                {
                    Name = txtPlayerName.Text,
                    Team = (Team)cboTeams.SelectedValue
                }
                );
                db.SaveChanges();
                txtPlayerName.Clear();
                ListPlayerFormItems();
            }
        }
    }
}
