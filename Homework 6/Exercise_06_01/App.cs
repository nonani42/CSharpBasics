using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Exercise_06_01
{
    public class App
    {
        public void Start()
        {
            new FileWriter().WriteToFile("studentList.csv", 42);
            List<Student> list = new FileReader().GetFromFile("studentList.csv");
            ToConsole p = new();
            WriteLine($"\nСписок студентов");
            p.Print(list);

            WriteLine($"\nа) Подсчитать количество студентов учащихся на 5 и 6 курсах");
            WriteLine($"{list.Where(e => e.Course == 5 || e.Course == 6).ToList().Count}");

            WriteLine($"\nб) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив)");
            p.Print(new Student().GetCourse(list, 18, 20));

            WriteLine($"\nв) отсортировать список по возрасту студента");
            p.Print(list.OrderBy(e => e.Age).ToList());

            WriteLine($"\nг) * отсортировать список по курсу и возрасту студента");
            p.Print(list.OrderBy(e => e.Course).ThenBy(e => e.Age).ToList());
        }
    }
}
