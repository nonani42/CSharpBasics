using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_07_02
{
    class ModelGuess
    {
        int userNum;
        int goalNum;
        public int UserNum
        {
            get
            {
                return userNum;
            }
            set
            {
                userNum = value;
            }
        }

        public int GoalNum => goalNum;
        public ModelGuess()
        {
            goalNum = new RandomNum().GetNumber();
            userNum = 0;
        }

        /// <summary>
        /// Сравнивает загаданное число с введенным пользователем
        /// </summary>
        /// <returns>-1 - введенное число меньше; 1 - введенное число больше; 0 - числа равны</returns>
        public int Check()
        {
            if (userNum == goalNum) return 0;
            else if (userNum < goalNum) return -1;
            else return 1;
        }
    }
}
