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
        public bool AdminNeeded = false;

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
                AdminPasswordTextBox.Visible = true;
    }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (AdminPasswordTextBox.Text == "1nv1n0Ver1ta$")
            {
                AdminNeeded = true;
            }
            else
            {
                if (PrevComboBox.SelectedIndex==0)
                {
                    AdminNeeded = true;
                }
                else
                {
                    AdminNeeded = false;
                }
                AdminNeeded = false;
            };
            if (AdminNeeded == true)
            {
                //Занесение в таблицу UserBD
                string Login = "N'" + LoginTextBox.Text + "'";
                string Password = "N'" + PasswordTextBox.Text + "'";
                string FIO = "N'" + FirstNameTextBox.Text + " " + SecondNameTextBox.Text + " " + ThirdNameTextBox.Text + "'";
                int Prev = Convert.ToInt32(PrevComboBox.SelectedIndex);
                string Question = "N'" + Convert.ToString(comboBox2.SelectedItem) + "'";
                string Req = "N'" + SecretAnswerTextBox.Text + "'";
                SQLMethonds.InsertIntoUserBD(Login, Password, FIO, Prev, Question, Req);
                DialogResult result;
                result = MessageBox.Show(String.Format("Пользователь {0} успешно добавлен.", LoginTextBox.Text), "Регистрация пользователя", MessageBoxButtons.OKCancel);
                //Demonstration
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    //Closing Parent Form
                    this.Close();
                    Form AuthF = Application.OpenForms[0];
                    AuthF.Show();
                }
            }
            else
            {
                DialogResult AdminNeedResult;
                AdminNeedResult = MessageBox.Show("Необходимо ввести пароль администратора", "Доступ заблокирован!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (AdminNeedResult == DialogResult.OK)
                {
                    PrevComboBox.SelectedIndex = 0;
                    AdminLabel.Visible = false;
                    AdminPasswordTextBox.Text = "";
                    AdminPasswordTextBox.Visible = false;
                }
            };
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form AuthF = Application.OpenForms[0];
            AuthF.Show();
        }

        private void ConfirmPaswwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == ConfirmPaswwordTextBox.Text)
            {
                ConfirmPaswwordTextBox.BackColor = Color.Aquamarine;
                PasswordTextBox.BackColor = Color.Aquamarine;
            }
            else
            {
                ConfirmPaswwordTextBox.BackColor = Color.LightPink;
            }
            if (ConfirmPaswwordTextBox.Text=="")
            {
                ConfirmPaswwordTextBox.BackColor = Color.White;
            }
        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            
        }

        private void RegForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form AuthF = Application.OpenForms[0];
            AuthF.Show();
        }
    }
}
