using System;
using System.Collections.Generic;
using System.IO;

namespace Exercise_05_04
{
    public class NinthGrade
    {
        string surname;
        string name;
        int grade1;
        int grade2;
        int grade3;
        double average;
        public NinthGrade(string surname, string name, int grade1, int grade2, int grade3)
        {
            this.surname = surname;
            this.name = name;
            this.grade1 = grade1;
            this.grade2 = grade2;
            this.grade3 = grade3;
            average = Math.Round((double)(grade1 + grade2 + grade3) / 3,1);
        }
        public double Average
        {
            get
            {
                return average;
            }
        }
        public static double MinAverage(NinthGrade[] pupils)
        {
            double min = pupils[0].Average;
            for (int i = 0; i < pupils.Length; i++)
            {
                if (min > pupils[i].Average)
                {
                    min = pupils[i].Average;
                }
            }
            return min;
        }
        public static double MaxAverage(NinthGrade[] pupils)
        {
            double max = pupils[0].Average;
            for (int i = 0; i < pupils.Length; i++)
            {
                if (max < pupils[i].Average)
                {
                    max = pupils[i].Average;
                }
            }
            return max;
        }
        public static NinthGrade[] GetFromFile(string path)
        {
            StreamReader stream = new StreamReader(path);
            NinthGrade[] arr = new NinthGrade[int.Parse(stream.ReadLine())];
            int i = 0;
            string[] temp;
            while (!stream.EndOfStream)
            {
                temp = stream.ReadLine().Split(" ");
                arr[i] = new NinthGrade(temp[0], temp[1], int.Parse(temp[2]), int.Parse(temp[3]), int.Parse(temp[4]));
                i++;
            }
            stream.Close();
            return arr;
        }
        /// <summary>
        /// Возвращает массив всех учеников с указанным количеством наименьших средних баллов из списка
        /// </summary>
        /// <param name="pupils">исходный массив</param>
        /// <param name="minNum">количество наименьших средних баллов</param>
        /// <returns></returns>
        public static NinthGrade[] GetMinAverageArr(NinthGrade[] pupils, int minNum)
        {
            double[] averageArr = new double[minNum];
            averageArr[0] = MinAverage(pupils);
            for (int i = 1; i < averageArr.Length; i++)
            {
                averageArr[i] = MaxAverage(pupils);
                for (int j = 0; j < pupils.Length; j++)
                {
                    if (pupils[j].Average > averageArr[i - 1] && pupils[i].Average < averageArr[i])
                    {
                        averageArr[i] = pupils[j].Average;
                    }
                }
            }
            List<NinthGrade> list = new List<NinthGrade>();
            for (int i = 0; i < pupils.Length; i++)
            {
                for (int j = 0; j < averageArr.Length; j++)
                {
                    if (pupils[i].Average == averageArr[j])
                    {
                        list.Add(pupils[i]);
                    }
                }
            }
            return list.ToArray();
        }
        public static void PrintAverage(NinthGrade[] pupils)
        {
            Console.WriteLine($"{"Фамилия",-20} {"Имя",-15} Средний балл");
            for (int i = 0; i < pupils.Length; i++)
            {
                    pupils[i].PrintAverage();
            }
        }
        public void PrintAverage()
        {
            Console.WriteLine($"{surname,-20} {name,-15} {average:F1}");
        }
    }
}
