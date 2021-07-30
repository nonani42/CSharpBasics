using System;

namespace Exercise_01_05
{
    /*а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
    б) *Сделать задание, только вывод организовать в центре экрана.
    в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).*/
    class Program
    {
        static void Main()
        {
            Console.Write("Write your name: ");
            string name = Console.ReadLine();
            Console.Write("Write your surname: ");
            string surname = Console.ReadLine();
            Console.Write("Write the city you live in: ");
            string city = Console.ReadLine();
            string msg = $"My name is {name} {surname} and I live in {city}.";
            PrintMsg(msg, (Console.WindowWidth - msg.Length) / 2, Console.WindowHeight / 2);
            Console.ReadKey();
        }

        private static void PrintMsg(string msg, int cursorX, int cursorY)
        {
            Console.SetCursorPosition(cursorX, cursorY);
            Console.WriteLine(msg);
        }
    }
}
