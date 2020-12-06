using System;

namespace Mediator.Core
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

        public void click()
        {
            calculator.onClick(title);
        }
    }
}
