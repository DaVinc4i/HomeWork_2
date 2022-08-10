using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    //5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает,
    //нужно ли человеку похудеть, набрать вес или всё в норме.
    //   б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

    // решение предоставил Юрченко Н.А.

    class Task5
    {

        /// <summary>
        /// Метод рассчитывающий индекс массы тела
        /// </summary>
        /// <param name="height">Рост</param>
        /// <param name="weight">Вес</param>
        /// <returns></returns>
        static double IMT(string height, string weight)
        {
            double a = double.Parse(height);
            double b = double.Parse(weight);
            double result = b / (a * a);
            return result;
        }

        /// <summary>
        /// Метод анализирующий индекс веса и указывающий на физическое состояние
        /// </summary>
        /// <param name="imt">Индекс массы тела</param>
        static void IndexAnalysis(double imt)
        {
            if (imt <= 18)
                Console.Write("У Вас недостаток веса 2-й степени.");

            if (imt >= 18.1 && imt <= 20)
                Console.Write("У Вас недостаток веса 1-й степени.");

            if (imt >= 20.1 && imt <= 25)
                Console.Write("У Вас нормальный вес.");

            if (imt >= 25.1 && imt <= 27)
                Console.Write("Лишний вес.");

            if (imt >= 27.1 && imt <= 30)
                Console.Write("У Вас ожирение 1-й степени.");

            if (imt >= 30.1 && imt <= 35)
                Console.Write("У Вас ожирение 2-й степени.");

            if (imt > 35)
                Console.Write("У Вас ожирение 3-й степени.");

        }

        /// <summary>
        /// Метод направленный на расчет корректировки массы тела
        /// </summary>
        /// <param name="imt">Индекс массы тела</param>
        /// <param name="height">Вес</param>
        static void MassAdjustment (double imt, string height)
        {
            double a = double.Parse(height); // Преобразованный в double введенный рост
            double normWeightMin;
            double normWeightMax;

            if (imt <= 20)
            {
                normWeightMin = a*a*20.1 - a*a*imt;
                normWeightMax = a*a*25 - a*a*imt;

                Console.Write($"Вам необходимо набрать от {normWeightMin:0.00} до {normWeightMax:0.00} килограмм");
            }

            if (imt > 20 && imt <= 20)
                Console.Write("Поэтому сохраняйте его на том же уровне");


            if (imt > 25)
            {
                normWeightMin = a*a*imt - a*a*20.1;
                normWeightMax = a*a*imt - a*a*25;

                Console.Write($"Вам необходимо сбросить от {normWeightMax:0.00} до {normWeightMin:0.00} килограмм");
            }

        }


            static void Main(string[] args)
        {
            Screen screen = new Screen();
            screen.ScreenPrint(2, 5);


            Console.Write("Введите рост (в метрах):  ");
            string Height = Console.ReadLine();

            Console.Write("Введите вес (в килограммах):  ");
            string Weight = Console.ReadLine();

            double imt = IMT(Height, Weight);

            Console.WriteLine($"Индекс массы тела будет равен:  {imt:0.00}");
            Console.WriteLine();

            IndexAnalysis(imt);
            Console.Write(" ");
            MassAdjustment(imt, Height);


            Console.ReadLine();
        }
    }
}
