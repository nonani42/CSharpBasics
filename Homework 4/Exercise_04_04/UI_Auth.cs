using System;

namespace Exercise_04_04
{
    class UI_Auth
    {
        /// <summary>
        /// Получает логин и пароль от пользователя
        /// </summary>
        /// <returns>пользователь для авторизации</returns>
        public static Account GetAuthFromConsole()
        {
            Console.Write("Введите логин: ");
            string login = Console.ReadLine();
            Console.Write("Введите пароль: ");
            string pass = Console.ReadLine();
            return new Account(login, pass);
        }
        /// <summary>
        /// Выводит результат авторизации
        /// </summary>
        /// <param name="authResult">true если успех</param>
        /// <param name="authAttempts">количество оставшихся попыток авторизации</param>
        /// <param name="login">имя пользователя</param>
        public static void SendAuthResult(bool authResult, int authAttempts, string login)
        {
            if (authResult)
                Console.WriteLine($"Авторизация прошла успешно. С возвращением, {login}!");
            else
                Console.WriteLine($"Введен неверный логин и/или пароль. Осталось попыток ввода: {authAttempts}.");
        }
    }
}
