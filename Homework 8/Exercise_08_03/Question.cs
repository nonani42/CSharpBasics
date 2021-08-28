using System;

namespace Exercise_08_03
{
    [Serializable]
    public class Question
    {
        string text;
        bool trueFalse;
        public Question()
        {
        }
        public Question(string text, bool trueFalse)
        {
            Text = text;
            TrueFalse = trueFalse;
        }

        public string Text { get => text; set => text = value; }
        public bool TrueFalse { get => trueFalse; set => trueFalse = value; }
    }
}
