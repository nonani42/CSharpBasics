﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_07_02
{
    class RandomNum: IRandomNum
    {
        public int GetNumber()
        {
            return new Random().Next(1, 100);
        }
    }
}
