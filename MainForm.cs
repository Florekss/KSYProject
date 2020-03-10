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

        }

        private void DateFillerButton_Click_1(object sender, EventArgs e)
        {
            /// filler don't work when time near 0:00-9:00 AM\PM 
            /// #FIXME ASAP
            DateTime localtime = DateTime.Now;
            var culture = new CultureInfo("ru-RU");
            DateTextBox.Text = localtime.ToString(culture);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
