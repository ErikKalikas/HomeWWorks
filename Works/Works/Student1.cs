using System;
using System.Collections.Generic;
using System.Text;

namespace Works
{
    /*
        Задание 3
        Создать класс Student.

        Поля:
        Name (строка) — имя
        Age (int) — возраст
        Grades (массив int) — оценки

        Методы:
        GetAverageGrade() — возвращает средний балл
        GetMaxGrade() — возвращает максимальную оценку
        IsExcellent() — возвращает true, если средний балл ≥ 4.5, иначе false

        Подсказка:
        Средний балл = сумма всех оценок / количество оценок
     */
    class Student
    {
        public string Name { get; }
        public int Age { get; }
        public int[] Grades { get; }

        public Student(string Name, int Age, int[] Grades)
        {
            this.Name = Name;
            this.Age = Age;
            this.Grades = Grades;
        }
        public double GetAverageGrade()
        {
            return (double)Grades.Sum() / Grades.Length;
        }

        public double GetMaxGrade()
        {
            return Grades.Max();
        }

        public bool IsExcellent()
        {
            Double ss = (double)Grades.Sum() / Grades.Length;
            if (ss >= 4.5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
