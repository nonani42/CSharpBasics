using System;

namespace Exercise_02_06
{
    //Новикова Наталья
    //*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
    //«Хорошим» называется число, которое делится на сумму своих цифр.
    //Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
    class Program
    {
        static void Main()
        {
            DateTime start = DateTime.Now;
            int counter = 0;
            for(int i = 1; i <= 1_000_000_000; i++)
            {
                counter = i % GetDigitsSum(i) == 0 ? ++counter : counter;
            }
            Console.WriteLine($"Количество \"хороших\" чисел:  {counter}.");
            DateTime finish = DateTime.Now;
            Console.WriteLine($"Программа выполнялась {finish - start}.");
        }
        private static int GetDigitsSum(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}
