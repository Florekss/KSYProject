using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    public class Data
    {
        public static string EntryLogin = "";
        public static string EntryPassword = "";
        public static int EntryId = 0;
        public static int FramesForPoll = 0;
        public static double[,] Experiment;
        public static double[,] SelectedExperiment;
    }
    public class OprosMethods
    {
        [DllImport("Practice.dll")]
        static extern void Start_Plant();
        [DllImport("Practice.dll")]
        static extern double ChanellPoll(int channel_number);

        public static double[,] Opros(int chislo_kadrov)
        {
            Start_Plant();
            //Каналы для опроса, согласно ТКИ.
            int[] channels_for_poll= { 9, 2, 49, 77, 5, 6, 77, 6, 6, 6, 9, 6, 1, 3, 6, 4, 77, 19, 9, 69, 6, 77 };
            //Возвращаемый массив.
            double[,] frame=new double[chislo_kadrov,29];
            double[,] response = new double[chislo_kadrov, 13];
            for (int i = 0; i < chislo_kadrov; i++)
            {
                //Обновление response.
                //response[i, 0]  Номер кадра.
                //response[i, 1]  Канал 1. Простой опрос.
                //response[i, 2]  Канал 2. Нормированное значение.
                //response[i, 3]  Канал 3. Простой опрос.
                //response[i, 4]  Канал 4. Простой опрос.
                //response[i, 5]  Канал 5. Позиционные ограничения. 1<X<3
                //response[i, 6]  Канал 6. Среднее
                //response[i, 7]  Канал 6. Дисперсия
                //response[i, 8]  Канал 9. Контроль стабильности.
                //response[i, 9]  Канал 19. Простой опрос.
                //response[i, 10] Канал 49. Простой опрос.
                //response[i, 11] Канал 69. Расчет функции.
                //response[i, 12] Канал 77. Контроль стабильности

                response[i, 0] = i + 1;
                //1.Опрос канала 9.
                frame[i,0] = ChanellPoll(channels_for_poll[0]);
                //2.Опрос канала 2.
                //ChanellPoll(channels_for_poll[1]);
                //3.Нормировка канала 2.
                response[i, 2] = (ChanellPoll(channels_for_poll[1]) - 730) / 70;
                //4.Опрос канала 49.
                response[i, 10] = ChanellPoll(channels_for_poll[2]);
                //5.Опрос канала 77.
                frame[i, 4] = ChanellPoll(channels_for_poll[3]);
                //6.Опрос канала 5.
                frame[i, 5] = ChanellPoll(channels_for_poll[4]);
                //7.Контроль Поз.Ограничений. 1<=X<=5. Канал 5.
                response[i, 5] = frame[i, 5];
                //8.Опрос канала 6.
                frame[i, 7] = ChanellPoll(channels_for_poll[5]);
                //9.Опрос канала 77.
                frame[i, 8] = ChanellPoll(channels_for_poll[6]);
                //10.Опрос канала 6.
                frame[i, 9] = ChanellPoll(channels_for_poll[7]);
                //11.Опрос канала 6.
                frame[i, 10] = ChanellPoll(channels_for_poll[8]);
                //12.Опрос канала 6.
                frame[i, 11] = ChanellPoll(channels_for_poll[9]);
                //13.Опрос канала 9.
                frame[i, 12] = ChanellPoll(channels_for_poll[10]);
                //14.Опрос канала 6.
                frame[i, 13] = ChanellPoll(channels_for_poll[11]);
                //15.Опрос канала 1.
                response[i, 1] = ChanellPoll(channels_for_poll[12]);
                //16.Опрос канала 3.
                response[i, 3] = ChanellPoll(channels_for_poll[13]);
                //17.Опрос канала 6.
                frame[i, 16] = ChanellPoll(channels_for_poll[14]);
                //18.Опрос канала 4.
                response[i, 4] = ChanellPoll(channels_for_poll[15]);
                //19.Опрос канала 77.
                frame[i, 18] = ChanellPoll(channels_for_poll[16]);
                //20.Опрос канала 19.
                response[i, 9] = ChanellPoll(channels_for_poll[17]);
                //21.Опрос канала 9.
                frame[i, 20] = ChanellPoll(channels_for_poll[18]);
                //22.Опрос канала 69.
                frame[i, 21] = ChanellPoll(channels_for_poll[19]);
                //23.Расчет функции 0.3*Х*(0.1*Х-154). Канал 69.
                response[i, 11] = 0.3 * frame[i, 21] * (0.1 * frame[i, 21] - 154);
                //24.Контроль стабильноси канала 9.
                if (frame[i,0]==frame[i,12] && frame[i, 12] == frame[i, 20])
                    {
                        response[i, 8] = frame[i, 0];
                    }
                else
                    {
                        response[i, 8] = 999999;
                    }
                //25.Опрос канала 6.
                frame[i, 24] = ChanellPoll(channels_for_poll[20]);
                //26.Опрос канала 77.
                frame[i, 25] = ChanellPoll(channels_for_poll[21]);
                //27.Расчет среднего значения и оценки дисперсии по повторным измерениям в кадре. Канал 6.
                frame[i, 26] = (frame[i, 7] + frame[i, 9] + frame[i, 10] + frame[i, 11] + frame[i, 13] + frame[i, 16] + frame[i, 24]) / 7;
                response[i, 6] = frame[i, 26];
                //28.
                frame[i, 27] = ((frame[i, 7] - frame[i, 26]) * (frame[i, 7] - frame[i, 26]) +
                     (frame[i, 9] - frame[i, 26]) * (frame[i, 9] - frame[i, 26]) +
                    (frame[i, 10] - frame[i, 26]) * (frame[i, 10] - frame[i, 26]) +
                    (frame[i, 11] - frame[i, 26]) * (frame[i, 11] - frame[i, 26]) +
                    (frame[i, 13] - frame[i, 26]) * (frame[i, 13] - frame[i, 26]) +
                    (frame[i, 16] - frame[i, 26]) * (frame[i, 16] - frame[i, 26]) +
                    (frame[i, 24] - frame[i, 26]) * (frame[i, 24] - frame[i, 26])) / 7;
                response[i, 7] = frame[i, 27];
                //29. Контроль стабильности кадра 77.
                //Номера опросов канала 77: 
                //5,9,19,26
                //frame[i,4],frame[i,8],frame[i,18],frame[i,25]
                //Алгоритм проверки стабильности
                if(frame[i,4]==frame[i,8] && frame[i,18]==frame[i,25] && frame[i,8]==frame[i,18] )
                    {
                    response[i, 12] = frame[i, 18];
                    }
                else 
                {
                    response[i, 12] = 999999;
                }
            }
            return response;
        }
        


    }
    public class ExcellMethonds
    {
        public static void SaveToFile(double[,] dataset)
        {
            Microsoft.Office.Interop.Excel.Application ObjExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook WB;
            Microsoft.Office.Interop.Excel.Worksheet sheet;

            //Книга.
            WB = ObjExcel.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            sheet = (Microsoft.Office.Interop.Excel.Worksheet)WB.Sheets[1];

            sheet.Cells.NumberFormat = "@";


            sheet.Cells[1, 1]  = "№ Кадра";
            sheet.Cells[1, 2]  = "Канал 1";
            sheet.Cells[1, 3]  = "Канал 2";
            sheet.Cells[1, 4]  = "Канал 3";
            sheet.Cells[1, 5]  = "Канал 4";
            sheet.Cells[1, 6]  = "Канал 5";
            sheet.Cells[1, 7]  = "Канал 6 Среднее";
            sheet.Cells[1, 8]  = "Канал 6 Дисперсия";
            sheet.Cells[1, 9]  = "Канал 9";
            sheet.Cells[1, 10] = "Канал 19";
            sheet.Cells[1, 11] = "Канал 49";
            sheet.Cells[1, 12] = "Канал 77";

            for (int i = 0; i < Data.FramesForPoll; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    //пишем значения из массива в ячейки контролла
                    sheet.Cells[i+2,j+1] = Convert.ToString(Data.SelectedExperiment[i,j]);
                }
            }

            sheet.Columns.AutoFit();
            sheet.Cells.VerticalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            sheet.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


            DialogResult res = MessageBox.Show("При нажатии \"Да\" будет открыт сгенерированный файл, при нажатии \"Нет\" будет предложено сохранить файл.", "Экспорт в Excel", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                ObjExcel.Visible = true;
                ObjExcel.UserControl = true;
            }
            if (res == DialogResult.No)
            {
                string fileName = String.Empty;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.FileName = DateTime.Now.ToString("dd_MM_yyyy HH_mm")+ ".xlsx";
                saveFileDialog1.Filter = "xls files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFileDialog1.FileName;
                }
                //сохраняем Workbook
                WB.SaveAs(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                saveFileDialog1.Dispose();
                WB.Close(0);
                ObjExcel.Quit();
            }
            if (res == DialogResult.Cancel)
            {
                int k = 0;
            }
            
        }   
    }
    public class SQLMethonds
    {

        public static SqlConnection StartConnection()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\darkn\\Source\\Repos\\Florekss\\KSYProject\\PlantDB.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }
        public static int CloseConnection(SqlConnection connection)
        {
            connection.Close();
            return 0;
        }

        public static void InsertIntoUserBD(string Login, string Password, string FIO, int Prev, string Question, string Req)
        {
            //Начало соединения с БД
            SqlConnection connection = StartConnection();

            //Узнаем сколько в таблице пользователей уже содержится записей.
            string SQLExpression = "SELECT COUNT(Id) FROM dbo.userBD";
            SqlCommand myCommand = new SqlCommand(SQLExpression, connection);
            int stringscount = Convert.ToInt32(myCommand.ExecuteScalar());

            int Id = stringscount + 1;
            string Reg = "GETDATE()";


            //Создание строки вставки
            string SQLInsertString = String.Format("INSERT INTO dbo.userBD (Id,Login,Password,FIO,Prev,Question,Req,Reg) VALUES ({0},{1},{2},{3},{4},{5},{6},{7})", Id, Login, Password, FIO, Prev, Question, Req, Reg);
            SqlCommand insert = new SqlCommand(SQLInsertString, connection);
            int countrows = insert.ExecuteNonQuery();

            //Разрыв соединения.
            int response = CloseConnection(connection);
        }

        public static int InsertIntoExperimentBD(double[,] PollArray)
        {
            int ExperimentId=0;
            //Начало соединения с БД
            SqlConnection connection = StartConnection();

            //Узнаем сколько в уже содержится записей.
            string SQLExpression = "SELECT COUNT (DISTINCT expId) FROM dbo.ExperimentBD";
            SqlCommand myCommand = new SqlCommand(SQLExpression, connection);
            ExperimentId = Convert.ToInt32(myCommand.ExecuteScalar());

            for (int i = 0; i < PollArray.GetUpperBound(0) + 1; i++)
            {
                string SQLINSERT =String.Format("INSERT INTO dbo.ExperimentBD (expId,frameNum,ch1,ch2_normed,ch3,ch4,ch5,ch6_mean,ch6_disp,ch9,ch19,ch49,ch69,ch77) VALUES ({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13})", ExperimentId, Convert.ToString(PollArray[i, 0]).Replace(",","."), Convert.ToString(PollArray[i, 1]).Replace(",", "."), Convert.ToString(PollArray[i, 2]).Replace(",", "."), Convert.ToString(PollArray[i, 3]).Replace(",", "."), Convert.ToString(PollArray[i, 4]).Replace(",", "."), Convert.ToString(PollArray[i, 5]).Replace(",", "."), Convert.ToString(PollArray[i, 6]).Replace(",", "."), Convert.ToString(PollArray[i, 7]).Replace(",", "."), Convert.ToString(PollArray[i, 8]).Replace(",", "."), Convert.ToString(PollArray[i, 9]).Replace(",", "."), Convert.ToString(PollArray[i, 10]).Replace(",", "."), Convert.ToString(PollArray[i, 11]).Replace(",", "."), Convert.ToString(PollArray[i, 12]).Replace(",", "."));
                SqlCommand insertcommand = new SqlCommand(SQLINSERT,connection);
                insertcommand.ExecuteNonQuery();
            }

            //Разрыв соединения.
            int response = CloseConnection(connection);
            return ExperimentId;
        }

        private static string ReadSingleRow(IDataRecord record)
        {
            Data.EntryId = Convert.ToInt32(record[1]);
            return String.Format("{0}",record[0]);

        }
        public static bool Authentication(string Login)
        {

            bool Entry = false;
            string Password = "";
            //Начало соединения с БД
            SqlConnection connection = StartConnection();

            //получаем пару логин-пароль из БД
            string SQLExpression = "SELECT Password,Id FROM dbo.userBD WHERE Login='" + Login + "'";
            SqlCommand myCommand = new SqlCommand(SQLExpression, connection);
            SqlDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                Password = ReadSingleRow((IDataRecord)reader);
            }
            if(Data.EntryPassword==Password.Trim())
            {
                Entry = true;
            }
            else
            {
                Entry = false;
            }
            return Entry;
            connection.Close();
        }

        public static void InsertIntoUnBD(int expId, string comment)
        {
            //Начало соединения с БД
            SqlConnection connection = StartConnection();

            string insertintobd = "INSERT INTO dbo.UnBD (experimentID,userID,comment,experimentDate) VALUES ";
            string appendstr = String.Format("({0},{1},N'{2}',GETDATE())", expId, Data.EntryId, comment);
            SqlCommand INSERT = new SqlCommand(insertintobd+appendstr,connection);
            INSERT.ExecuteNonQuery();

            int response = CloseConnection(connection);


        }

    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form AuthF = new AuthenticationForm();
            Application.Run(AuthF);
        }
    }
}
