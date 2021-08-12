using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FirstLibrary
{
    public class TwoDimensionArray
    {
        int[,] arr;
        public TwoDimensionArray(int rows, int columns)
        {
            arr = new int[rows, columns];
        }
        public TwoDimensionArray(int rows, int columns, int element)
        {
            arr = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arr[i,j] = element;
                }
            }
        }
        public TwoDimensionArray(int rows, int columns, int min, int max)
        {
            arr = new int[rows, columns];
            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arr[i,j] = rnd.Next(min, max);
                }
            }
        }
        public TwoDimensionArray(string path)
        {
            ReadArrFromFile(path);
        }
        /// <summary>
        /// Создает двумерный массив из файла, в котором первая строка - размеры массива в формате "количество строк количество столбцов"
        /// </summary>
        /// <param name="path"></param>
        private void ReadArrFromFile(string path)
        {
            try
            {
                StreamReader stream = new StreamReader(path);
                string[] size = Regex.Replace(stream.ReadLine(), "[ ]+", " ").Split();
                int rows = int.Parse(size[0]);
                int columns = int.Parse(size[1]);
                arr = new int[rows, columns];
                for (int i = 0; i < rows; i++)
                {
                    string[] temp = Regex.Replace(stream.ReadLine(), "[ ]+", " ").Split();
                    for (int j = 0; j < columns; j++)
                    {
                        arr[i, j] = int.Parse(temp[j]);
                    }
                }
                stream.Close();
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
        public void WriteArrToFile(string path)
        {
            StreamWriter stream = new StreamWriter(path);
            for (int i = 0; i < Rows; i++)
            {
                string temp = default;
                for (int j = 0; j < Columns; j++)
                {
                    temp += $"{arr[i, j],5} ";
                }
                stream.WriteLine(temp);
            }
            stream.Close();
        }

        /// <summary>
        /// Сумма всех элементов массива
        /// </summary>
        /// <returns></returns>
        public int this[int i, int j]
        {
            get
            {
                return arr[i, j];
            }
            set
            {
                arr[i, j] = value;
            }
        }
        public int Rows
        {
            get
            {
                return arr.GetLength(0);
            }
        }
        public int Columns
        {
            get
            {
                return arr.GetLength(1);
            }
        }
        public int Min
        {
            get
            {
                int min = arr[0, 0];
                for (int i = 1; i < Rows; i++)
                {
                    for (int j = 1; j < Columns; j++)
                    {
                        if (arr[i, j] < min) min = arr[i, j];
                    }
                }
                return min;
            }
        }
        public int Max
        {
            get
            {
                int max = arr[0,0];
                for (int i = 1; i < Rows; i++)
                {
                    for (int j = 1; j < Columns; j++)
                    {
                        if (arr[i,j] > max) max = arr[i,j];
                    }
                }
                return max;
            }
        }
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    sum += arr[i,j];
                }
            }
            return sum;
        }
        /// <summary>
        /// Сумма всех элементов массива больше заданного
        /// </summary>
        /// <param name="min"></param>
        /// <returns></returns>
        public int Sum(int min)
        {
            int sum = 0;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (arr[i, j] > min)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            return sum;
        }
        public void MinIndex(ref int[] index)
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if(arr[i,j] == Min)
                    {
                        index[0] = i;
                        index[1] = j;
                    }
                }
            }
        }
        public void MaxIndex(ref int[] index)
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (arr[i, j] == Max)
                    {
                        index[0] = i;
                        index[1] = j;
                    }
                }
            }
        }
        /// <summary>
        /// Выводит в консоль все элементы массива через пробел
        /// </summary>
        public void Print()
        {
            for(int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    Console.Write($"{arr[i,j], 5} ");
                }
                Console.WriteLine();
            }
        }
    }
}
