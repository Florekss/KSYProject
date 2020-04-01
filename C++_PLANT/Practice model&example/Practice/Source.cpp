#include "plant.h"

//#include "discpp.h"

#include <cmath>
#include <vector>
#include <iostream>

using std::vector;
extern "C"
{
    static Plant plant;

    __declspec(dllexport) void Start_Plant(void)
    {  
        plant_init(plant);
    }
    __declspec(dllexport) double ChanellPoll(int channel_number)
    {   
        return plant_measure(channel_number,plant);
    }
    __declspec(dllexport) double* Start_Opros(int kadr_count)
    {
        //Каналы для опроса, согласно ТКИ.
        int channels_for_poll[22] = { 9,2,49,77,5,6,77,6,6,6,9,6,1,3,6,4,77,19,9,69,6,77 };
        //Возвращаемый кадр.
        static double frame[28];

        for (int i = 0; i < kadr_count; i++)
        {
            //1.Опрос канала 9.
            frame[0] = plant_measure(channels_for_poll[0], plant);
            //2.Опрос канала 2.
            frame[1] = plant_measure(channels_for_poll[1], plant);
            //3.Нормировка канала 2.
            frame[2] = (frame[1] - 730) / 70;
            //4.Опрос канала 49.
            frame[3] = plant_measure(channels_for_poll[2], plant);
            //5.Опрос канала 77.
            frame[4] = plant_measure(channels_for_poll[3], plant);
            //6.Опрос канала 5.
            frame[5] = plant_measure(channels_for_poll[4], plant);
            //7.Контроль Поз.Ограничений. 1<=X<=5. Канал 5.
            frame[6] = 999999;
            //8.Опрос канала 6.
            frame[7] = plant_measure(channels_for_poll[5], plant);
            //9.Опрос канала 77.
            frame[8] = plant_measure(channels_for_poll[6], plant);
            //10.Опрос канала 6.
            frame[9] = plant_measure(channels_for_poll[7], plant);
            //11.Опрос канала 6.
            frame[10] = plant_measure(channels_for_poll[8], plant);
            //12.Опрос канала 6.
            frame[11] = plant_measure(channels_for_poll[9], plant);
            //13.Опрос канала 9.
            frame[12] = plant_measure(channels_for_poll[10], plant);
            //14.Опрос канала 6.
            frame[13] = plant_measure(channels_for_poll[11], plant);
            //15.Опрос канала 1.
            frame[14] = plant_measure(channels_for_poll[12], plant);
            //16.Опрос канала 3.
            frame[15] = plant_measure(channels_for_poll[13], plant);
            //17.Опрос канала 6.
            frame[16] = plant_measure(channels_for_poll[14], plant);
            //18.Опрос канала 4.
            frame[17] = plant_measure(channels_for_poll[15], plant);
            //19.Опрос канала 77.
            frame[18] = plant_measure(channels_for_poll[16], plant);
            //20.Опрос канала 19.
            frame[19] = plant_measure(channels_for_poll[17], plant);
            //21.Опрос канала 9.
            frame[20] = plant_measure(channels_for_poll[18], plant);
            //22.Опрос канала 69.
            frame[21] = plant_measure(channels_for_poll[19], plant);
            //23.Расчет функции 0.3*Х*(0.1*Х-154). Канал 69.
            frame[22] = 0.3 * frame[22] * (0.1 * frame[23] - 154);
            //24.Контроль стабильноси канала 9.
            frame[23] = 999999;
            //25.Опрос канала 6.
            frame[24] = plant_measure(channels_for_poll[20], plant);
            //26.Опрос канала 77.
            frame[25] = plant_measure(channels_for_poll[21], plant);
            //27.Расчет среднего значения и оценки дисперсии по повторным измерениям в кадре. Канал 6.
            frame[26] = (frame[7] + frame[9] + frame[10] + frame[11] + frame[13] + frame[16] + frame[24]) / 7;
            //28.
            frame[27] = ((frame[7] - frame[26]) * (frame[7] - frame[26]) +
                 (frame[9] - frame[26]) * (frame[9] - frame[26]) +
                (frame[10] - frame[26]) * (frame[10] - frame[26]) +
                (frame[11] - frame[26]) * (frame[11] - frame[26]) +
                (frame[13] - frame[26]) * (frame[13] - frame[26]) +
                (frame[16] - frame[26]) * (frame[16] - frame[26]) +
                (frame[24] - frame[26]) * (frame[24] - frame[26])) / 7;
            //29. Контроль стабильности кадра 77.
            frame[28]= 999999;
        }
        return frame;

    }
}

