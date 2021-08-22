using System.Collections.Generic;

namespace Exercise_06_01
{
    public class Student
    {
        string surname;
        string name;
        string university;
        string faculty;
        string department;
        int age;
        int course;
        int group;
        string city;

        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }
        public string University { get => university; set => university = value; }
        public string Faculty { get => faculty; set => faculty = value; }
        public string Department { get => department; set => department = value; }
        public int Age { get => age; set => age = value; }
        public int Course { get => course; set => course = value; }
        public int Group { get => group; set => group = value; }
        public string City { get => city; set => city = value; }
        public Student()
        {
            surname = default;
            name = default;
            university = default;
            faculty = default;
            department = default;
            age = default;
            course = default;
            group = default;
            city = default;
        }
        public Student(string surname, string name, string university, string faculty, string department, int age, int course, int group, string city)
        {
            this.surname = surname;
            this.name = name;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.age = age;
            this.course = course;
            this.group = group;
            this.city = city;
        }
        /// <summary>
        /// Подсчитывает количество студентов заданного курса
        /// </summary>
        /// <param name="list">список студентов</param>
        /// <param name="course">заданный курс</param>
        /// <returns>количество студентов</returns>
        public int GetCourse(List<Student> list, int course)
        {
            int count = 0;
            foreach (var student in list)
            {
                if (student.course == course)
                {
                    count++;
                }
            }
            return count;
        }
        /// <summary>
        /// Подсчитывает количество студентов заданного возрастного интервала
        /// </summary>
        /// <param name="list">список студентов</param>
        /// <param name="minAge">минимальный возраст</param>
        /// <param name="maxAge">максимальный возраст</param>
        /// <returns>количество студентов по курсам</returns>
        public int[] GetCourse(List<Student> list, int minAge, int maxAge)
        {
            int maxCourse = 0;
            foreach (var student in list)
            {
                if (student.course > maxCourse)
                {
                    maxCourse = student.course;
                }
            }
            int[] count = new int[maxCourse];
            foreach (var student in list)
            {
                if (student.age >= minAge && student.age <= maxAge)
                {
                    count[student.course - 1]++;
                }
            }
            return count;
        }
    }
}
