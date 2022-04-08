namespace WeAreTheChampions
{
    partial class ColorsForm
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
            this.txtColorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudRed = new System.Windows.Forms.NumericUpDown();
            this.nudGreen = new System.Windows.Forms.NumericUpDown();
            this.nudBlue = new System.Windows.Forms.NumericUpDown();
            this.btnAddNewColor = new System.Windows.Forms.Button();
            this.lstColors = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color Name";
            // 
            // txtColorName
            // 
            this.txtColorName.Location = new System.Drawing.Point(85, 12);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Size = new System.Drawing.Size(120, 20);
            this.txtColorName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Red";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Green";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Blue";
            // 
            // nudRed
            // 
            this.nudRed.Location = new System.Drawing.Point(85, 49);
            this.nudRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRed.Name = "nudRed";
            this.nudRed.Size = new System.Drawing.Size(120, 20);
            this.nudRed.TabIndex = 3;
            // 
            // nudGreen
            // 
            this.nudGreen.Location = new System.Drawing.Point(85, 86);
            this.nudGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGreen.Name = "nudGreen";
            this.nudGreen.Size = new System.Drawing.Size(120, 20);
            this.nudGreen.TabIndex = 3;
            // 
            // nudBlue
            // 
            this.nudBlue.Location = new System.Drawing.Point(85, 123);
            this.nudBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBlue.Name = "nudBlue";
            this.nudBlue.Size = new System.Drawing.Size(120, 20);
            this.nudBlue.TabIndex = 3;
            // 
            // btnAddNewColor
            // 
            this.btnAddNewColor.Location = new System.Drawing.Point(20, 166);
            this.btnAddNewColor.Name = "btnAddNewColor";
            this.btnAddNewColor.Size = new System.Drawing.Size(79, 34);
            this.btnAddNewColor.TabIndex = 4;
            this.btnAddNewColor.Text = "Add New Color";
            this.btnAddNewColor.UseVisualStyleBackColor = true;
            this.btnAddNewColor.Click += new System.EventHandler(this.btnAddNewColor_Click);
            // 
            // lstColors
            // 
            this.lstColors.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstColors.FormattingEnabled = true;
            this.lstColors.Location = new System.Drawing.Point(217, 0);
            this.lstColors.Name = "lstColors";
            this.lstColors.Size = new System.Drawing.Size(147, 212);
            this.lstColors.TabIndex = 5;
            this.lstColors.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstColors_KeyDown);
            this.lstColors.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstColors_MouseDoubleClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(126, 166);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 34);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ColorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 212);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lstColors);
            this.Controls.Add(this.btnAddNewColor);
            this.Controls.Add(this.nudBlue);
            this.Controls.Add(this.nudGreen);
            this.Controls.Add(this.nudRed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtColorName);
            this.Controls.Add(this.label1);
            this.Name = "ColorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ColorsForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtColorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudRed;
        private System.Windows.Forms.NumericUpDown nudGreen;
        private System.Windows.Forms.NumericUpDown nudBlue;
        private System.Windows.Forms.Button btnAddNewColor;
        private System.Windows.Forms.ListBox lstColors;
        private System.Windows.Forms.Button btnCancel;
    }
}