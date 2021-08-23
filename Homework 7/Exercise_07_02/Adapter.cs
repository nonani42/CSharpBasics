using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_07_02
{
    class Adapter
    {
        ModelGuess game;
        IView view;
        public Adapter(IView view)
        {
            game = new ModelGuess();
            this.view = view;
            view.Check = default;
        }
        public void NewGame()
        {
            game = new ModelGuess();
            view.UserGuess = $"";
            view.Check = default;
        }
        public void CheckClick()
        {
            int t = 0;
            if (int.TryParse(view.UserGuess, out t)) game.UserNum = t;
            switch (game.Check())
            {
                case 0:
                    view.Check = $"Точно!";
                    MessageBox.Show($"Число угадано. Игра окончена."); 
                    break;
                case -1:
                    view.Check = $"Мало.";
                    break;
                case 1:
                    view.Check = $"Много.";
                    break;
            }
        }
    }
}
