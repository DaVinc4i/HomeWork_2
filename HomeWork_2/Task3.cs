using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    //3. С клавиатуры вводятся числа, пока не будет введен 0.
    //Подсчитать сумму всех нечетных положительных чисел.

    // решение предоставил Юрченко Н.А.

    class Task3
    {
        static void Main(string[] args)
        {
            Screen screen = new Screen();
            screen.ScreenPrint(2, 3);

            Console.WriteLine("Вводите целые числа для подсчета суммы нечетных чисел");
            Console.WriteLine("Для завершения ввода нажмите 0");
            Console.WriteLine();

            int number;
            int sumOddNumber=0;

            do
            {
                number = int.Parse(Console.ReadLine());

                if (number % 2 == 1 && number>0)
                    sumOddNumber = sumOddNumber + number;
            }
            while (number != 0);


            Console.Write("Сумма нечетных чисел равна " + sumOddNumber);

            Console.ReadLine();
        }


    }
}
