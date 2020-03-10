namespace WindowsFormsApp1
{
    partial class RegForm
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
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.SecondNameLable = new System.Windows.Forms.Label();
            this.ThirdNameLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.SecondNameTextBox = new System.Windows.Forms.TextBox();
            this.ThirdNameTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.SecretAnswerTextBox = new System.Windows.Forms.TextBox();
            this.PrevComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ConfirmLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ConfirmPaswwordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.AdminPasswordTextBox = new System.Windows.Forms.TextBox();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(153, 47);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(81, 20);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "Фамилия";
            // 
            // SecondNameLable
            // 
            this.SecondNameLable.AutoSize = true;
            this.SecondNameLable.Location = new System.Drawing.Point(194, 82);
            this.SecondNameLable.Name = "SecondNameLable";
            this.SecondNameLable.Size = new System.Drawing.Size(40, 20);
            this.SecondNameLable.TabIndex = 1;
            this.SecondNameLable.Text = "Имя";
            // 
            // ThirdNameLabel
            // 
            this.ThirdNameLabel.AutoSize = true;
            this.ThirdNameLabel.Location = new System.Drawing.Point(151, 119);
            this.ThirdNameLabel.Name = "ThirdNameLabel";
            this.ThirdNameLabel.Size = new System.Drawing.Size(83, 20);
            this.ThirdNameLabel.TabIndex = 2;
            this.ThirdNameLabel.Text = "Отчество";
            this.ThirdNameLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(179, 156);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(55, 20);
            this.LoginLabel.TabIndex = 3;
            this.LoginLabel.Text = "Логин";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(167, 188);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(67, 20);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Пароль";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(84, 248);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(150, 20);
            this.QuestionLabel.TabIndex = 5;
            this.QuestionLabel.Text = "Секретный вопрос";
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Location = new System.Drawing.Point(13, 284);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(221, 20);
            this.AnswerLabel.TabIndex = 6;
            this.AnswerLabel.Text = "Ответ на секретный вопрос";
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Location = new System.Drawing.Point(133, 316);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(101, 20);
            this.LevelLabel.TabIndex = 7;
            this.LevelLabel.Text = "Привилегии";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(240, 44);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(192, 26);
            this.FirstNameTextBox.TabIndex = 8;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SecondNameTextBox
            // 
            this.SecondNameTextBox.Location = new System.Drawing.Point(240, 81);
            this.SecondNameTextBox.Name = "SecondNameTextBox";
            this.SecondNameTextBox.Size = new System.Drawing.Size(192, 26);
            this.SecondNameTextBox.TabIndex = 9;
            // 
            // ThirdNameTextBox
            // 
            this.ThirdNameTextBox.Location = new System.Drawing.Point(240, 119);
            this.ThirdNameTextBox.Name = "ThirdNameTextBox";
            this.ThirdNameTextBox.Size = new System.Drawing.Size(192, 26);
            this.ThirdNameTextBox.TabIndex = 10;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(240, 156);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(192, 26);
            this.LoginTextBox.TabIndex = 11;
            // 
            // SecretAnswerTextBox
            // 
            this.SecretAnswerTextBox.Location = new System.Drawing.Point(240, 284);
            this.SecretAnswerTextBox.Name = "SecretAnswerTextBox";
            this.SecretAnswerTextBox.Size = new System.Drawing.Size(192, 26);
            this.SecretAnswerTextBox.TabIndex = 12;
            // 
            // PrevComboBox
            // 
            this.PrevComboBox.FormattingEnabled = true;
            this.PrevComboBox.Items.AddRange(new object[] {
            "0 - Пользователь",
            "1 - Администратор"});
            this.PrevComboBox.Location = new System.Drawing.Point(240, 316);
            this.PrevComboBox.Name = "PrevComboBox";
            this.PrevComboBox.Size = new System.Drawing.Size(192, 28);
            this.PrevComboBox.TabIndex = 13;
            this.PrevComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Ваш первый номер телефона?",
            "Ваш любимый преподаватель?",
            "Ваш любимый певец?"});
            this.comboBox2.Location = new System.Drawing.Point(240, 248);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(192, 28);
            this.comboBox2.TabIndex = 14;
            // 
            // ConfirmLabel
            // 
            this.ConfirmLabel.AutoSize = true;
            this.ConfirmLabel.Location = new System.Drawing.Point(57, 219);
            this.ConfirmLabel.Name = "ConfirmLabel";
            this.ConfirmLabel.Size = new System.Drawing.Size(177, 20);
            this.ConfirmLabel.TabIndex = 15;
            this.ConfirmLabel.Text = "Подтвердите Пароль";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(241, 188);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '•';
            this.PasswordTextBox.Size = new System.Drawing.Size(191, 26);
            this.PasswordTextBox.TabIndex = 16;
            // 
            // ConfirmPaswwordTextBox
            // 
            this.ConfirmPaswwordTextBox.Location = new System.Drawing.Point(241, 219);
            this.ConfirmPaswwordTextBox.Name = "ConfirmPaswwordTextBox";
            this.ConfirmPaswwordTextBox.PasswordChar = '•';
            this.ConfirmPaswwordTextBox.Size = new System.Drawing.Size(191, 26);
            this.ConfirmPaswwordTextBox.TabIndex = 17;
            // 
            // AdminPasswordTextBox
            // 
            this.AdminPasswordTextBox.Location = new System.Drawing.Point(287, 371);
            this.AdminPasswordTextBox.Name = "AdminPasswordTextBox";
            this.AdminPasswordTextBox.PasswordChar = '•';
            this.AdminPasswordTextBox.Size = new System.Drawing.Size(192, 26);
            this.AdminPasswordTextBox.TabIndex = 18;
            this.AdminPasswordTextBox.Visible = false;
            // 
            // AdminLabel
            // 
            this.AdminLabel.AutoSize = true;
            this.AdminLabel.ForeColor = System.Drawing.Color.Black;
            this.AdminLabel.Location = new System.Drawing.Point(13, 374);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(268, 20);
            this.AdminLabel.TabIndex = 19;
            this.AdminLabel.Text = "Введите пароль администратора";
            this.AdminLabel.Visible = false;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(61, 436);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(191, 42);
            this.ExitButton.TabIndex = 20;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(287, 436);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(191, 42);
            this.AcceptButton.TabIndex = 21;
            this.AcceptButton.Text = "Регистрация";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 530);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AdminLabel);
            this.Controls.Add(this.AdminPasswordTextBox);
            this.Controls.Add(this.ConfirmPaswwordTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.ConfirmLabel);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.PrevComboBox);
            this.Controls.Add(this.SecretAnswerTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.ThirdNameTextBox);
            this.Controls.Add(this.SecondNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.ThirdNameLabel);
            this.Controls.Add(this.SecondNameLable);
            this.Controls.Add(this.FirstNameLabel);
            this.Name = "RegForm";
            this.Text = "Регистрация нового пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label SecondNameLable;
        private System.Windows.Forms.Label ThirdNameLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox SecondNameTextBox;
        private System.Windows.Forms.TextBox ThirdNameTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox SecretAnswerTextBox;
        private System.Windows.Forms.ComboBox PrevComboBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label ConfirmLabel;
        private System.Windows.Forms.MaskedTextBox PasswordTextBox;
        private System.Windows.Forms.MaskedTextBox ConfirmPaswwordTextBox;
        private System.Windows.Forms.TextBox AdminPasswordTextBox;
        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AcceptButton;
    }
}