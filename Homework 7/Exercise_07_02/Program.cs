using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_07_02
{
    /// <summary>
    /// Новикова Наталья
    /// Используя Windows Forms, разработать игру «Угадай число». 
    /// Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. 
    /// Компьютер говорит, больше или меньше загаданное число введенного.
    /// a) Для ввода данных от человека используется элемент TextBox;
    /// б) ** Реализовать отдельную форму c TextBox для ввода числа.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
