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
            DateTextBox.Text = Convert.ToString(DateTime.Now);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
             DateTextBox.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void DateFillerButton_Click_1(object sender, EventArgs e)
        {
            DateTextBox.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        private void StartOPROSButton_Click(object sender, EventArgs e)
        {
            int FramesForPoll = Convert.ToInt32(FramesTextBox.Text);
            double[,] one_frame = new double[FramesForPoll,13];
            one_frame=OprosMethods.Opros(FramesForPoll);
            dataGridView1.RowCount = FramesForPoll;
            dataGridView1.ColumnCount = 13;
            for (int i = 0; i < FramesForPoll; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    //пишем значения из массива в ячейки контролла
                    dataGridView1.Rows[i].Cells[j].Value = one_frame[i, j];
                }
            }
            dataGridView1.Update();
            //acumulation = Convert.ToString(Opros(1));
            MessageBox.Show("Опрос Закончен.", "Это правда рабоатет?!", MessageBoxButtons.OK);
        }
    }
}
