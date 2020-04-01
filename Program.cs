using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace WindowsFormsApp1
{
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
                frame[i, 6] = 999999;
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
                frame[i, 23] = 999999;
                //25.Опрос канала 6.
                frame[i, 24] = ChanellPoll(channels_for_poll[20]);
                //26.Опрос канала 77.
                frame[i, 25] = ChanellPoll(channels_for_poll[21]);
                //27.Расчет среднего значения и оценки дисперсии по повторным измерениям в кадре. Канал 6.
                frame[i, 26] = (frame[i, 7] + frame[i, 9] + frame[i, 10] + frame[i, 11] + frame[i, 13] + frame[i, 16] + frame[i, 24]) / 7;
                //28.
                frame[i, 27] = ((frame[i, 7] - frame[i, 26]) * (frame[i, 7] - frame[i, 26]) +
                     (frame[i, 9] - frame[i, 26]) * (frame[i, 9] - frame[i, 26]) +
                    (frame[i, 10] - frame[i, 26]) * (frame[i, 10] - frame[i, 26]) +
                    (frame[i, 11] - frame[i, 26]) * (frame[i, 11] - frame[i, 26]) +
                    (frame[i, 13] - frame[i, 26]) * (frame[i, 13] - frame[i, 26]) +
                    (frame[i, 16] - frame[i, 26]) * (frame[i, 16] - frame[i, 26]) +
                    (frame[i, 24] - frame[i, 26]) * (frame[i, 24] - frame[i, 26])) / 7;
                //29. Контроль стабильности кадра 77.
                frame[i, 28] = 999999;
                //Обновление response.
                response[i, 0] = i + 1;//Номер кадра.
                //response[i, 1] = frame[i, 14];//Канал 1. Простой опрос.
                //response[i, 2] = frame[i, 2];//Канал 2. Нормированное значение.
                //response[i, 3] = frame[i, 15];// Канал 3. Простой опрос.
                //response[i, 4] = frame[i, 17];// Канал 4. Простой опрос.

                //#FixMe
                response[i, 5] = frame[i, 5];// Канал 5. Позиционные ограничения. 1<X<3
                response[i, 6] = frame[i, 26];// Канал 6. Среднее
                response[i, 7] = frame[i, 27];// Канал 6. Дисперсия

                //#FixMe
                response[i, 8] = frame[i, 20];//Канал 9. Контроль стабильности.
                //response[i, 9] = frame[i, 19];//Канал 19. Простой опрос.
                //response[i, 10] = frame[i, 3];//Канал 49. Простой опрос.
                //response[i, 11] = frame[i, 22];// Канал 69. Расчет функции.
                //#FixMe
                response[i, 12] = frame[i, 28];//Канал 77. Контроль стабильности
            }
            
            return response;
        }
        


    }

    public static class SQLMethonds
    {

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
