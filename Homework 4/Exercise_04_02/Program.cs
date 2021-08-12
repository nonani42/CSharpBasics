using System;

namespace Exercise_04_02
{
    /// <summary>
    ///Новикова Наталья
    ///Реализуйте задачу 1 в виде статического класса StaticClass;
    ///а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
    ///б) Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
    ///в)* Добавьте обработку ситуации отсутствия файла на диске.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int divisor = 3, counter;
            int[] arr = StaticClass.RandomArray(20, -10_000, 10_000);
            StaticClass.Print(arr);
            counter = StaticClass.GetGoodPair(arr, divisor);
            Console.WriteLine($"Количество пар, один элемент которых делится на {divisor}: {counter}.");
            int[] arr1 = StaticClass.GetArrFromFile("testArray1.txt");
            StaticClass.Print(arr1);
            counter = StaticClass.GetGoodPair(arr1, divisor);
            Console.WriteLine($"Количество пар, один элемент которых делится на {divisor}: {counter}.");
            int[] arr2 = StaticClass.GetArrFromFile("testArray2.txt"); //файл не существует
        }
    }
}
