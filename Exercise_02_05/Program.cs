using System;

namespace Exercise_02_05
{
    //Новикова Наталья
    //а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
    //б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
    class Program
    {
        static void Main()
        {
            Console.Write("Укажите Ваш вес (в кг): ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Укажите Ваш рост (в м): ");
            double height = Convert.ToDouble(Console.ReadLine());
            double imt = GetIMT(weight, height);
            Console.WriteLine($"Ваш индекс массы тела (ИМТ) равен {imt}.");
            double minNormalImt = 18.50, maxNormalImt = 29.99;
            double minNormalWeight = GetWeight(height, minNormalImt);
            double maxNormalWeight = GetWeight(height, maxNormalImt);
            if (imt < 16.00)
            {
                Console.WriteLine("Выраженный дефицит массы тела. Необходимо набрать не менее {0:F2} кг!", minNormalWeight - weight);
            } else if (imt >= 16.00 && imt <= 18.49) {
                Console.WriteLine("Недостаточная (дефицит) масса тела. Необходимо набрать не менее {0:F2} кг!", minNormalWeight - weight);
            } else if (imt >= minNormalImt && imt <= maxNormalImt)
            {
                Console.WriteLine("Это норма. Так держать!");
            } else if (imt >= 25.00 && imt <= 29.99)
            {
                Console.WriteLine("Избыточная масса тела (предожирение). Необходимо сбросить не менее {0:F2} кг!", weight - maxNormalWeight);
            } else if (imt >= 30.00 && imt <= 34.99)
            {
                Console.WriteLine("Ожирение первой степени. Необходимо сбросить не менее {0:F2} кг!", weight - maxNormalWeight);
            } else if (imt >= 35.00 && imt <= 39.99)
            {
                Console.WriteLine("Ожирение второй степени. Необходимо сбросить не менее {0:F2} кг!", weight - maxNormalWeight);
            }
            else if (imt >= 40.00)
            {
                Console.WriteLine("Ожирение третьей степени (морбидное). Необходимо сбросить не менее {0:F2} кг!", weight - maxNormalWeight);
            }
        }

        private static double GetWeight(double height, double imt)
        {
            return Math.Pow(height, 2) * imt;
        }

        private static double GetIMT(double weight, double height)
        {
            return weight / Math.Pow(height, 2);
        }
    }
}
