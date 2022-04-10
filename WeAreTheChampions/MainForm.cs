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
            ListMatches();
        }

        private void ListMatches()
        {
            dgvMatches.DataSource = null;
            dgvMatches.DataSource = db.Matches.ToList();
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
            ColorForm colorsForm = new ColorForm(db);
            colorsForm.ShowDialog();
        }

        private void btnAddNewMatch_Click(object sender, EventArgs e)
        {
            MatchForm matchForm = new MatchForm(db);
            matchForm.ShowDialog();
        }

        private void btnEditSelectedMatch_Click(object sender, EventArgs e)
        {
            if (dgvMatches.SelectedRows.Count == 0) return;

            var selectedMatch = (Match)dgvMatches.SelectedRows[0].DataBoundItem;
            MatchForm matchForm = new MatchForm(db, selectedMatch);
            matchForm.ShowDialog();
        }

        private void btnDeleteSelectedMatch_Click(object sender, EventArgs e)
        {
            DeleteSelectedMatch();

        }

        private void DeleteSelectedMatch()
        {
            if (dgvMatches.SelectedRows.Count == 0) return;

            var selectedMatch = (Match)dgvMatches.SelectedRows[0].DataBoundItem;

            DialogResult dr = MessageBox.Show("Are you sure?", "Delete Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Matches.Remove(selectedMatch);
                db.SaveChanges();
                ListMatches();
            }
        }

        private void dgvMatches_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) DeleteSelectedMatch();
        }
    }
}
