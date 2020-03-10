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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Choosing Simple User
            if (PrevComboBox.SelectedIndex == 0)
            {
                AdminLabel.Visible = false;
                AdminPasswordTextBox.Visible = false;
            }
            //Chosing Admin (need to input AdminPassword)
            if (PrevComboBox.SelectedIndex==1)
            {
                AdminLabel.Visible = true;
                AdminLabel.ForeColor = Color.Red;
                AdminPasswordTextBox.Visible = true;
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttonsMB = MessageBoxButtons.OKCancel;
            DialogResult result;
            result =MessageBox.Show("Занесение пользователя в БД.","Регистрация пользователя",buttonsMB);
            //Demonstration
            if (result == System.Windows.Forms.DialogResult.OK)
            {   
                //Closing Parent Form
                this.Close();
                Form AuthF = Application.OpenForms[0];
                AuthF.Show();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form AuthF = Application.OpenForms[0];
            AuthF.Show();
        }
    }
}
