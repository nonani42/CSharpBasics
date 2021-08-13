using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Exercise_05_02
{
    static class Message
    {
        /// <summary>
        /// Считывает текст из файла в строку
        /// </summary>
        /// <param name="path">путь к файлу</param>
        /// <returns></returns>
        public static string GetStringFromFile(string path)
        {
            StringBuilder builder = new StringBuilder();
            StreamReader stream = new StreamReader(path);
            while (!stream.EndOfStream)
            {
                builder.Append($"{stream.ReadLine()} ");
            }
            stream.Close();
            return builder.ToString();
        }
        /// <summary>
        /// Разделяет исходный текст на слова, убирая знаки препинания и пробелы
        /// </summary>
        /// <param name="str">исходный текст</param>
        /// <param name="separator">разделить слов</param>
        /// <returns></returns>
        public static string[] Split(string str, string separator = " ")
        {
            string tempText = Regex.Replace(str, "[-.—?!)(,:;]", " ");
            tempText = Regex.Replace(tempText, "[ ]+", " ");
            string[] arr = tempText.Split(separator);
            return arr;
        }
        /// <summary>
        /// Возвращает массив строк, длина которых не более заданной
        /// </summary>
        /// <param name="words">массив строк</param>
        /// <param name="maxLength">заданная максимальная длина строки</param>
        /// <returns></returns>
        public static string[] GetWordsByLength(string[] words, int maxLength)
        {
            List<string> goodWords = new List<string>();
            for(int i = 0; i < words.Length; i++)
            {
                if(words[i].Length <= maxLength)
                {
                    goodWords.Add(words[i]);
                }
            }
            return goodWords.ToArray();
        }
        /// <summary>
        /// Возвращает массив строк, длина которых наибольшая в исходном массиве
        /// </summary>
        /// <param name="words">массив строк</param>
        /// <returns></returns>
        public static string[] GetWordsWithMaxLength(string[] words)
        {
            int maxLength = GetMaxWordLength(words);
            List<string> goodWords = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == maxLength)
                {
                    goodWords.Add(words[i]);
                }
            }
            return goodWords.ToArray();
        }
        /// <summary>
        /// Удаляет из исходного массива слова, заканчивающиеся на указанный символ
        /// </summary>
        /// <param name="words">массив слов</param>
        /// <param name="symbol">указанный символ</param>
        /// <returns></returns>
        public static string[] RemoveWordsByEndSymbol(string[] words, char symbol)
        {
            List<string> goodWords = new List<string>(words);

            for (int i = goodWords.Count - 1; i > 0; i--)
            {
                if (goodWords[i].EndsWith(symbol))
                {
                    goodWords.Remove(words[i]);
                }
            }
            return goodWords.ToArray();
        }
        /// <summary>
        /// Возвращает длину самой длинной строки в массиве
        /// </summary>
        /// <param name="words">массив строк</param>
        /// <returns>максимальная длина</returns>
        private static int GetMaxWordLength(string[] words)
        {
            int maxLength = words[0].Length;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= maxLength)
                {
                    maxLength = words[i].Length;
                }
            }
            return maxLength;
        }

        /// <summary>
        /// Производит частотный анализ текста.
        /// </summary>
        /// <param name="words">слова для поиска</param>
        /// <param name="text">место поиска</param>
        /// <returns>частотный словарь</returns>
        public static Dictionary<string, int> GetWordsByFrequency(string[] words, string text)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                dic.TryAdd(words[i], 0);
            }
            string[] textArr = Split(text);
            for (int i = 0; i < textArr.Length; i++)
            {
                if (dic.ContainsKey(textArr[i]))
                {
                    dic[textArr[i]]++;
                }
            }
            return dic;
        }
        /// <summary>
        /// Создает строку из исходного массива строк
        /// </summary>
        /// <param name="words">исходный массив</param>
        /// <param name="separator">разделитель строк</param>
        /// <returns></returns>
        public static string GetString(string[] words, string separator = " ")
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                str.Append($"{words[i]}{separator}");
            }
            return str.ToString();
        }
        /// <summary>
        /// Выводит в консоль пары key-value из словаря
        /// </summary>
        /// <param name="msg"></param>
        public static void Print(Dictionary<string, int> dic)
        {
            foreach (KeyValuePair<string, int> pair in dic)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
