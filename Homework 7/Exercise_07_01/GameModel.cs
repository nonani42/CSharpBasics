using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_07_01
{
    public class GameModel
    {
        int userNum;
        int goalNum;
        int count;
        Stack<int> st;
        public int UserNum => userNum;
        public int GoalNum => goalNum;
        public int Count => count;
        public GameModel()
        {
            goalNum = new RandomLvl1().GetNumber();
            st = new Stack<int>();
            Reset();
        }
        public void Add()
        {
            userNum++;
            count++;
            st.Push(userNum);
        }
        public void Multiply()
        {
            userNum *= 2;
            count++;
            st.Push(userNum);
        }
        public void Reset()
        {
            userNum = 1;
            count = 0;
            st.Clear();
            st.Push(userNum);
        }
        public void Return()
        {
            st.Pop();
            userNum = st.Peek();
            count--;
        }
        public bool CheckStop()
        {
            return userNum == goalNum;
        }
    }
}
