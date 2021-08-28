using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_08_02
{
    public interface IView
    {
        decimal NumberUpDown { get; }
        string TextBox { set; }
    }
}
