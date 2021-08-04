using System;

namespace Exercise_02_07
{
    //Новикова Наталья
    //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
    //б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.
    class Program
    {
        static void Main()
        {
            int a = 0;
            int b = 100;
            WriteNumSequenceR(a, b);
            Console.WriteLine($"Сумма: {GetNumSumR(a, b)}.");
        }

        private static int GetNumSumR(int a, int b)
        {
            int sum = 0;
            return a < b ? a + GetNumSumR(++a, b) : sum;
        }

        private static void WriteNumSequenceR(int a, int b)
        {
            Console.WriteLine(a++);
            if (a < b)
                WriteNumSequenceR(a, b);
        }
    }
}
