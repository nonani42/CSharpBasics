using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_07_02
{
    public partial class Form1 : Form, IView
    {
        public string Check { set => lblcheck.Text = value; }
        public string UserGuess { get => txtBox.Text; set => txtBox.Text = value; }
        public Form1()
        {
            InitializeComponent();
            Adapter adapter = new Adapter(this);
            btnStart.Click += delegate { adapter?.NewGame(); };
            txtBox.TextChanged += delegate { adapter?.CheckClick(); };
        }
    }
}
