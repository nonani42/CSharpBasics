namespace Exercise_05_03
{
    /// <summary>
    /// Наталья Новикова
    /// *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
    /// Например: badc являются перестановкой abcd.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            StringClass str1 = new StringClass("WOrld'3sgr$eates111tnep hew");
            StringClass str2 = new StringClass("gre%ates  two2rld's#nePh111ew");
            StringClass str3 = new StringClass("gretestwo2rld's#nePh111ew");
            str1.CompareStrTo(str2);
            str1.CompareStrTo(str3);
        }
    }
}
