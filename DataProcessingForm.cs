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
    public partial class DataProcessingForm : Form
    {
        public DataProcessingForm()
        {
            InitializeComponent();
        }

        private void DataProcessingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form MainF = Application.OpenForms[1];
            MainF.Show();
        }

        private void DataProcessingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
