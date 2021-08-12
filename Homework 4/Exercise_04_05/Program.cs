using System;
using static System.Console;
using FirstLibrary;

namespace Exercise_04_05
{
    /// <summary>
    /// Новикова Наталья
    /// а) Реализовать библиотеку с классом для работы с двумерным массивом. 
    /// Реализовать конструктор, заполняющий массив случайными числами. 
    /// Создать методы, которые возвращают сумму всех элементов массива, 
    /// сумму всех элементов массива больше заданного, 
    /// свойство, возвращающее минимальный элемент массива, 
    /// свойство, возвращающее максимальный элемент массива, 
    /// метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
    ///* б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
    ///** в) Обработать возможные исключительные ситуации при работе с файлами.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            TwoDimensionArray array1 = new TwoDimensionArray(5, 5, -50, 50);
            array1.Print();
            WriteLine();
            WriteLine($"Сумма элементов: {array1.Sum()}");
            WriteLine($"Сумма элементов не менее 5: {array1.Sum(5)}");
            int[] index = { 0, 0 };
            WriteLine($"Наименьший элемент массива: {array1.Min}");
            array1.MinIndex(ref index);
            WriteLine($"Индекс наименьшего элемента массива: {index[0]}, {index[1]}");
            WriteLine($"Наибольший элемент массива: {array1.Max}");
            array1.MaxIndex(ref index);
            WriteLine($"Индекс наибольшего элемента массива: {index[0]}, {index[1]}");
            array1.WriteArrToFile("testArray1.txt");
            WriteLine();
            TwoDimensionArray array2 = new TwoDimensionArray("testArray.txt");
            array2.Print();
            WriteLine();
            TwoDimensionArray array3 = new TwoDimensionArray("testArray_extraSpaces.txt");
            array3.Print();
        }
    }
}
