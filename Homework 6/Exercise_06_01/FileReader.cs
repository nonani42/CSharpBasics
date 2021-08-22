using System.Collections.Generic;
using System.IO;

namespace Exercise_06_01
{
    public class FileReader
    {
        public List<Student> GetFromFile(string path)
        {
            StreamReader stream = new StreamReader(path);
            List<Student> list = new List<Student>();
            string[] temp;
            while (!stream.EndOfStream)
            {
                temp = stream.ReadLine().Split(";");
                list.Add(new Student(temp[0], temp[1], temp[2], temp[3], temp[4], int.Parse(temp[5]), int.Parse(temp[6]), int.Parse(temp[7]), temp[8]));
            }
            stream.Close();
            return list;
        }
    }
}
