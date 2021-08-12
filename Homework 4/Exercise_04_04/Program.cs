namespace Exercise_04_04
{
    /// <summary>
    /// Новикова Наталья
    ///Решить задачу с логинами из урока 2(задание 4), только логины и пароли считать из файла в массив. - Дополнительно создан метод для чтения из файла в словарь (не в массив)
    ///Создайте структуру Account, содержащую Login и Password.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Account authUser = new Account(default, default);
            authUser.AuthThroughArr();
            authUser.AuthAttempts = 3;
            authUser.AuthThroughDic();
        }
    }
}
