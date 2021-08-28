using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_08_03
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameDB = "testDB.xml";
            TrueFalse t = new TrueFalse(nameDB);
            Random r = new Random();
            for (int i = 0; i < numUD.Value; i++)
            {
                bool temp = Convert.ToBoolean(r.Next(0, 2));
                t.Add($"question{i} = {temp}", temp);
            }
            t.Save();
            MessageBox.Show($"Создана тестовая база данных {nameDB}.");
        }
    }
}
