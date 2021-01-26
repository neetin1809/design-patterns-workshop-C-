 using System;

namespace State.Core
{
    public class Button
    {
        private string title { get; set; }

        private Calculator calculator { get; set; }

        public Button(Calculator calculator, string title)
        {
            this.calculator = calculator;
            this.title = title;
        }

        public void click()
        {
            calculator.onCommand(title);
        }
    }
}
