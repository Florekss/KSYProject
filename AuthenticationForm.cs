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
    public partial class AuthenticationForm : Form
    {
        public AuthenticationForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "" || LoginBox.Text == "")
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль", "Неправильнйы ввод", MessageBoxButtons.OK);
            }
            else
            {
                Data.EntryLogin = LoginBox.Text;
                Data.EntryPassword = PasswordBox.Text;
                bool tt = SQLMethonds.Authentication(Data.EntryLogin);
                if (tt==true)
                {
                    Form MainF = new MainForm();
                    MainF.Show();
                    MainF.Activate();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Доступ запрещен");
                }
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            Form RegF = new RegForm();
            RegF.Show();
            RegF.Activate();
            Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
