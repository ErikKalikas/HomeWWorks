using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Works
{
    /*


    Задание 1. 

    Создать класс Phone.

    Поля:
    Brand (строка) — марка телефона
    BatteryCapacity (int) — ёмкость батареи (мАч)
    CurrentBattery (int) — текущий заряд (мАч)
    ConsumptionPerHour (int) — расход батареи в час (мАч)

    Метод:
    GetRemainingWorkTime() — возвращает количество часов, которое телефон может ещё работать

    Подсказка:
    Время работы = CurrentBattery / ConsumptionPerHour
    
     */

    public class Phone
    {
        public string Breand { get; }
        public int BatteryCapacity { get; }
        public int CurrentBattery { get; }
        public int ConsumptionPerHour { get; }

        public Phone(string Breand, int BatteryCapacity, int CurrentBattery, int ConsumptionPerHour)
        {
            this.Breand = Breand;
            this.BatteryCapacity = BatteryCapacity;
            this.CurrentBattery = CurrentBattery;
            this.ConsumptionPerHour = ConsumptionPerHour;
        }

        public double GetRemainingWorkTime()
        {
            return (double)CurrentBattery / ConsumptionPerHour;
        }
    }


    
    
}

