using System;
using System.Collections.Generic;
using System.Text;

namespace Works
{
    /*
     Задание 1: Ведение журнала (запись в файл) (3 балла)
    Тема: StreamWriter, режим добавления (append-mode), DateTime.
    Создайте в классе AndmeFunktsioonid метод KirjutaLogi, который принимает в качестве параметра текстовое сообщение (например, «Пользователь вошёл в систему»).
    Действие:
    Метод должен открыть файл logi.txt в режиме добавления (append: true).
    Каждая строка в файле должна иметь формат: [ДАТА и ВРЕМЯ] - Сообщение.
    Пример содержимого файла: [18.02.2025 14:30:00] - Программа запущена.
    Подсказка: Используйте DateTime.Now.
     */


    /*
         Задание 3: Чтение и анализ файла (4 балла)
    Тема: StreamReader, Try-Catch, String.Split.
    У вас есть файл numbers.txt, содержащий числа, разделенные запятыми (например: 10, 20, 5, 100, 4).
    Напишите метод LoeJaArvuta, который:

    Считывает текст из файла.

    Разделяет текст на массив (используйте .Split(„,“)).

    Преобразует тексты в целые числа (int.Parse).

    Вычисляет и возвращает Tuple<int, double>:

    Item1: Сумма чисел.

    Item2: среднее значение чисел.

    NB! Используйте блок try-catch, чтобы избежать сбоя программы, если файл не существует.

    Переведено с помощью DeepL.com (бесплатная версия)
     */


    class AndmeFunktsioonidv
    {
        public static void KirjutaLogi(string log)
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logi.txt");
                StreamWriter file = new StreamWriter(path, true);
                file.WriteLine(log + " [" + DateTime.Now + "]");
                file.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static Tuple<int, double> LoeJaArvuta()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "numbers.txt");
                StreamReader file = new StreamReader(path);
                string text = file.ReadLine();
                Console.WriteLine(text);
                string[] masiv = text.Split(",");
                int[] masiv2 = Array.ConvertAll(masiv, int.Parse);      //int[] masiv2 = text.Split(",").Select(int.Parse).ToArray(); //конвертировать всё

                int sum = masiv2.Sum();
                double keskarv = masiv2.Average();

                List<int> nn = new List<int>();
                return Tuple.Create(sum, keskarv);

            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException incorekt format in file");
                return null;
            }
            catch (IOException)
            {
                Console.WriteLine("error can't open file");
                return null;
            }
        }
    }
}