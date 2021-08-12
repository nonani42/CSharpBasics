using System;
using System.Collections.Generic;
using System.IO;

namespace Exercise_04_02
{
    static class StaticClass
    {
        /// <summary>
        /// Создает и возвращает массив целых чисел из указанного файла.
        /// </summary>
        /// <param name="path">путь к файлу</param>
        /// <returns>Массив целых чисел.</returns>
        public static int[] GetArrFromFile(string path)
        {
            List<int> list = new List<int>();
            try
            {
                StreamReader sr = new StreamReader(path);
                while (!sr.EndOfStream)
                {
                    list.Add(int.Parse(sr.ReadLine()));
                }
                sr.Close();
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            return list.ToArray();
        }
        /// <summary>
        /// Создает массив и заполняет его случайными числами в заданном интервале
        /// </summary>
        /// <param name="min">наименьшее возможное значение элемента массива</param>
        /// <param name="max">наибольшее возможное значение элемента массива</param>
        public static int[] RandomArray(int length, int min, int max)
        {
            int[] myArr = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = rnd.Next(min, max);
            }
            return myArr;
        }
        /// <summary>
        /// Находит и возвращает количество пар элементов массива (два подряд идущих элемента), в которых только одно число делится на заданное значение.
        /// </summary>
        /// <param name="myArr">массив</param>
        /// <param name="divisor">делитель</param>
        /// <returns>Возвращает количество пар</returns>
        public static int GetGoodPair(int[] myArr, int divisor)
        {
            int counter = 0;
            for (int i = 0; i < myArr.Length - 1; i++)
            {
                if ((myArr[i] % divisor == 0 && myArr[i + 1] % divisor != 0) ||
                    (myArr[i] % divisor != 0 && myArr[i + 1] % divisor == 0))
                {
                    counter++;
                }
            }
            return counter;
        }
        public static void Print(int[] myArr)
        {
            foreach (int el in myArr)
            {
                Console.Write($"{el} ");
            }
            Console.WriteLine();
        }
    }
}
