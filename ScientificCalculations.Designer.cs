namespace WindowsFormsApp1
{
    partial class ScientificCalculations
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FrameNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Channel1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Channel2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Channel3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Channel4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Channel5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Channel6_mean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Channel6_disp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Channel9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Channel19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Channel49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Channel69 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Channel77 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FrameNumber,
            this.Channel1,
            this.Channel2,
            this.Channel3,
            this.Channel4,
            this.Channel5,
            this.Channel6_mean,
            this.Channel6_disp,
            this.Channel9,
            this.Channel19,
            this.Channel49,
            this.Channel69,
            this.Channel77});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1588, 558);
            this.dataGridView1.TabIndex = 52;
            // 
            // FrameNumber
            // 
            this.FrameNumber.HeaderText = "№ Кадра";
            this.FrameNumber.MinimumWidth = 8;
            this.FrameNumber.Name = "FrameNumber";
            this.FrameNumber.ReadOnly = true;
            this.FrameNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FrameNumber.Width = 80;
            // 
            // Channel1
            // 
            this.Channel1.HeaderText = "Кан. 1";
            this.Channel1.MinimumWidth = 8;
            this.Channel1.Name = "Channel1";
            this.Channel1.ReadOnly = true;
            this.Channel1.Width = 150;
            // 
            // Channel2
            // 
            this.Channel2.HeaderText = "Кан. 2";
            this.Channel2.MinimumWidth = 8;
            this.Channel2.Name = "Channel2";
            this.Channel2.ReadOnly = true;
            this.Channel2.Width = 150;
            // 
            // Channel3
            // 
            this.Channel3.HeaderText = "Кан. 3";
            this.Channel3.MinimumWidth = 8;
            this.Channel3.Name = "Channel3";
            this.Channel3.ReadOnly = true;
            this.Channel3.Width = 150;
            // 
            // Channel4
            // 
            this.Channel4.HeaderText = "Кан. 4";
            this.Channel4.MinimumWidth = 8;
            this.Channel4.Name = "Channel4";
            this.Channel4.ReadOnly = true;
            this.Channel4.Width = 45;
            // 
            // Channel5
            // 
            this.Channel5.HeaderText = "Кан. 5";
            this.Channel5.MinimumWidth = 8;
            this.Channel5.Name = "Channel5";
            this.Channel5.ReadOnly = true;
            this.Channel5.Width = 45;
            // 
            // Channel6_mean
            // 
            this.Channel6_mean.HeaderText = "Кан. 6 СР";
            this.Channel6_mean.MinimumWidth = 8;
            this.Channel6_mean.Name = "Channel6_mean";
            this.Channel6_mean.ReadOnly = true;
            this.Channel6_mean.Width = 150;
            // 
            // Channel6_disp
            // 
            this.Channel6_disp.HeaderText = "Кан. 6_Д";
            this.Channel6_disp.MinimumWidth = 8;
            this.Channel6_disp.Name = "Channel6_disp";
            this.Channel6_disp.ReadOnly = true;
            this.Channel6_disp.Width = 150;
            // 
            // Channel9
            // 
            this.Channel9.HeaderText = "Кан. 9";
            this.Channel9.MinimumWidth = 8;
            this.Channel9.Name = "Channel9";
            this.Channel9.ReadOnly = true;
            this.Channel9.Width = 45;
            // 
            // Channel19
            // 
            this.Channel19.HeaderText = "Кан. 19";
            this.Channel19.MinimumWidth = 8;
            this.Channel19.Name = "Channel19";
            this.Channel19.ReadOnly = true;
            this.Channel19.Width = 150;
            // 
            // Channel49
            // 
            this.Channel49.HeaderText = "Кан. 49";
            this.Channel49.MinimumWidth = 8;
            this.Channel49.Name = "Channel49";
            this.Channel49.ReadOnly = true;
            this.Channel49.Width = 150;
            // 
            // Channel69
            // 
            this.Channel69.HeaderText = "Кан. 69";
            this.Channel69.MinimumWidth = 8;
            this.Channel69.Name = "Channel69";
            this.Channel69.ReadOnly = true;
            this.Channel69.Width = 150;
            // 
            // Channel77
            // 
            this.Channel77.HeaderText = "Кан. 77";
            this.Channel77.MinimumWidth = 8;
            this.Channel77.Name = "Channel77";
            this.Channel77.ReadOnly = true;
            this.Channel77.Width = 45;
            // 
            // ScientificCalculations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1612, 582);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ScientificCalculations";
            this.Text = "Научно-технические расчеты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScientificCalculations_FormClosing);
            this.Load += new System.EventHandler(this.ScientificCalculations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrameNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Channel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Channel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Channel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Channel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Channel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Channel6_mean;
        private System.Windows.Forms.DataGridViewTextBoxColumn Channel6_disp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Channel9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Channel19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Channel49;
        private System.Windows.Forms.DataGridViewTextBoxColumn Channel69;
        private System.Windows.Forms.DataGridViewTextBoxColumn Channel77;
    }
}