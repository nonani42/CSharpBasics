using System;
using System.Windows.Forms;

namespace Exercise_08_02
{
    public partial class Form1 : Form, IView
    {
        public decimal NumberUpDown { get => numUpDn1.Value; }
        public string TextBox { set => txtBox1.Text = value; }

        public Form1()
        {
            InitializeComponent();
            Adapter adapter = new Adapter(this);
            numUpDn1.Click += delegate { adapter?.NumBtnClick(); };
        }   
}
}
