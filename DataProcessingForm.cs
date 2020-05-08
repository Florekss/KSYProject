using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
        private static string ReadSingle(IDataRecord record)
        {
            return String.Format("{0}", record[0]).Trim();

        }
        private void DataProcessingForm_Load(object sender, EventArgs e)
        {
            SqlConnection connection = SQLMethonds.StartConnection();

            string SQLExpression = "SELECT COUNT(DISTINCT(userID)) FROM dbo.UnBD";
            SqlCommand command = new SqlCommand(SQLExpression, connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int users_amount = Convert.ToInt32(ReadSingle((IDataRecord)reader));
            reader.Close();
            int[] idarray = new int[users_amount];
            SQLExpression = "SELECT DISTINCT(userID) FROM dbo.UnBD";
            command = new SqlCommand(SQLExpression, connection);
            reader = command.ExecuteReader();
            int k = 0;
            while (reader.Read())
            {
                idarray[k] = Convert.ToInt32(ReadSingle((IDataReader)reader));
                k += 1;
            }
            reader.Close();
            k = 0;
            string[] showme = new string[users_amount];
            for (int i = 0; i < users_amount; i++)
            {
                string SQLExpress = "SELECT Login FROM dbo.userBD WHERE Id=" + Convert.ToString(idarray[i]);
                SqlCommand com = new SqlCommand(SQLExpress, connection);
                SqlDataReader re = com.ExecuteReader();
                while (re.Read())
                {
                    showme[i] = ReadSingle((IDataReader)re);
                }
                re.Close();
            }
            comboBox1.DataSource = showme;

            comboBox1.SelectedIndex = 0;
            comboBox2.Items.Clear();

            string selecteduser = Convert.ToString(comboBox1.SelectedItem);
            SQLExpression = "SELECT Id FROM dbo.userBD WHERE Login='" + selecteduser + "'";
            command = new SqlCommand(SQLExpression, connection);
            reader = command.ExecuteReader();
            reader.Read();
            int selectedId = Convert.ToInt32(ReadRow((IDataRecord)reader));
            reader.Close();

            SQLExpression = "SELECT experimentID,experimentDate FROM dbo.UnBD WHERE userID=" + Convert.ToString(selectedId);
            command = new SqlCommand(SQLExpression, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string item = ReadCombobox2((IDataReader)reader);
                comboBox2.Items.Add(item);
            }
            reader.Close();

            connection.Close();
        }

        private static string ReadRow(IDataRecord record)
        {
            return String.Format("{0}", record[0]);

        }
        private static string ReadCombobox2(IDataRecord record)
        {
            return String.Format("№{0} {1}", record[0], record[1]);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = SQLMethonds.StartConnection();
            comboBox2.Items.Clear();

            string selecteduser = Convert.ToString(comboBox1.SelectedItem);
            string SQLExpression = "SELECT Id FROM dbo.userBD WHERE Login='" + selecteduser + "'";
            SqlCommand command = new SqlCommand(SQLExpression, connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int selectedId = Convert.ToInt32(ReadRow((IDataRecord)reader));
            reader.Close();

            SQLExpression = "SELECT experimentID,experimentDate FROM dbo.UnBD WHERE userID=" + Convert.ToString(selectedId);
            command = new SqlCommand(SQLExpression, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string item = ReadCombobox2((IDataReader)reader);
                comboBox2.Items.Add(item);
            }
            reader.Close();

            connection.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = SQLMethonds.StartConnection();
            string h = Convert.ToString(comboBox2.SelectedItem);
            int index = h.IndexOf(" ");
            string show = "";
            for (int i = 1; i < index; i++)
            {
                show += h[i];
            }
            string SQLExpression = "SELECT comment FROM dbo.UnBD WHERE experimentID=" + show;
            SqlCommand command = new SqlCommand(SQLExpression, connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string comment = Convert.ToString(ReadRow((IDataRecord)reader));
            label11.Text = comment;

            connection.Close();
        }

        private double[] ReadOneRow(IDataReader reader)
        {
            double[] response = new double[13];

            for (int i = 0; i<response.Length; i++)
            {
                response[i] = Convert.ToDouble(reader[i]);
            }
            return response;
        }

        private double[] ReadAVG(IDataReader reader)
        {
            double[] response = new double[12];
            for (int i = 0; i < response.Length; i++)
            {
                response[i] = Convert.ToDouble(reader[i]);
            }
            return response;
        }
        private void StartOPROSButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = SQLMethonds.StartConnection();
            string h = Convert.ToString(comboBox2.SelectedItem);
            int index = h.IndexOf(" ");
            string show = "";
            for (int i = 1; i < index; i++)
            {
                show += h[i];
            }

            string SQLExpression = "SELECT COUNt(ch77) FROM dbo.ExperimentBD WHERE expID=" + show;
            SqlCommand command = new SqlCommand(SQLExpression, connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int rows_amount = Convert.ToInt32(ReadSingle((IDataRecord)reader));
            Data.FramesForPoll = rows_amount;
            reader.Close();

            SQLExpression = "SELECT frameNum,ch1,ch2_normed,ch3,ch4,ch5,ch6_mean,ch6_disp,ch9,ch19,ch49,ch69,ch77 FROM dbo.ExperimentBD WHERE expID=" + show;
            command = new SqlCommand(SQLExpression, connection);
            reader = command.ExecuteReader();
            double[,] dataset = new double[rows_amount,13];
            Data.SelectedExperiment = new double[rows_amount, 13];
            int k = 0;
            while(reader.Read())
            {
                double[] response = new double[12];
                response = ReadOneRow((IDataReader)reader);
                for(int i=0;i<12;i++)
                {
                    dataset[k, i] = response[i];
                    Data.SelectedExperiment[k, i] = response[i];
                }
                k += 1;
            }
            reader.Close();
            dataGridView1.RowCount = rows_amount;
            dataGridView1.ColumnCount = 13;
            for (int i = 0; i < rows_amount; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    //пишем значения из массива в ячейки контролла
                    dataGridView1.Rows[i].Cells[j].Value = dataset[i, j];
                }
            }
            dataGridView1.Update();
            Data.SelectedExperiment = dataset;

            SQLExpression = "SELECT AVG(ch1),AVG(ch2_normed),AVG(ch3),AVG(ch4),AVG(ch5),AVG(ch6_mean),AVG(ch6_disp),AVG(ch9),AVG(ch19),AVG(ch49),AVG(ch69),AVG(ch77) FROM dbo.ExperimentBD WHERE expID=" + show;
            command = new SqlCommand(SQLExpression, connection);
            reader = command.ExecuteReader();
            double[,] avg = new double[2, 12];
            while (reader.Read())
            {
                double[] res = new double[12];
                res = ReadAVG((IDataReader)reader);
                for (int i = 0; i < 12; i++)
                {
                    avg[1, i] = res[i];
                }
            }
            reader.Close();
            dataGridView2.RowCount = 1;
            dataGridView2.ColumnCount = 12;
                for (int j = 0; j < 12; j++)
                {
                    //пишем значения из массива в ячейки контролла
                    dataGridView2.Rows[0].Cells[j].Value = avg[1, j];
                }
            connection.Close();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = SQLMethonds.StartConnection();
            string h = Convert.ToString(comboBox2.SelectedItem);
            int index = h.IndexOf(" ");
            string show = "";
            for (int i = 1; i < index; i++)
            {
                show += h[i];
            }

            string SQLExpression = "SELECT COUNt(ch77) FROM dbo.ExperimentBD WHERE expID=" + show;
            SqlCommand command = new SqlCommand(SQLExpression, connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int rows_amount = Convert.ToInt32(ReadSingle((IDataRecord)reader));
            reader.Close();

            string ordstr = "";
            switch (comboBox5.SelectedIndex)
            {
                case 0:
                    ordstr = "ch1";
                    break;
                case 1:
                    ordstr = "ch2_normed";
                    break;
                case 2:
                    ordstr = "ch3";
                    break;
                case 3:
                    ordstr = "ch4";
                    break;
                case 4:
                    ordstr = "ch5";
                    break;
                case 5:
                    ordstr = "ch6_mean";
                    break;
                case 6:
                    ordstr = "ch6_disp";
                    break;
                case 7:
                    ordstr = "ch9";
                    break;
                case 8:
                    ordstr = "ch19";
                    break;
                case 9:
                    ordstr = "ch49";
                    break;
                case 10:
                    ordstr = "ch69";
                    break;
                case 11:
                    ordstr = "ch77";
                    break;

            }
            string side = "";
            switch (comboBox6.SelectedIndex)
            {
                case 0:
                    side = "ASC";
                    break;
                case 1:
                    side = "DESC";
                    break;
            }

            SQLExpression = "SELECT frameNum,ch1,ch2_normed,ch3,ch4,ch5,ch6_mean,ch6_disp,ch9,ch19,ch49,ch69,ch77 FROM dbo.ExperimentBD WHERE expID=" + show +" ORDER BY " +ordstr +" "+side;
            command = new SqlCommand(SQLExpression, connection);
            reader = command.ExecuteReader();
            double[,] dataset = new double[rows_amount, 12];
            int k = 0;
            while (reader.Read())
            {
                double[] response = new double[12];
                response = ReadOneRow((IDataReader)reader);
                for (int i = 0; i < 12; i++)
                {
                    dataset[k, i] = response[i];
                }
                k += 1;
            }
            reader.Close();
            dataGridView1.RowCount = rows_amount;
            dataGridView1.ColumnCount = 12;
            for (int i = 0; i < rows_amount; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    //пишем значения из массива в ячейки контролла
                    dataGridView1.Rows[i].Cells[j].Value = dataset[i, j];
                }
            }
            dataGridView1.Update();
            MessageBox.Show("OK");



            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection connection = SQLMethonds.StartConnection();
            string h = Convert.ToString(comboBox2.SelectedItem);
            int index = h.IndexOf(" ");
            string show = "";
            for (int i = 1; i < index; i++)
            {
                show += h[i];
            }

            string SQLExpression = "SELECT COUNt(ch77) FROM dbo.ExperimentBD WHERE expID=" + show;
            SqlCommand command = new SqlCommand(SQLExpression, connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int rows_amount = Convert.ToInt32(ReadSingle((IDataRecord)reader));
            reader.Close();

            string ordstr = "";
            switch (comboBox4.SelectedIndex)
            {
                case 0:
                    ordstr = "ch1";
                    break;
                case 1:
                    ordstr = "ch2_normed";
                    break;
                case 2:
                    ordstr = "ch3";
                    break;
                case 3:
                    ordstr = "ch4";
                    break;
                case 4:
                    ordstr = "ch5";
                    break;
                case 5:
                    ordstr = "ch6_mean";
                    break;
                case 6:
                    ordstr = "ch6_disp";
                    break;
                case 7:
                    ordstr = "ch9";
                    break;
                case 8:
                    ordstr = "ch19";
                    break;
                case 9:
                    ordstr = "ch49";
                    break;
                case 10:
                    ordstr = "ch69";
                    break;
                case 11:
                    ordstr = "ch77";
                    break;

            }


            SQLExpression = "SELECT frameNum,ch1,ch2_normed,ch3,ch4,ch5,ch6_mean,ch6_disp,ch9,ch19,ch49,ch69,ch77 FROM dbo.ExperimentBD WHERE expID=" + show+" AND "+ordstr+comboBox3.SelectedItem+textBox1.Text;
            command = new SqlCommand(SQLExpression, connection);
            reader = command.ExecuteReader();
            double[,] dataset = new double[rows_amount, 12];
            int k = 0;
            while (reader.Read())
            {
                double[] response = new double[12];
                response = ReadOneRow((IDataReader)reader);
                for (int i = 0; i < 12; i++)
                {
                    dataset[k, i] = response[i];
                }
                k += 1;
            }
            reader.Close();
            dataGridView1.RowCount = rows_amount;
            dataGridView1.ColumnCount = 12;
            for (int i = 0; i < rows_amount; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    //пишем значения из массива в ячейки контролла
                    dataGridView1.Rows[i].Cells[j].Value = dataset[i, j];
                }
            }
            dataGridView1.Update();
            MessageBox.Show("OK");



            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExcellMethonds.SaveToFile(Data.SelectedExperiment);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ScientificC = new ScientificCalculations();
            ScientificC.Show();
            ScientificC.Activate();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы действительно хотите удалить эту запись?", "Удаление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}
