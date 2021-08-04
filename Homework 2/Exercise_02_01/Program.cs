using System;
using System.Linq;

namespace Exercise_02_01
{
    //Новикова Наталья
    //Написать метод, возвращающий минимальное из трёх чисел. (закоментировано)
    //Дополнительно (вне задания) реализован метод нахождения минимума для любого количества чисел используя массив
    class Program
    {
        static void Main()
        {
            //Console.Write("Введите первое число: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите второе число: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите третье число: ");
            //double num3 = Convert.ToDouble(Console.ReadLine());
            //GetMinNum(num1, num2, num3);
            Console.Write("Сколько чисел необходимо сравнить? ");
            double[] userNum = GetNumbers(Convert.ToInt32(Console.ReadLine()));
            Console.Write($"Наименьшее число из введенных: {userNum.Min()}");

        }
        private static double[] GetNumbers(int amountOfNumbers)
        {
            double[] num = new double[amountOfNumbers];
            for (int i = 0; i < amountOfNumbers; i++)
            {
                Console.Write($"Введите {i+1} число: ");
                num[i] = Convert.ToDouble(Console.ReadLine());
            }
            return num;
        }
        private static void GetMinNum(double num1, double num2, double num3)
        {
            double min = num1;
            if (num2 <= num1 && num2 <= num3)
            {
                min = num2;
            }
            else if (num3 <= num1 && num3 <= num2)
            {
                min = num3;
            }
            Console.Write($"Наименьшее число из введенных: {min}");
        }
    }
}
