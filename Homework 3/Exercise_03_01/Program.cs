using System;
namespace Exercise_03_01
{
    //Новикова Наталья
    //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры. - структура реализована как ComplexStructure
    //б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса. - класс реализован как ComplexClass
    //в) Добавить диалог с использованием switch демонстрирующий работу класса.
    struct ComplexStructure
    {
        public double re;
        public double im;
        public ComplexStructure Add(ComplexStructure x)
        {
            ComplexStructure y;
            y.re = x.re + re;
            y.im = x.im + im;
            return y;
        }
        public ComplexStructure Deduct(ComplexStructure x)
        {
            //a+b-(c+di)=(a-c)+(b-d)i
            ComplexStructure y;
            y.re = re - x.re;
            y.im = im - x.im;
            return y;
        }
        public ComplexStructure Multiply(ComplexStructure x)
        {
            ComplexStructure y;
            y.re = re * x.re - im * x.im;
            y.im = re * x.im + im * x.re;
            return y;
        }
        public ComplexStructure Divide(ComplexStructure x)
        {
            //(a+bi) / (c+di) = (a+bi) * (c-di) / (c+di) * (c-di) = (ac+bd) / (c^2+d^2) + ((bc-ad) / (c^2+d^2))i
            ComplexStructure y;
            y.re = (re * x.re + im * x.im) / (Math.Pow(x.re, 2) + Math.Pow(x.im, 2));
            y.im = (im * x.re - re * x.im) / (Math.Pow(x.re, 2) + Math.Pow(x.im, 2));
            return y;
        }
        /// <summary>
        /// Возвращает комплексное число в строковом формате.
        /// </summary>
        public override string ToString()
        {
            if (im == 0)
            {
                return $"{re}";
            }
            else if (im < 0 && re != 0)
            {
                return $"{re} - {-im}i";
            }
            else if (im < 0 && re == 0)
            {
                return $"{im}i";
            }
            else if (im > 0 && re != 0)
            {
                return $"{re} + {im}i";
            }
            else
            {
                return $"{im}i";
            }
        }
    }
    class ComplexClass
    {
        public double re { get; set; }
        public double im { get; set; }
        public ComplexClass()
        {
            re = 0;
            im = 0;
        }
        public ComplexClass(double re, double im)
        {
            this.re = re;
            this.im = im;
        }
        public ComplexClass Add(ComplexClass x)
        {
            ComplexClass y = new ComplexClass();
            y.re = x.re + re;
            y.im = x.im + im;
            return y;
        }
        public ComplexClass Deduct(ComplexClass x)
        {
            ComplexClass y = new ComplexClass();
            y.re = re - x.re;
            y.im = im - x.im;
            return y;
        }
        public ComplexClass Multiply(ComplexClass x)
        {
            ComplexClass y = new ComplexClass();
            y.re = re * x.re - im * x.im;
            y.im = re * x.im + im * x.re;
            return y;
        }
        public ComplexClass Divide(ComplexClass x)
        {
            ComplexClass y = new ComplexClass();
            y.re = (re * x.re + im * x.im) / (Math.Pow(x.re, 2) + Math.Pow(x.im, 2));
            y.im = (im * x.re - re * x.im) / (Math.Pow(x.re, 2) + Math.Pow(x.im, 2));
            return y;
        }
        /// <summary>
        /// Возвращает комплексное число в строковом формате.
        /// </summary>
        public override string ToString()
        {
            if (im == 0)
            {
                return $"{re}";
            }
            else if (im < 0 && re != 0)
            {
                return $"{re} - {-im}i";
            }
            else if (im < 0 && re == 0)
            {
                return $"{im}i";
            }
            else if (im > 0 && re != 0)
            {
                return $"{re} + {im}i";
            }
            else
            {
                return $"{im}i";
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            #region Проверка структуры
            Console.WriteLine("Проверка работы структуры.");
            ComplexStructure xStruct;
            ComplexStructure yStruct;
            xStruct.re = GetUserNum("Введите re первого комплексного числа: ");
            xStruct.im = GetUserNum("Введите im первого комплексного числа: ");
            yStruct.re = GetUserNum("Введите re второго комплексного числа: ");
            yStruct.im = GetUserNum("Введите im второго комплексного числа: ");
            Console.WriteLine($"Add: {xStruct.Add(yStruct)}");
            Console.WriteLine($"Deduct: {xStruct.Deduct(yStruct)}");
            Console.WriteLine($"Multiply: {xStruct.Multiply(yStruct)}");
            Console.WriteLine($"Divide: {xStruct.Divide(yStruct)}");
            #endregion
            Console.WriteLine("\n\n\n");
            #region Проверка класса
            Console.WriteLine("Проверка работы класса.");
            ComplexClass xClass = new ComplexClass();
            ComplexClass yClass = new ComplexClass();
            xClass.re = GetUserNum("Введите re первого комплексного числа: ");
            xClass.im = GetUserNum("Введите im первого комплексного числа: ");
            yClass.re = GetUserNum("Введите re второго комплексного числа: ");
            yClass.im = GetUserNum("Введите im второго комплексного числа: ");
            switch (GetAction())
            {
                case '+': Console.WriteLine($"Add: {xClass.Add(yClass)}"); break;
                case '-': Console.WriteLine($"Deduct: {xClass.Deduct(yClass)}"); break;
                case '*': Console.WriteLine($"Multiply: {xClass.Multiply(yClass)}"); break;
                case '/': Console.WriteLine($"Divide: {xClass.Divide(yClass)}"); break;
                default: Console.WriteLine($"Данная операция не реализована"); break;
            }
            #endregion
        }
        /// <summary>
        ///Запрашивает у пользователя оператор для совершения математической операции и возвращает его
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        private static char GetAction()
        {
            char userEnter;
            do
            {
                Console.Write("Введите оператор операции, которую необходимо произвести с этими числами (+ - * /): ");
                char.TryParse(Console.ReadLine(), out userEnter);
            } while (userEnter != '+' && userEnter != '-' && userEnter != '*' && userEnter != '/');
            return userEnter;
        }

        private static double GetUserNum(string msg)
        {
            double result;
            do
            {
                Console.Write(msg);
            } while (!Double.TryParse(Console.ReadLine(), out result));
            return result;
        }
    }
}
