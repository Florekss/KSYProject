using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            string Login = "";
            string Password = "";
        }

        private void ОПрограммеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AboutBox1 AboutForm = new AboutBox1();
            AboutForm.Show();
        }

        private void Функция1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isok;
            isok = NameLabel.Visible;
            if (isok == true)
            { 
                NameLabel.Visible = false;
                StartOPROSButton.Enabled = false;
            }
            else
            {
                NameLabel.Visible = true;
                StartOPROSButton.Enabled = true;
            }
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Функция3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ScientificCalculationsF = new ScientificCalculations();
            ScientificCalculationsF.Show();
            ScientificCalculationsF.Activate();
            this.Hide();
        } 

        private void Функция2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form DataProcessingF = new DataProcessingForm();
            DataProcessingF.Show();
            DataProcessingF.Activate();
            this.Hide();

        }

        private void ПомощьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DateFillerButton_Click(object sender, EventArgs e)
        {
            DateTextBox.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DateTextBox.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            LoginTextBox.Text = Data.EntryLogin;
        }

        private void DateFillerButton_Click_1(object sender, EventArgs e)
        {
            DateTextBox.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        public void StartOPROSButton_Click(object sender, EventArgs e)
        {
            SystemChatTextBox.Text = "Начало опроса:" + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + Environment.NewLine;
            SystemChatTextBox.Text = SystemChatTextBox.Text + "Идет опрос... " + Environment.NewLine;
            int FramesForPoll = Convert.ToInt32(FramesTextBox.Text);
            double[,] one_frame = new double[FramesForPoll,13];
            one_frame=OprosMethods.Opros(FramesForPoll);
            Data.Experiment = one_frame;
            dataGridView1.RowCount = FramesForPoll;
            dataGridView1.ColumnCount = 13;
            int PO = 0;
            int KS = 0;
            for (int i = 0; i < FramesForPoll; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = one_frame[i, j];
                    //пишем значения из массива в ячейки контролла
                    if (j==5)
                    {
                        if (one_frame[i, 5] >= 5 || one_frame[i, 5] <= 1)
                        {
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.LightPink;
                            PO += 1;
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Empty;
                        }
                    }
                    if (j==8)
                    {
                        if (one_frame[i, 8] >= 999999)
                        {
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.LightPink;
                            KS += 1;
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Empty;
                        }
                    }

                    
                }
            }
            SystemChatTextBox.Text = SystemChatTextBox.Text + "Конец опроса:" + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + Environment.NewLine;
            SystemChatTextBox.Text = SystemChatTextBox.Text + "Каналы с нарушением ПО: " + Convert.ToString(PO) + Environment.NewLine;
            SystemChatTextBox.Text = SystemChatTextBox.Text + "Каналы с нарушением КС: " + Convert.ToString(KS);
            dataGridView1.Update();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int expID = SQLMethonds.InsertIntoExperimentBD(Data.Experiment);
            SQLMethonds.InsertIntoUnBD(expID, CommentTextBox.Text);
            MessageBox.Show("Все записи успешно сохранены");
        }
    }
}
