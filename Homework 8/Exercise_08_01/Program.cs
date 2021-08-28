using System;

namespace Exercise_08_01
{
    /// <summary>
    /// Новикова Наталья
    /// С помощью рефлексии выведите все свойства структуры DateTime.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var attr = new DateTime().GetType().GetProperties();
            foreach(var item in attr)
            {
                Console.WriteLine($"{item.Name}");
            }
            Console.WriteLine();
            attr = typeof(DateTime).GetProperties();
            foreach (var item in attr)
            {
                Console.WriteLine($"{item.Name}");
            }
        }
    }
}
