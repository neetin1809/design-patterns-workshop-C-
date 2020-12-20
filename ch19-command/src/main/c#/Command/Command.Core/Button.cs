using System;

namespace Command.Core
{
    public class Button
    {
        string title;
        Calculator calculator;

        public Button(Calculator calculator, string title)
        {
            this.calculator = calculator;
            this.title = title;
        }

        public void Click()
        {
            calculator.onCommand(title);
        }
    }
}
