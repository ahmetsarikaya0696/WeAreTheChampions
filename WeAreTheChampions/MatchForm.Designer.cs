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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpMatchTime = new System.Windows.Forms.DateTimePicker();
            this.cboHomeTeam = new System.Windows.Forms.ComboBox();
            this.cboGuestTeam = new System.Windows.Forms.ComboBox();
            this.nudScore1 = new System.Windows.Forms.NumericUpDown();
            this.nudScore2 = new System.Windows.Forms.NumericUpDown();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnAddNewMatch = new System.Windows.Forms.Button();
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
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Guest Team";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Score1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Score2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Result";
            // 
            // dtpMatchTime
            // 
            this.dtpMatchTime.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dtpMatchTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMatchTime.Location = new System.Drawing.Point(80, 3);
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
            this.cboGuestTeam.Location = new System.Drawing.Point(80, 85);
            this.cboGuestTeam.Name = "cboGuestTeam";
            this.cboGuestTeam.Size = new System.Drawing.Size(142, 21);
            this.cboGuestTeam.TabIndex = 3;
            this.cboGuestTeam.ValueMember = "TeamId";
            // 
            // nudScore1
            // 
            this.nudScore1.Location = new System.Drawing.Point(80, 58);
            this.nudScore1.Name = "nudScore1";
            this.nudScore1.Size = new System.Drawing.Size(142, 20);
            this.nudScore1.TabIndex = 4;
            // 
            // nudScore2
            // 
            this.nudScore2.Location = new System.Drawing.Point(80, 113);
            this.nudScore2.Name = "nudScore2";
            this.nudScore2.Size = new System.Drawing.Size(142, 20);
            this.nudScore2.TabIndex = 4;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(80, 140);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(142, 20);
            this.txtResult.TabIndex = 5;
            // 
            // btnAddNewMatch
            // 
            this.btnAddNewMatch.Location = new System.Drawing.Point(80, 167);
            this.btnAddNewMatch.Name = "btnAddNewMatch";
            this.btnAddNewMatch.Size = new System.Drawing.Size(142, 23);
            this.btnAddNewMatch.TabIndex = 6;
            this.btnAddNewMatch.Text = "Add New Match";
            this.btnAddNewMatch.UseVisualStyleBackColor = true;
            this.btnAddNewMatch.Click += new System.EventHandler(this.btnAddNewMatch_Click);
            // 
            // MatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 198);
            this.Controls.Add(this.btnAddNewMatch);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.nudScore2);
            this.Controls.Add(this.nudScore1);
            this.Controls.Add(this.cboGuestTeam);
            this.Controls.Add(this.cboHomeTeam);
            this.Controls.Add(this.dtpMatchTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpMatchTime;
        private System.Windows.Forms.ComboBox cboHomeTeam;
        private System.Windows.Forms.ComboBox cboGuestTeam;
        private System.Windows.Forms.NumericUpDown nudScore1;
        private System.Windows.Forms.NumericUpDown nudScore2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnAddNewMatch;
    }
}