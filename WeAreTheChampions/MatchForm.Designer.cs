namespace WeAreTheChampions
{
    partial class MatchForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.dtpMatchTime = new System.Windows.Forms.DateTimePicker();
            this.cboHomeTeam = new System.Windows.Forms.ComboBox();
            this.cboGuestTeam = new System.Windows.Forms.ComboBox();
            this.nudScore1 = new System.Windows.Forms.NumericUpDown();
            this.nudScore2 = new System.Windows.Forms.NumericUpDown();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnAddNewMatch = new System.Windows.Forms.Button();
            this.cbAddScore = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MatchTime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "HomeTeam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Guest Team";
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.Location = new System.Drawing.Point(13, 112);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(41, 13);
            this.lblScore1.TabIndex = 0;
            this.lblScore1.Text = "Score1";
            this.lblScore1.Visible = false;
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.Location = new System.Drawing.Point(13, 137);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(41, 13);
            this.lblScore2.TabIndex = 0;
            this.lblScore2.Text = "Score2";
            this.lblScore2.Visible = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(13, 163);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Result";
            this.lblResult.Visible = false;
            // 
            // dtpMatchTime
            // 
            this.dtpMatchTime.CustomFormat = "MM/dd/yyyy HH:mm";
            this.dtpMatchTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMatchTime.Location = new System.Drawing.Point(80, 3);
            this.dtpMatchTime.MaxDate = new System.DateTime(9998, 12, 30, 23, 59, 0, 0);
            this.dtpMatchTime.MinDate = new System.DateTime(1753, 1, 1, 23, 59, 0, 0);
            this.dtpMatchTime.Name = "dtpMatchTime";
            this.dtpMatchTime.Size = new System.Drawing.Size(142, 20);
            this.dtpMatchTime.TabIndex = 2;
            // 
            // cboHomeTeam
            // 
            this.cboHomeTeam.DisplayMember = "Name";
            this.cboHomeTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHomeTeam.FormattingEnabled = true;
            this.cboHomeTeam.Location = new System.Drawing.Point(80, 30);
            this.cboHomeTeam.Name = "cboHomeTeam";
            this.cboHomeTeam.Size = new System.Drawing.Size(142, 21);
            this.cboHomeTeam.TabIndex = 3;
            this.cboHomeTeam.ValueMember = "TeamId";
            // 
            // cboGuestTeam
            // 
            this.cboGuestTeam.DisplayMember = "Name";
            this.cboGuestTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGuestTeam.FormattingEnabled = true;
            this.cboGuestTeam.Location = new System.Drawing.Point(80, 57);
            this.cboGuestTeam.Name = "cboGuestTeam";
            this.cboGuestTeam.Size = new System.Drawing.Size(142, 21);
            this.cboGuestTeam.TabIndex = 3;
            this.cboGuestTeam.ValueMember = "TeamId";
            // 
            // nudScore1
            // 
            this.nudScore1.Location = new System.Drawing.Point(80, 107);
            this.nudScore1.Name = "nudScore1";
            this.nudScore1.Size = new System.Drawing.Size(142, 20);
            this.nudScore1.TabIndex = 4;
            this.nudScore1.Visible = false;
            // 
            // nudScore2
            // 
            this.nudScore2.Location = new System.Drawing.Point(80, 133);
            this.nudScore2.Name = "nudScore2";
            this.nudScore2.Size = new System.Drawing.Size(142, 20);
            this.nudScore2.TabIndex = 4;
            this.nudScore2.Visible = false;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(80, 159);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(142, 20);
            this.txtResult.TabIndex = 5;
            this.txtResult.Visible = false;
            // 
            // btnAddNewMatch
            // 
            this.btnAddNewMatch.Location = new System.Drawing.Point(80, 186);
            this.btnAddNewMatch.Name = "btnAddNewMatch";
            this.btnAddNewMatch.Size = new System.Drawing.Size(142, 23);
            this.btnAddNewMatch.TabIndex = 6;
            this.btnAddNewMatch.Text = "Add New Match";
            this.btnAddNewMatch.UseVisualStyleBackColor = true;
            this.btnAddNewMatch.Click += new System.EventHandler(this.btnAddNewMatch_Click);
            // 
            // cbAddScore
            // 
            this.cbAddScore.AutoSize = true;
            this.cbAddScore.Location = new System.Drawing.Point(80, 84);
            this.cbAddScore.Name = "cbAddScore";
            this.cbAddScore.Size = new System.Drawing.Size(76, 17);
            this.cbAddScore.TabIndex = 7;
            this.cbAddScore.Text = "Add Score";
            this.cbAddScore.UseVisualStyleBackColor = true;
            this.cbAddScore.CheckedChanged += new System.EventHandler(this.cbAddScore_CheckedChanged);
            // 
            // MatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 220);
            this.Controls.Add(this.cbAddScore);
            this.Controls.Add(this.btnAddNewMatch);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.nudScore2);
            this.Controls.Add(this.nudScore1);
            this.Controls.Add(this.cboGuestTeam);
            this.Controls.Add(this.cboHomeTeam);
            this.Controls.Add(this.dtpMatchTime);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MatchForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudScore1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.DateTimePicker dtpMatchTime;
        private System.Windows.Forms.ComboBox cboHomeTeam;
        private System.Windows.Forms.ComboBox cboGuestTeam;
        private System.Windows.Forms.NumericUpDown nudScore1;
        private System.Windows.Forms.NumericUpDown nudScore2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnAddNewMatch;
        private System.Windows.Forms.CheckBox cbAddScore;
    }
}