using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_07_01
{
    public partial class Form1 : Form, IView
    {
        public string Number { set => lblNum.Text = value; }
        public string Count { set => lblCount.Text = value; }
        public string Goal { set => lblGoal.Text = value; }

        public Form1()
        {
            InitializeComponent();
            Adapter adapter = new Adapter(this);
            btnAdd.Click += delegate { adapter?.AddClick(); };
            btnMultiply.Click += delegate { adapter?.MultiplyClick(); };
            btnReset.Click += delegate { adapter?.ResetClick(); };
            btnPlay.Click += delegate { adapter?.Start(); };
            btnReturn.Click += delegate { adapter?.ReturnClick(); };
        }

        public void Set(string userNum, string count, string goal)
        {
            Number = userNum;
            Count = count;
            Goal = goal;
        }
    }
}
