using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    //6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
    //«Хорошим» называется число, которое делится на сумму своих цифр.
    //Реализовать подсчёт времени выполнения программы, используя структуру DateTime.

    // решение предоставил Юрченко Н.А.

    class Task6
    {
        /// <summary>
        /// Метод подсчитывающий сумму своих цифр
        /// </summary>
        /// <param name="i">Число, для определения суммы</param>
        /// <returns></returns>
        static int SumNumber (int number)
        {
            int numberCount = number;
            int summ = 0;
            int count = 0;

            while (numberCount != 0)
            {
                count++;
                numberCount = numberCount / 10;                
            }

            for (int i = 0; i < count; i++)
            {
                summ += number % 10;
                number = number / 10;
            }

            return summ;         
        }


        static void Main(string[] args)
        {
            Screen screen = new Screen();
            screen.ScreenPrint(2, 6);

            Console.WriteLine("Подсчет количества «хороших» чисел в диапазоне от 1 до 1 000 000 000");
            Console.WriteLine("Подождите, процесс займет некоторое время...");

            DateTime start = DateTime.Now;

            int count=0;

            for (int i = 1; i < 1000000001; i++)
             {                              
                 if (i%SumNumber(i)==0)
                     count++;
             }

             Console.WriteLine($"Количество хороших чисел в диапазоне равно {count}");
             DateTime finish = DateTime.Now;
            

            Console.WriteLine($"Время выполнения программы: {finish - start}");
            
            Console.ReadLine();

        }

    }
}
