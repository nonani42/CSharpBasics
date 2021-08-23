using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_07_01
{
    public class Adapter
    {
        GameModel game;
        IView view;
        public Adapter(IView view)
        {
            game = new GameModel();
            this.view = view;
            SetView();
        }
        public void AddClick()
        {
            game.Add();
            SetView();
            Stop();
        }
        public void MultiplyClick()
        {
            game.Multiply();
            SetView();
            Stop();
        }
        public void ResetClick()
        {
            game.Reset();
            SetView();
        }
        public void ReturnClick()
        {
            if(game.Count > 0)
            {
                game.Return();
                SetView();
            }
        }
        public void Start()
        {
            game = new GameModel();
            SetView();
            MessageBox.Show($"Новая игра, необходимо получить число {game.GoalNum} за наименьшее количество попыток.");
        }
        public void Stop()
        {
            if (game.CheckStop()) MessageBox.Show($"Игра окончена.");
        }
        public void SetView()
        {
            view.Set($"{game.UserNum}", $"{game.Count}", $"{game.GoalNum}");
        }
    }
}
