#include "plant.h"

#include <discpp.h>

#include <cmath>
#include <vector>

using std::vector;

vector<double> Measure{};
vector<double> main_measure(int channel, int steps){
    //Создание выходного массива.
    vector<double> ys(steps);
    // Инициализация ОУ.
    Plant plant;
    plant_init(plant);

    for (int i = 0; i < steps; i++) {
        ys[i] = plant_measure(channel, plant);
    }

    return ys;
}
