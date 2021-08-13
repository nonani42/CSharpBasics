using System;
using System.Collections.Generic;
using static System.Console;
using FirstLibrary;

namespace Exercise_04_03
{
    /// <summary>
    /// Новикова Наталья
    ///а) Дописать класс для работы с одномерным массивом.
    ///Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
    ///Создать свойство Sum, которое возвращает сумму элементов массива,
    ///метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),
    ///метод Multi, умножающий каждый элемент массива на определённое число,
    ///свойство MaxCount, возвращающее количество максимальных элементов.
    ///б)** Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
    ///в) *** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            OneDimensionArray arr = new OneDimensionArray(20, 0, step: 10);
            WriteLine("Исходный массив");
            arr.Print();
            WriteLine($"Сумма элементов: {arr.Sum}");
            OneDimensionArray inverseArr = arr.Inverse();
            WriteLine("Исходный массив");
            arr.Print();
            WriteLine("Инверсированный массив");
            inverseArr.Print();
            arr.Multi(4);
            WriteLine("Исходный массив после умножения на 4: ");
            arr.Print();
            WriteLine($"Количество максимальных элементов: {arr.MaxCount}");
            OneDimensionArray arr2 = new OneDimensionArray(10, 5);
            WriteLine($"Количество максимальных элементов: {arr2.MaxCount}");
            //в) *** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)
            OneDimensionArray arr3 = new OneDimensionArray(10, -10, 10);
            Dictionary<int, int> dic = arr3.ElementFrequency;
            WriteLine($"Частота вхождения каждого элемента в массив");
            arr3.Print();
            WriteLine($"int : frequency");
            foreach (KeyValuePair<int, int> pair in dic)
            {
                WriteLine($"{pair.Key,1}   :   {pair.Value,3}");
            }
        }
    }
}
