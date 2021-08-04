using System;

namespace Exercise_01_04
{
    //Новикова Наталья
    //Написать программу обмена значениями двух переменных:
    //а) с использованием третьей переменной;
    //б) * без использования третьей переменной.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое целое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе целое число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            //Вариант а
            //int c = a;
            //a = b;
            //b = c;
            //Вариант б
            a = a + b;
            b = a - b;
            a = a - b;
            Console.Write($"Первое число теперь равно {a}, а второе число теперь равно {b}.");
            Console.ReadKey();
        }
    }
}
