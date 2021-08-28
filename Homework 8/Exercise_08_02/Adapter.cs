namespace Exercise_08_02
{
    public class Adapter
    {
        IView view;

        public Adapter(IView view)
        {
            this.view = view;
            NumBtnClick();
        }
        public void NumBtnClick()
        {
            view.TextBox = view.NumberUpDown.ToString();
        }
    }
}