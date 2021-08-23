using System;

namespace Exercise_07_01
{
    public class RandomLvl1 : IRandom
    {
        public int GetNumber()
        {
            return new Random().Next(2, 20);
        }
    }
}
