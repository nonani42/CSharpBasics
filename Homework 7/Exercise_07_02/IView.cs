﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_07_02
{
    public interface IView
    {
        string Check { set; }
        string UserGuess { get; set; }
    }
}
