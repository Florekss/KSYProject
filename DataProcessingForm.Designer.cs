namespace WindowsFormsApp1
{
    partial class DataProcessingForm
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StartOPROSButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.userDBDataSet = new KSY.UserDBDataSet();
            this.userDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Комментарий:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(976, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Фильтр данных";
            // 
            // StartOPROSButton
            // 
            this.StartOPROSButton.Location = new System.Drawing.Point(94, 215);
            this.StartOPROSButton.Name = "StartOPROSButton";
            this.StartOPROSButton.Size = new System.Drawing.Size(112, 33);
            this.StartOPROSButton.TabIndex = 20;
            this.StartOPROSButton.Text = "Отобразить";
            this.StartOPROSButton.UseVisualStyleBackColor = true;
            this.StartOPROSButton.Click += new System.EventHandler(this.StartOPROSButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Выбор эксперимента";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Выбор оператора";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(207, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(229, 29);
            this.NameLabel.TabIndex = 17;
            this.NameLabel.Text = "Обработка данных";
            this.NameLabel.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1104, 515);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 38);
            this.button3.TabIndex = 31;
            this.button3.Text = "Отправить в НТР";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1104, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 43);
            this.button1.TabIndex = 32;
            this.button1.Text = "Отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 33);
            this.button2.TabIndex = 33;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(212, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 28);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(212, 104);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(166, 28);
            this.comboBox2.TabIndex = 35;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(555, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Сортировка данных";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            ">",
            ">=",
            "<=",
            "<",
            "="});
            this.comboBox3.Location = new System.Drawing.Point(1031, 101);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(44, 28);
            this.comboBox3.TabIndex = 37;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6_СР",
            "6_Д",
            "9",
            "19",
            "49",
            "69",
            "77"});
            this.comboBox4.Location = new System.Drawing.Point(929, 101);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(77, 28);
            this.comboBox4.TabIndex = 38;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6_СР",
            "6_Д",
            "9",
            "19",
            "49",
            "69",
            "77"});
            this.comboBox5.Location = new System.Drawing.Point(508, 101);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 28);
            this.comboBox5.TabIndex = 39;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.comboBox6.Location = new System.Drawing.Point(664, 99);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 28);
            this.comboBox6.TabIndex = 40;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1060, 144);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 34);
            this.button4.TabIndex = 41;
            this.button4.Text = "Применить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(947, 144);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 34);
            this.button5.TabIndex = 42;
            this.button5.Text = "Отмена";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(612, 144);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 34);
            this.button6.TabIndex = 43;
            this.button6.Text = "Очистить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1107, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 26);
            this.textBox1.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1103, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Значение";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1012, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "Критерий";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(931, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Канал №";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(529, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 48;
            this.label9.Text = "Канал №";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(660, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 20);
            this.label10.TabIndex = 49;
            this.label10.Text = "Сортировка по";
            // 
            // userDBDataSet
            // 
            this.userDBDataSet.DataSetName = "UserDBDataSet";
            this.userDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userDBDataSetBindingSource
            // 
            this.userDBDataSetBindingSource.DataSource = this.userDBDataSet;
            this.userDBDataSetBindingSource.Position = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(212, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 20);
            this.label11.TabIndex = 50;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1087, 348);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // FrameNumber
            // 
            this.FrameNumber.HeaderText = "№ Кадра";
            this.FrameNumber.MinimumWidth = 8;
            this.FrameNumber.Name = "FrameNumber";
            this.FrameNumber.ReadOnly = true;
            this.FrameNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FrameNumber.Width = 60;
            // 
            // Channel1
            // 
            this.Channel1.HeaderText = "Кан. 1";
            this.Channel1.MinimumWidth = 8;
            this.Channel1.Name = "Channel1";
            this.Channel1.ReadOnly = true;
            this.Channel1.Width = 80;
            // 
            // Channel2
            // 
            this.Channel2.HeaderText = "Кан. 2";
            this.Channel2.MinimumWidth = 8;
            this.Channel2.Name = "Channel2";
            this.Channel2.ReadOnly = true;
            this.Channel2.Width = 80;
            // 
            // Channel3
            // 
            this.Channel3.HeaderText = "Кан. 3";
            this.Channel3.MinimumWidth = 8;
            this.Channel3.Name = "Channel3";
            this.Channel3.ReadOnly = true;
            this.Channel3.Width = 80;
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
            this.Channel6_mean.Width = 80;
            // 
            // Channel6_disp
            // 
            this.Channel6_disp.HeaderText = "Кан. 6_Д";
            this.Channel6_disp.MinimumWidth = 8;
            this.Channel6_disp.Name = "Channel6_disp";
            this.Channel6_disp.ReadOnly = true;
            this.Channel6_disp.Width = 80;
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
            this.Channel19.Width = 80;
            // 
            // Channel49
            // 
            this.Channel49.HeaderText = "Кан. 49";
            this.Channel49.MinimumWidth = 8;
            this.Channel49.Name = "Channel49";
            this.Channel49.ReadOnly = true;
            this.Channel49.Width = 80;
            // 
            // Channel69
            // 
            this.Channel69.HeaderText = "Кан. 69";
            this.Channel69.MinimumWidth = 8;
            this.Channel69.Name = "Channel69";
            this.Channel69.ReadOnly = true;
            this.Channel69.Width = 80;
            // 
            // Channel77
            // 
            this.Channel77.HeaderText = "Кан. 77";
            this.Channel77.MinimumWidth = 8;
            this.Channel77.Name = "Channel77";
            this.Channel77.ReadOnly = true;
            this.Channel77.Width = 45;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView2.Location = new System.Drawing.Point(12, 641);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView2.RowHeadersWidth = 30;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1087, 124);
            this.dataGridView2.TabIndex = 52;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Кан. 1";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Кан. 2";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Кан. 3";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Кан. 4";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 45;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Кан. 5";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 45;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Кан. 6 СР";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Кан. 6_Д";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Кан. 9";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 45;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Кан. 19";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 80;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Кан. 49";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 80;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Кан. 69";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 80;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Кан. 77";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 618);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 20);
            this.label12.TabIndex = 53;
            this.label12.Text = "Среднее:";
            // 
            // DataProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 836);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StartOPROSButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameLabel);
            this.Name = "DataProcessingForm";
            this.Text = "Обработка данных";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataProcessingForm_FormClosing);
            this.Load += new System.EventHandler(this.DataProcessingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StartOPROSButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource userDBDataSetBindingSource;
        private KSY.UserDBDataSet userDBDataSet;
        private System.Windows.Forms.Label label11;
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.Label label12;
    }
}