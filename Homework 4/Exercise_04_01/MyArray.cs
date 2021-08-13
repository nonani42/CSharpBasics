using System;

namespace Exercise_04_01
{
    class MyArray
    {
        int[] myArr;

        public MyArray(int length, int min, int max)
        {
            myArr = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = rnd.Next(min, max);
            }
        }
        public void Print()
        {
            foreach(int el in myArr)
            {
                Console.Write($"{el} ");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Находит и возвращает количество пар элементов массива (два подряд идущих элемента), в которых только одно число делится на заданное значение.
        /// </summary>
        /// <param name="divisor">делитель</param>
        /// <returns>Возвращает количество пар</returns>
        public int GetGoodPair(int divisor)
        {
            int counter = 0;
            for(int i = 0; i < myArr.Length-1; i++)
            {
                if((myArr[i]%divisor == 0 && myArr[i+1] % divisor != 0) || 
                    (myArr[i] % divisor != 0 && myArr[i + 1] % divisor == 0))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
