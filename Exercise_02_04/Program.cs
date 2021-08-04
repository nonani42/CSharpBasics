using System;

namespace Exercise_02_04
{
    //Новикова Наталья
    //Реализовать метод проверки логина и пароля.
    //На вход метода подается логин и пароль.
    //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
    //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
    //С помощью цикла do while ограничить ввод пароля тремя попытками.
    class Program
    {
        static void Main()
        {
            int attempts = 3;
            do
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                string pass = Console.ReadLine();
                if (CheckAuth(login, pass))
                {
                    Console.WriteLine($"Авторизация прошла успешно. С возвращением, {login}!");
                    break;
                }
                else
                {
                    attempts--;
                    Console.WriteLine($"Введен неверный логин и/или пароль. Осталось попыток ввода: {attempts}.");
                }

            } while(attempts > 0);
        }

        private static bool CheckAuth(string login, string pass)
        {
            return login == "root" && pass == "GeekBrains";
        }
    }
}
