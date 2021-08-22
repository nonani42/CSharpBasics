using System;
using System.IO;

namespace Exercise_06_01
{
    public class FileWriter
    {
        public void WriteToFile(string path, int size)
        {
            StreamWriter stream = new StreamWriter(path);
            Random rd = new Random();
            for (int i = 0; i < size; i++)
            {
                stream.WriteLine($"фамилия_{Guid.NewGuid().ToString().Substring(0, 4)};" +
                    $"имя_{Guid.NewGuid().ToString().Substring(0, 4)};" +
                    $"университет{rd.Next(1, 4)};" +
                    $"факультет{rd.Next(1, 5)};" +
                    $"направление{rd.Next(1, 10)};" +
                    $"{rd.Next(17, 22)};" +
                    $"{rd.Next(1, 7)};" +
                    $"{rd.Next(100, 999)};" +
                    $"город{rd.Next(1, 15)};");
            }
            stream.Close();
        }
    }
}
