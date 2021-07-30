using System;

namespace Exercise_01_03
{
    /*а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
     по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
     Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
     б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите абсциссу первого числа: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ординату первого числа: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите абсциссу второго числа: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ординату второго числа: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            DistanceBetweenPoints(x1, y1, x2, y2);
            Console.ReadLine();
        }

        private static void DistanceBetweenPoints(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Расстояние между точкой ({0}, {1}) и точкой ({2}, {3}) равно {4:F2}.", x1, y1, x2, y2, distance);
        }
    }
}
