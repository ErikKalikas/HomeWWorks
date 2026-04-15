using System;
using System.Collections.Generic;
using System.Text;

namespace Works
{

    class Auto
    {

        public string Mudel { get; set; }

        public double KutuseKulu { get; set; }

        public double PaagisOnKutust { get; set; }

        public Auto(string Mudel, double KutuseKulu, double PaagisOnKutust)

        {

            this.Mudel = Mudel;

            this.KutuseKulu = KutuseKulu;  //- сколько литров топлива расходуется на 100 км

            this.PaagisOnKutust = PaagisOnKutust;  //сколько литров топлива в баке в данный момент

        }

        public double CalculateDistance()
        {

            return PaagisOnKutust / KutuseKulu * 100;

        }

        public void PrintInfo()

        {

            Console.WriteLine($"Mudel: {Mudel}");

            Console.WriteLine($"KutuseKulu: {KutuseKulu} l/100km");

            Console.WriteLine($"PaagisOnKutust: {PaagisOnKutust} l");

            Console.WriteLine($"Distance: {CalculateDistance()} km");

        }

    }


    internal class Class1
    {
        /*
         Задача 5: управление автопарком (список и логика) (5p) 

    Тема: управление списком объектов, фильтрация. Решая эту задачу, используйте заранее созданный класс автомобиля. Создать функции данных класса (или Program) в метод управляйте машинами. Деятельность:

    Создать List<Auto> и добавить в него в коде не менее 3 автомобилей (например: "Toyota", 5.5, 40; "BMW", 8.0, 15).

    Найдите и отобразите в консоли автомобиль с наибольшим запасом хода (используйте Вычислениедиапазон питания () метод).

    Составьте список автомобилей с менее чем 10 литрами топлива в баке (так называемые "автомобили, нуждающиеся в немедленной заправке") и покажите их модели.

    Придумайте свою собственную функцию, которая хранит данные в файле.



         */
        public static void autopark()
        {
            List<Auto> needFuel = new List<Auto>();
            List<Auto> list1 = new List<Auto>
            {
                new Auto("bmv", 10, 40.5),
                new Auto("mercedes", 10, 45),
                new Auto("lada", 14, 50),
                new Auto("ddd", 5, 9),
                new Auto("d2", 6, 8)
            };

            double Max = 0;
            int index = 0;
            
            for (int i = 0; i < list1.Count ; i++)
            {
                if (list1[i].CalculateDistance() > Max)
                {
                    Max = list1[i].CalculateDistance();
                    index = i;                 
                }

                if (list1[i].PaagisOnKutust < 10)
                {
                    needFuel.Add(list1[i]);
                }
            }
            Console.WriteLine(Max);
            list1[index].PrintInfo();


            foreach (var car in needFuel)
            {
                Console.WriteLine(car.Mudel);
            }
        }
    }
}
