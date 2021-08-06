using System;
using System.Collections.Generic;

namespace Exercise_03_02
{
    //Новикова Наталья
    //а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
    //Требуется подсчитать сумму всех нечётных положительных чисел.
    //Сами числа и сумму вывести на экран, используя tryParse.
    class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            bool flag;
            string goodNumStr = "";
            List<int> goodNum = new List<int>();
            do
            {
                Console.Write("Введите число: ");
                flag = int.TryParse(Console.ReadLine(), out num);// 5; 0; string;
                if (num > 0 && num % 2 != 0)
                {
                    sum += num;
                    goodNum.Add(num);
                    goodNumStr = goodNumStr + num + "  ";
                }

            } while (num != 0 || !flag);//true||false=true; false||false=false;false||true=true
            Console.WriteLine($"Сумма введенных нечетных положительных чисел равна {sum}.");
            Console.WriteLine($"Из строки: {goodNumStr}");
            Console.Write($"Из листа: ");
            foreach (int element in goodNum)
            {
                Console.Write($"{element}  ");
            }

        }
    }
}
