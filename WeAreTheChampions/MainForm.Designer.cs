namespace WeAreTheChampions
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.btnAddNewMatch = new System.Windows.Forms.Button();
            this.btnEditSelectedMatch = new System.Windows.Forms.Button();
            this.btnDeleteSelectedMatch = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTeamToolStripMenuItem,
            this.colorsToolStripMenuItem,
            this.playersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createTeamToolStripMenuItem
            // 
            this.createTeamToolStripMenuItem.Name = "createTeamToolStripMenuItem";
            this.createTeamToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.createTeamToolStripMenuItem.Text = "Teams";
            this.createTeamToolStripMenuItem.Click += new System.EventHandler(this.createTeamToolStripMenuItem_Click);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.colorsToolStripMenuItem.Text = "Colors";
            this.colorsToolStripMenuItem.Click += new System.EventHandler(this.colorsToolStripMenuItem_Click);
            // 
            // playersToolStripMenuItem
            // 
            this.playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            this.playersToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.playersToolStripMenuItem.Text = "Players";
            this.playersToolStripMenuItem.Click += new System.EventHandler(this.playersToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matches";
            // 
            // dgvMatches
            // 
            this.dgvMatches.AllowUserToAddRows = false;
            this.dgvMatches.AllowUserToDeleteRows = false;
            this.dgvMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatches.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatches.Location = new System.Drawing.Point(15, 57);
            this.dgvMatches.MultiSelect = false;
            this.dgvMatches.Name = "dgvMatches";
            this.dgvMatches.ReadOnly = true;
            this.dgvMatches.RowHeadersVisible = false;
            this.dgvMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatches.Size = new System.Drawing.Size(670, 150);
            this.dgvMatches.TabIndex = 2;
            this.dgvMatches.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatches_CellDoubleClick);
            this.dgvMatches.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvMatches_KeyDown);
            // 
            // btnAddNewMatch
            // 
            this.btnAddNewMatch.Location = new System.Drawing.Point(15, 213);
            this.btnAddNewMatch.Name = "btnAddNewMatch";
            this.btnAddNewMatch.Size = new System.Drawing.Size(130, 23);
            this.btnAddNewMatch.TabIndex = 3;
            this.btnAddNewMatch.Text = "Add New Match";
            this.btnAddNewMatch.UseVisualStyleBackColor = true;
            this.btnAddNewMatch.Click += new System.EventHandler(this.btnAddNewMatch_Click);
            // 
            // btnEditSelectedMatch
            // 
            this.btnEditSelectedMatch.Location = new System.Drawing.Point(285, 213);
            this.btnEditSelectedMatch.Name = "btnEditSelectedMatch";
            this.btnEditSelectedMatch.Size = new System.Drawing.Size(130, 23);
            this.btnEditSelectedMatch.TabIndex = 3;
            this.btnEditSelectedMatch.Text = "Edit Selected Match";
            this.btnEditSelectedMatch.UseVisualStyleBackColor = true;
            this.btnEditSelectedMatch.Click += new System.EventHandler(this.btnEditSelectedMatch_Click);
            // 
            // btnDeleteSelectedMatch
            // 
            this.btnDeleteSelectedMatch.Location = new System.Drawing.Point(555, 213);
            this.btnDeleteSelectedMatch.Name = "btnDeleteSelectedMatch";
            this.btnDeleteSelectedMatch.Size = new System.Drawing.Size(130, 23);
            this.btnDeleteSelectedMatch.TabIndex = 3;
            this.btnDeleteSelectedMatch.Text = "Delete Selected Match";
            this.btnDeleteSelectedMatch.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedMatch.Click += new System.EventHandler(this.btnDeleteSelectedMatch_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 251);
            this.Controls.Add(this.btnDeleteSelectedMatch);
            this.Controls.Add(this.btnEditSelectedMatch);
            this.Controls.Add(this.btnAddNewMatch);
            this.Controls.Add(this.dgvMatches);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "We are the Champions 1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMatches;
        private System.Windows.Forms.Button btnAddNewMatch;
        private System.Windows.Forms.Button btnEditSelectedMatch;
        private System.Windows.Forms.Button btnDeleteSelectedMatch;
    }
}

