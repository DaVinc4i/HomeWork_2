using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    //2. Написать метод подсчета количества цифр числа.

    // решение предоставил Юрченко Н.А.

    class Task2
    {
        /// <summary>
        /// Метод вычисляющий количество цифр в числе
        /// </summary>
        /// <param name="a"> Введенное число</param>
        /// <returns></returns>
        static int Count (int a)
        { 
            int count = 0;
            while (a != 0)
            {
                count++;
                a = a / 10;
            }
            
            return count;
        }

        static void Main(string[] args)
        {
            Screen screen = new Screen();
            screen.ScreenPrint(2, 2);

            Console.Write("Введите целое число для подсчета цифр в нем:  ");
            int value = int.Parse(Console.ReadLine());
            
            Console.Write("Количество цифр в числе равно "+ Count(value));            

            Console.ReadLine();
        }
    }
}
