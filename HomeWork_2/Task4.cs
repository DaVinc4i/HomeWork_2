using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    //4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
    //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
    //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
    //программа пропускает его дальше или не пропускает.
    //С помощью цикла do while ограничить ввод пароля тремя попытками.

    // решение предоставил Юрченко Н.А.

    class Task4
    {
       private static string _login = "root";
       private static string _password = "GeekBrains";


        /// <summary>
        /// Метод проверяющий правильность введенного пароля и логина
        /// </summary>
        /// <param name="login">Введенный логин</param>
        /// <param name="password">Введенный пароль</param>
        /// <returns></returns>
        static bool Identification(string login, string password)
        {
            if (login == Task4._login)
            {
                if (password == Task4._password)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        static void Main(string[] args)
        {
            Screen screen = new Screen();
            screen.ScreenPrint(2, 4);

            Console.WriteLine("Введите логин и пароль для авторизации");
            Console.WriteLine();

            int i = 0;
            string myLogin, myPassword;

            do
            {
                i++;

                if (i != 1)
                {
                    Console.WriteLine($"Повторите ввод. Осталось {4 - i} попытки");
                    Console.WriteLine();
                }

                Console.Write("Логин:  ");
                myLogin = Console.ReadLine();

                Console.Write("Пароль:  ");
                myPassword = Console.ReadLine();

                Console.WriteLine();

                if (Identification(myLogin, myPassword) == true)
                    break;
            }
            while (i != 3);
            
            if (Identification(myLogin, myPassword) == false && i==3)
                Console.WriteLine("Вы истратили все попытки");
            else
                Console.WriteLine("Поздравляем! Вы вошли в систему.");

            Console.ReadLine();
        }

    }
}
