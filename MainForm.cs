using System;
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
        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ОПрограммеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AboutBox1 AboutForm = new AboutBox1();
            AboutForm.Show();
        }

        private void Функция1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //_ = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход из программы");
            Application.Exit();
        }

        private void Функция3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Функция2ToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }

        private void ПомощьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
