using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_07_01
{
    public interface IView
    {
        string Number { set; }
        string Count { set; }
        string Goal { set; }
        void Set(string p1, string p2, string p3);
    }
}
