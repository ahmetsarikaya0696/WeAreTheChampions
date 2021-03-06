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
    public partial class ColorForm : Form
    {
        private readonly AppDbContext db;
        ColorDialog colorDialog;
        public ColorForm(AppDbContext db)
        {
            InitializeComponent();
            colorDialog = new ColorDialog();
            this.db = db;
            ListColors();
            SetBackgroundColor();
        }

        private void ListColors()
        {
            lstColors.DataSource = null;
            lstColors.DataSource = db.Colors.ToList();
            lstColors.SelectedIndex = -1;
        }

        private void btnAddNewColor_Click(object sender, EventArgs e)
        {
            if (txtColorName.Text == "")
            {
                MessageBox.Show("Color Name can't be empty!");
                return;
            }

            if (btnAddNewColor.Text == "Add New Color")
            {
                db.Colors.Add(new Color()
                {
                    Name = txtColorName.Text,
                    Red = (int)nudRed.Value,
                    Green = (int)nudGreen.Value,
                    Blue = (int)nudBlue.Value
                }
                    );
            }
            else if (btnAddNewColor.Text == "Update Selected Color")
            {
                var selectedColor = lstColors.SelectedItem as Color;
                selectedColor.Name = txtColorName.Text;
                selectedColor.Red = (int)nudRed.Value;
                selectedColor.Green = (int)nudGreen.Value;
                selectedColor.Blue = (int)nudBlue.Value;
                btnAddNewColor.Text = "Add New Color";
                btnCancel.Visible = false;
                ClearForm();
            }

            db.SaveChanges();
            ListColors();
        }

        private void lstColors_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstColors.SelectedIndex != -1)
            {
                var selectedColor = lstColors.SelectedItem as Color;
                txtColorName.Text = selectedColor.Name;
                nudRed.Value = selectedColor.Red;
                nudGreen.Value = selectedColor.Green;
                nudBlue.Value = selectedColor.Blue;

                btnAddNewColor.Text = "Update Selected Color";
                btnCancel.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAddNewColor.Text = "Add New Color";
            btnCancel.Visible = false;
            ClearForm();

        }

        private void ClearForm()
        {
            txtColorName.Clear();
            nudRed.Value = nudGreen.Value = nudBlue.Value = 0;
            lstColors.SelectedIndex = -1;
        }

        private void lstColors_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && lstColors.SelectedIndex != -1)
            {
                var selectedColor = lstColors.SelectedItem as Color;
                var dr = MessageBox.Show($"Color named '{selectedColor.Name}' will be removed.\r\nAre you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    db.Colors.Remove(selectedColor);
                    db.SaveChanges();
                    ListColors();
                }
            }
        }

        private void pbColor_Click(object sender, EventArgs e)
        {
            var dr = colorDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pbColor.BackColor = colorDialog.Color;
                nudRed.Value = colorDialog.Color.R;
                nudGreen.Value = colorDialog.Color.G;
                nudBlue.Value = colorDialog.Color.B;
            }
        }
        private void SetBackgroundColor()
        {
            var r = (int)nudRed.Value;
            var g = (int)nudGreen.Value;
            var b = (int)nudBlue.Value;
            var backgroundColor = System.Drawing.Color.FromArgb(r, g, b);
            pbColor.BackColor = backgroundColor;
        }

        private void nudRed_ValueChanged(object sender, EventArgs e)
        {
            SetBackgroundColor();
        }


        private void nudGreen_ValueChanged(object sender, EventArgs e)
        {
            SetBackgroundColor();
        }

        private void nudBlue_ValueChanged(object sender, EventArgs e)
        {
            SetBackgroundColor();
        }
    }
}
