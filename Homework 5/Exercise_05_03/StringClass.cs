using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercise_05_03
{
    public class StringClass
    {
        string str;
        public StringClass(string msg)
        {
            str = msg;
        }
        /// <summary>
        /// Сравнивает две строки
        /// </summary>
        /// <param name="input"></param>
        public void CompareStrTo(StringClass input)
        {
            EditString();
            input.EditString();
            int result = str.ToString().CompareTo(input.ToString());
            switch (result)
            {
                case 0:
                    Console.WriteLine($"two strings are identical.");
                    break;
                default: Console.WriteLine($"two strings are different.");
                    break;
            }
        }
        /// <summary>
        /// Удаляет небуквенные символы, сортирует по алфавиту
        /// </summary>
        public void EditString()
        {
            str = Regex.Replace(str, "[0-9! ?.,@#$%^&*':;`№/_+(){}\"|-]", "");
            str = str.ToLower();
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
            StringBuilder builder = new StringBuilder();
            foreach(char el in arr)
            {
                builder.Append(el);
            }
            str = builder.ToString();
        }
        public override string ToString()
        {
            string tempStr = default;
            for (int i = 0; i < str.Length; i++)
            {
                tempStr += str[i];
            }
            return tempStr;
        }
    }
}
