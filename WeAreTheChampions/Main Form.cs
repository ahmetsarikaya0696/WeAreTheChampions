using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions;

namespace WeAreTheChampions
{
    public partial class MainForm : Form
    {
        AppDbContext db = new AppDbContext();
        public MainForm()
        {
            InitializeComponent();
            dgvMatches.DataSource = db.Matches.ToList();
        }

        private void btnAddNewMatch_Click(object sender, EventArgs e)
        {
            AddNewMatch addNewMatch = new AddNewMatch(db);
            addNewMatch.ShowDialog();
        }

        private void createTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeamForm teamForm = new TeamForm(db);
            teamForm.ShowDialog();
        }

        private void playersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayersForm playersForm = new PlayersForm(db);
            playersForm.ShowDialog();
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorsForm colorsForm = new ColorsForm(db);
            colorsForm.ShowDialog();
        }
    }
}
