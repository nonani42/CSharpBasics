using System;
using System.IO;

namespace Exercise_06_01
{
    public class FileWriter
    {
        public void WriteToFile(string path, int size)
        {
            StreamWriter stream = new StreamWriter(path);
            for (int i = 0; i < size; i++)
            {
                stream.WriteLine($"{new Student()}");
            }
            stream.Close();
        }
    }
}
