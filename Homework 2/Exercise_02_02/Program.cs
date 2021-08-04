using System;

namespace Exercise_02_02
{
    //Новикова Наталья
    //Написать метод подсчета количества цифр числа.
    class Program
    {
        static void Main()
        {
            Console.Write("Введите целое число: ");
            //Без преобразования в число
            //string userNumber = Console.ReadLine();
            //Console.WriteLine($"Количество цифр во введенном числе {userNumber}: {userNumber.Length}.");

            //С преобразованием в число
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Количество цифр во введенном числе {userNumber}: {GetDigitsAmount(userNumber)}.");
        }

        private static int GetDigitsAmount(int userNumber)
        {
            int counter = userNumber == 0 ? 1 : 0;
            while (userNumber != 0)
            {
                userNumber /= 10;
                counter++;
            }
            return counter;
        }
    }
}
