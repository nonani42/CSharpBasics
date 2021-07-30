using System;

namespace Exercise_01_01
{
    /*Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
    а) используя  склеивание;
	б) используя форматированный вывод;
	в) используя вывод со знаком $.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите Ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Укажите Вашу фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Укажите Ваш возраст: ");
            string age = Console.ReadLine();
            Console.Write("Укажите Ваш рост (в см): ");
            string height = Console.ReadLine();
            Console.Write("Укажите Ваш вес (в кг): ");
            string weight = Console.ReadLine();
            Console.WriteLine("Были введены следующие данные: " + name + " " + surname + ", " + age + " лет, " + height + " см, " + weight + " кг");
            Console.WriteLine("Были введены следующие данные: {0} {1}, {2} лет, {3} см, {4} кг", name, surname, age, height, weight);
            Console.WriteLine($"Были введены следующие данные: {name} {surname}, {age} лет, {height} см, {weight} кг");
            Console.ReadLine();
        }
    }
}
