using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{

    //1. Написать метод, возвращающий минимальное из трёх чисел.

    // решение предоставил Юрченко Н.А.

    public class Screen
    {
        /// <summary>
        /// Метод выводящий на экран номер задания и домашней работы, а также имя студента выполневшего работу
        /// </summary>
        /// <param name="homeworkNumber">Номер домашней работы</param>
        /// <param name="number">Номер задания</param>
        public void ScreenPrint (int homeworkNumber, int number)
            {
            string ms = "Приветствую!";
            Console.SetCursorPosition((Console.WindowWidth - ms.Length) / 2, Console.WindowTop);
            Console.WriteLine(ms);
            Console.WriteLine();
            ms = "Представляю решение задания №" + number + ", домашнего задания № " + homeworkNumber;
            Console.SetCursorPosition((Console.WindowWidth - ms.Length) / 2, Console.WindowTop+2);
            Console.WriteLine(ms);
            Console.WriteLine();
            ms = "Решение предоставил Юрченко Н.А.";
            Console.SetCursorPosition((Console.WindowWidth - ms.Length) / 2, Console.WindowTop + 4);
            Console.WriteLine(ms);
            Console.WriteLine();


        }
    }

    class Task1
    {
          /// <summary>
          /// Метод определяющий и выводящий на экран минимальное из трех заданных чисел
          /// </summary>
          /// <param name="a">Первое число</param>
          /// <param name="b">Второе число</param>
          /// <param name="c">Третье число</param>          
        static void MinValue(int a, int b, int c)
        {
            if (a < b)
            {
                if (a < c)               
                    Console.WriteLine("первое число равное  " + a);               
                   
                else
                    Console.WriteLine("третье число равное  " + c);                   
                                    
            }
            else
            {
                if (b < c)
                    Console.WriteLine("первое число равное  " + b);
                else
                    Console.WriteLine("третье число равное  " + c);
            }
        }
        
        static void Main(string[] args)
        {
            Screen screen = new Screen();
            screen.ScreenPrint(2, 1);

            Console.WriteLine("Введите три целых числа для определения минимального из них");
            Console.WriteLine();

            Console.Write("Введите первое число:   ");
            int value1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Введите второе число:   ");
            int value2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Введите третье число:   ");
            int value3 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Минимальное из трех целых чисел - ");

            MinValue(value1, value2, value3);

            Console.ReadLine();
        }
    }
}
