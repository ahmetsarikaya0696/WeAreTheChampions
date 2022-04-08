namespace WeAreTheChampions
{
    partial class PlayersForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.cboTeams = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddNewPlayer = new System.Windows.Forms.Button();
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Name";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(86, 12);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(121, 20);
            this.txtPlayerName.TabIndex = 1;
            // 
            // cboTeams
            // 
            this.cboTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeams.FormattingEnabled = true;
            this.cboTeams.Location = new System.Drawing.Point(86, 89);
            this.cboTeams.Name = "cboTeams";
            this.cboTeams.Size = new System.Drawing.Size(121, 21);
            this.cboTeams.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Team Name";
            // 
            // btnAddNewPlayer
            // 
            this.btnAddNewPlayer.Location = new System.Drawing.Point(17, 156);
            this.btnAddNewPlayer.Name = "btnAddNewPlayer";
            this.btnAddNewPlayer.Size = new System.Drawing.Size(89, 36);
            this.btnAddNewPlayer.TabIndex = 3;
            this.btnAddNewPlayer.Text = "Add New Player";
            this.btnAddNewPlayer.UseVisualStyleBackColor = true;
            this.btnAddNewPlayer.Click += new System.EventHandler(this.btnAddNewPlayer_Click);
            // 
            // lstPlayers
            // 
            this.lstPlayers.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.Location = new System.Drawing.Point(219, 0);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(156, 204);
            this.lstPlayers.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(118, 156);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 36);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            // 
            // PlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 204);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lstPlayers);
            this.Controls.Add(this.btnAddNewPlayer);
            this.Controls.Add(this.cboTeams);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PlayersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PlayersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.ComboBox cboTeams;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNewPlayer;
        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.Button btnCancel;
    }
}