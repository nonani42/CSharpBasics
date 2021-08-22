using System;
using System.Collections.Generic;

namespace Exercise_06_01
{
    public class ToConsole
    {
        const int surnameLength = 15;
        const int nameLength = 15;
        const int universityLength = 15;
        const int facultyLength = 15;
        const int departmentLength = 15;
        const int ageLength = 10;
        const int courseLength = 5;
        const int groupLength = 10;
        const int cityLength = 10;
        public void Print(Student student)
        {
            Console.WriteLine($"{"Фамилия",-surnameLength} " +
                $"{"Имя",-nameLength} " +
                $"{"Университет",-universityLength} " +
                $"{"Факультет",-facultyLength} " +
                $"{"Направление",-departmentLength} " +
                $"{"Возраст",-ageLength} " +
                $"{"Курс",-courseLength} " +
                $"{"Группа",-groupLength} " +
                $"{"Город",-cityLength}");
            Console.WriteLine($"{student.Surname,-surnameLength} " +
                $"{student.Name,-nameLength} " +
                $"{student.University,-universityLength} " +
                $"{student.Faculty,-facultyLength} " +
                $"{student.Department,-departmentLength} " +
                $"{student.Age,-ageLength} " +
                $"{student.Course,-courseLength} " +
                $"{student.Group,-groupLength} " +
                $"{student.City,-cityLength}");
        }
        public void Print(List<Student> list)
        {
            Console.WriteLine($"{"Фамилия",-surnameLength} " +
                $"{"Имя",-nameLength} " +
                $"{"Университет",-universityLength} " +
                $"{"Факультет",-facultyLength} " +
                $"{"Направление",-departmentLength} " +
                $"{"Возраст",-ageLength} " +
                $"{"Курс",-courseLength} " +
                $"{"Группа",-groupLength} " +
                $"{"Город",-cityLength}");
            foreach (var student in list)
            {
                Console.WriteLine($"{student.Surname,-surnameLength} " +
                    $"{student.Name,-nameLength} " +
                    $"{student.University,-universityLength} " +
                    $"{student.Faculty,-facultyLength} " +
                    $"{student.Department,-departmentLength} " +
                    $"{student.Age,-ageLength} " +
                    $"{student.Course,-courseLength} " +
                    $"{student.Group,-groupLength} " +
                    $"{student.City,-cityLength}");
            }
        }
        public void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i + 1} курс: {arr[i]}");
            }
        }
    }
}
