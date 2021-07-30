using System;

namespace Exercise_01_02
{
    //Новикова Наталья
    // Ввести вес и рост человека.
    // Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); 
    // где m — масса тела в килограммах, h — рост в метрах.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите Ваш вес (в кг): ");
            string weight = Console.ReadLine(); 
            Console.Write("Укажите Ваш рост (в м): ");
            string height = Console.ReadLine();
            double m = Convert.ToDouble(weight);
            double h = Convert.ToDouble(height);
            double imt = m / Math.Pow(h,2);
            Console.WriteLine("Индекс массы тела (ИМТ) равен " + imt + ".");
            Console.ReadLine();
        }
    }
}
