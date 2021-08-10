using System;

namespace Exercise_03_03
{
    //Новикова Наталья
    //*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
    //Предусмотреть методы сложения, вычитания, умножения и деления дробей.
    //Написать программу, демонстрирующую все разработанные элементы класса.
    //Добавить свойства типа int для доступа к числителю и знаменателю;
    //Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
    //** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
    //*** Добавить упрощение дробей.
    class Fraction
    {
        int numerator;
        int denominator;
        public int Numerator
        {
            get
            {
                return numerator;
            }
            set
            {
                numerator = value;
            }
        }
        public int Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                if(value > 0)
                {
                denominator = value;
                }
                else
                {
                    throw new ArgumentException("Знаменатель не может быть меньше или равен 0");
                }
            }
        }
        public double DecFraction
        {
            get
            {
                return (double)numerator / (double)denominator;
            }
        }
        public Fraction()
        {
            numerator = 0;
            denominator = 1;
        }
        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            if (denominator > 0)
            {
                this.denominator = denominator;
            }
            else
            {
                throw new ArgumentException("Знаменатель не может быть меньше или равен 0");
            }
        }
        public Fraction(Fraction x)
        {
            numerator = x.numerator;
            if (x.denominator > 0)
            {
                denominator = x.denominator;
            }
            else
            {
                throw new ArgumentException("Знаменатель не может быть меньше или равен 0");
            }
        }
        /// <summary>
        /// Least common multiple / Наименьшее общее кратное (НОК)
        /// </summary>
        /// <param name="x1">первое число</param>
        /// <param name="x2">второе число</param>
        /// <returns></returns>
        static int LCM(int x1, int x2)
        {
            return Math.Abs(x1 * x2) / GCD(x1, x2);
        }
        /// <summary>
        /// Greatest common divisor / Наибольший общий делитель(НОД)
        /// </summary>
        /// <param name="x1">первое число</param>
        /// <param name="x2">второе число</param>
        /// <returns></returns>
        static int GCD(int x1, int x2)
        {
            while(x1 != x2)
            {
                if (x1 > x2)
                    x1 -= x2; 
                else
                    x2 -= x1;
            }
            return x2;
        }
        public Fraction Simplify()
        {
            int gcd = GCD(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;
            return this;
        }
        public Fraction Add(Fraction x)
        {
            Fraction y = new Fraction();
            int lcm = LCM(x.denominator, denominator);
            y.numerator = numerator * (lcm / denominator) + x.numerator * (lcm / x.denominator);
            y.denominator = lcm;
            return y;
        }
        public Fraction Deduct(Fraction x)
        {
            Fraction y = new Fraction();
            int lcm = LCM(x.denominator, denominator);
            y.numerator = numerator * (lcm / denominator) - x.numerator * (lcm / x.denominator);
            y.denominator = lcm;
            return y;
        }
        public Fraction Multiply(Fraction x)
        {
            Fraction y = new Fraction();
            y.numerator = numerator * x.numerator;
            y.denominator = denominator * x.denominator;
            return y;
        }
        public Fraction Divide(Fraction x)
        {
            Fraction y = new Fraction();
            if (x.numerator != 0)
            {
                y.numerator = numerator * x.denominator;
                y.denominator = denominator * x.numerator;
            }
            else
            {
                throw new ArgumentException("Числитель делителя не может быть равен 0");
            }
            return y;
        }
        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fraction frac1 = new Fraction(-1, 2);
            Fraction frac2 = new Fraction(1, 3);
            Fraction frac3 = new Fraction(frac1);
            Fraction frac4 = new Fraction(
                GetUserNum("Введите числитель: "),
                GetUserNum("Введите знаменатель: "));
            Console.WriteLine("frac1 = {0}, frac2 = {1}, frac3 = {2}, frac4 = {3}.", frac1, frac2, frac3, frac4);
            Console.WriteLine($"frac1+frac2 = {frac1.Add(frac2)}.");
            Console.WriteLine($"frac3-frac2 = {frac3.Deduct(frac2)}.");
            Console.WriteLine($"frac1*frac3 = {frac1.Multiply(frac3)}.");
            Console.WriteLine($"frac2/frac3 = {frac2.Divide(frac3)}.");
            frac3.Numerator = 15;
            frac3.Denominator = 3;
            Console.WriteLine("Изменена frac3.");
            Console.WriteLine("frac1 = {0}, frac2 = {1}, frac3 = {2}, frac4 = {3}.", frac1, frac2, frac3, frac4);
            Console.WriteLine("Упрощение frac3 = {0}.", frac3.Simplify());
            Console.WriteLine("frac1 = {0}, frac2 = {1}, frac3 = {2}, frac4 = {3}.", frac1, frac2, frac3, frac4);
            Console.WriteLine($"Decimal frac1 = {frac1.DecFraction}.");
            //frac4.Denominator = 0; //exception
            Console.WriteLine("frac1 = {0}, frac2 = {1}, frac3 = {2}, frac4 = {3}.", frac1, frac2, frac3, frac4);
        }
        private static int GetUserNum(string msg)
        {
            int result;
            do
            {
                Console.Write(msg);
            } while (!int.TryParse(Console.ReadLine(), out result));
            return result;
        }
    }
}
