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
    public partial class ScientificCalculations : Form
    {
        public ScientificCalculations()
        {
            InitializeComponent();
        }

        private void ScientificCalculations_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = Data.FramesForPoll;
            dataGridView1.ColumnCount = 12;
            for (int i = 0; i < Data.FramesForPoll; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    //пишем значения из массива в ячейки контролла
                    dataGridView1.Rows[i].Cells[j].Value = Data.SelectedExperiment[i, j];
                }
            }
            dataGridView1.Update();
        }

        private void ScientificCalculations_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form MainF = Application.OpenForms[1];
            MainF.Show();
        }
    }
}
