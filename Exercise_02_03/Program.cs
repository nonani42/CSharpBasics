using System;

namespace Exercise_02_03
{
    //Новикова Наталья
    //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
    class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            do
            {
                Console.Write("Введите число: ");
                num = Convert.ToInt32(Console.ReadLine());
                if(num > 0 && num % 2 != 0)
                {
                    sum += num;
                }

            } while (num != 0);
            Console.WriteLine($"Сумма всех нечетных положительных чисел равна {sum}.");
        }
    }
}
