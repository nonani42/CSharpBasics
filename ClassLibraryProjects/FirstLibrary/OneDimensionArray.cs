using System;
using System.Collections.Generic;

namespace FirstLibrary
{
    public class OneDimensionArray
    {
        int[] arr;
        public OneDimensionArray(int length)
        {
            arr = new int[length];
        }
        public OneDimensionArray(int length, int element)
        {
            arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = element;
            }
        }
        public OneDimensionArray(int length, int min, int max)
        {
            arr = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                arr[i] = rnd.Next(min, max);
            }
        }
        public OneDimensionArray(int length, int start, short step)
        {
            arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = start + step * i;
            }
        }
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                return sum;
            }
        }
        public int Max
        {
            get
            {
                int max = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] > max) max = arr[i];
                }
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] > min) min = arr[i];
                }
                return min;
            }
        }
        public int MaxCount
        {
            get
            {
                int maxCount = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == Max) maxCount++;
                }
                return maxCount;
            }
        }
        public int MinCount
        {
            get
            {
                int minCount = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == Min) minCount++;
                }
                return minCount;
            }
        }
        public int Length
        {
            get
            {
                return arr.Length;
            }
        }
        public int this[int i]
        {
            get
            {
                return arr[i];
            }
            set
            {
                arr[i] = value;
            }
        }
        public Dictionary<int, int> ElementFrequency
        {
            get
            {
                Dictionary<int, int> dic = new Dictionary<int, int>();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (!dic.ContainsKey(arr[i]))
                    {
                        dic.Add(arr[i], 1);
                    }
                    else
                    {
                        dic[arr[i]]++;
                    }
                }
                return dic;
            }
        }
        /// <summary>
        /// Возвращает новый массив с измененными знаками у всех элементов массива.
        /// </summary>
        /// <returns></returns>
        public OneDimensionArray Inverse()
        {
            OneDimensionArray inverseArr = new OneDimensionArray(arr.Length);
            for (int i = 0; i < inverseArr.Length; i++)
            {
                inverseArr[i] = -arr[i];
            }
            return inverseArr;
        }
        /// <summary>
        /// Умножает каждый элемент текущего массива на определённое число.
        /// </summary>
        /// <param name="multiplier"></param>
        public void Multi(int multiplier)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= multiplier;
            }
        }
        /// <summary>
        /// Выводит в консоль все элементы массива через пробел
        /// </summary>
        public void Print()
        {
            foreach (int el in arr)
            {
                Console.Write($"{el} ");
            }
            Console.WriteLine();
        }
    }
}
