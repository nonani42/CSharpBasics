using static Exercise_05_02.Message;
using static System.Console;
namespace Exercise_05_02
{
    /// <summary>
    /// Новикова Наталья
    /// Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
    ///а) Вывести только те слова сообщения, которые содержат не более n букв.
    ///б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    ///в) Найти самое длинное слово сообщения.
    ///г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    ///д) *** Создать метод, который производит частотный анализ текста.
    ///В качестве параметра в него передается массив слов и текст, 
    ///в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
    ///Здесь требуется использовать класс Dictionary.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = GetStringFromFile("testText1.txt");
            string[] wordsFromText = Split(text1);
            WriteLine($"\nСодержат не более 4 букв.");
            WriteLine(GetString(GetWordsByLength(wordsFromText, 4)));
            WriteLine($"\nУдалены слова, заканчивающиесся на 'а'.");
            WriteLine(GetString(RemoveWordsByEndSymbol(wordsFromText, 'а')));
            WriteLine($"\nСамые длинные слова в исходном тексте.");
            WriteLine(GetString(GetWordsWithMaxLength(wordsFromText)));
            string text2 = GetStringFromFile("testText2.txt");
            WriteLine($"\nЧастотный анализ.");
            string[] wordsToFind = { "анализ", "тексте", "текста", "букв" };
            Print(GetWordsByFrequency(wordsToFind, text2));
        }
    }
}
