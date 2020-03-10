namespace WindowsFormsApp1
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
            this.DataRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.функция2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.функция3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartOPROSButton = new System.Windows.Forms.Button();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.FramesTextBox = new System.Windows.Forms.TextBox();
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DateFillerButton = new System.Windows.Forms.Button();
            this.SystemChatTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataRegistration,
            this.функция2ToolStripMenuItem,
            this.функция3ToolStripMenuItem,
            this.помощьToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1054, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // DataRegistration
            // 
            this.DataRegistration.Name = "DataRegistration";
            this.DataRegistration.Size = new System.Drawing.Size(194, 32);
            this.DataRegistration.Text = "Регистрация данных";
            this.DataRegistration.Click += new System.EventHandler(this.Функция1ToolStripMenuItem_Click);
            // 
            // функция2ToolStripMenuItem
            // 
            this.функция2ToolStripMenuItem.Name = "функция2ToolStripMenuItem";
            this.функция2ToolStripMenuItem.Size = new System.Drawing.Size(183, 32);
            this.функция2ToolStripMenuItem.Text = "Обработка данных";
            this.функция2ToolStripMenuItem.Click += new System.EventHandler(this.Функция2ToolStripMenuItem_Click);
            // 
            // функция3ToolStripMenuItem
            // 
            this.функция3ToolStripMenuItem.Name = "функция3ToolStripMenuItem";
            this.функция3ToolStripMenuItem.Size = new System.Drawing.Size(268, 32);
            this.функция3ToolStripMenuItem.Text = "Научно-технические расчеты";
            this.функция3ToolStripMenuItem.Click += new System.EventHandler(this.Функция3ToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(100, 32);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.ПомощьToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(141, 32);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.ОПрограммеToolStripMenuItem_Click_1);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(80, 32);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItem_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(385, 48);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(260, 29);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Название процедуры";
            this.NameLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вы вошли под логином:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Число кадров:";
            // 
            // StartOPROSButton
            // 
            this.StartOPROSButton.Location = new System.Drawing.Point(27, 165);
            this.StartOPROSButton.Name = "StartOPROSButton";
            this.StartOPROSButton.Size = new System.Drawing.Size(191, 32);
            this.StartOPROSButton.TabIndex = 5;
            this.StartOPROSButton.Text = "Начать опрос";
            this.StartOPROSButton.UseVisualStyleBackColor = true;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(210, 101);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.ReadOnly = true;
            this.LoginTextBox.Size = new System.Drawing.Size(132, 26);
            this.LoginTextBox.TabIndex = 6;
            // 
            // FramesTextBox
            // 
            this.FramesTextBox.Location = new System.Drawing.Point(209, 133);
            this.FramesTextBox.Name = "FramesTextBox";
            this.FramesTextBox.Size = new System.Drawing.Size(133, 26);
            this.FramesTextBox.TabIndex = 7;
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.Location = new System.Drawing.Point(471, 98);
            this.CommentTextBox.Multiline = true;
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(187, 53);
            this.CommentTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Комментарий:";
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(471, 165);
            this.DateTextBox.Mask = "00/00/0000 90:00";
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(187, 26);
            this.DateTextBox.TabIndex = 10;
            this.DateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Дата и время опроса:";
            // 
            // DateFillerButton
            // 
            this.DateFillerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateFillerButton.Location = new System.Drawing.Point(664, 163);
            this.DateFillerButton.Name = "DateFillerButton";
            this.DateFillerButton.Size = new System.Drawing.Size(79, 30);
            this.DateFillerButton.TabIndex = 12;
            this.DateFillerButton.Text = "Заполнить";
            this.DateFillerButton.UseVisualStyleBackColor = true;
            this.DateFillerButton.Click += new System.EventHandler(this.DateFillerButton_Click_1);
            // 
            // SystemChatTextBox
            // 
            this.SystemChatTextBox.Location = new System.Drawing.Point(772, 98);
            this.SystemChatTextBox.Multiline = true;
            this.SystemChatTextBox.Name = "SystemChatTextBox";
            this.SystemChatTextBox.Size = new System.Drawing.Size(258, 99);
            this.SystemChatTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(809, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Сообщения системы:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(833, 379);
            this.dataGridView1.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(856, 553);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 32);
            this.button3.TabIndex = 16;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 597);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SystemChatTextBox);
            this.Controls.Add(this.DateFillerButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CommentTextBox);
            this.Controls.Add(this.FramesTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.StartOPROSButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Программный комплекс \"Проект KSY\"";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DataRegistration;
        private System.Windows.Forms.ToolStripMenuItem функция2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem функция3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartOPROSButton;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox FramesTextBox;
        private System.Windows.Forms.TextBox CommentTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox DateTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DateFillerButton;
        private System.Windows.Forms.TextBox SystemChatTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
    }
}